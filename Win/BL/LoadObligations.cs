using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Newtonsoft.Json;
using Win.Actns;
using Win.Itnrry;
using Win.LR;
using Win.Ltr;
using Win.OB;
using Win.Pyrll;

namespace Win.BL
{
    public class LoadObligations : ILoad<Obligations>
    {
        private ucObligations uc;
        private int year = new StaticSettings().Year;
        public LoadObligations(ucObligations uc)
        {
            this.uc = uc;
            uc.btnDeleteRepoOBR.ButtonClick += BtnDeleteRepoOBR_ButtonClick;
            uc.btnEditRepoOBR.ButtonClick += BtnEditRepoOBR_ButtonClick;
            uc.OBGridView.FocusedRowChanged += GridObligation_FocusedRowChanged;
            uc.btnEditDV.Click += BtnEditDV_Click;
            uc.btnDelORDetailRepo.ButtonClick += BtnDelORDetailRepo_ButtonClick;
            uc.ORDetailsGridView.FocusedRowChanged += ORDetailsGridView_FocusedRowChanged;
        }

        private void ORDetailsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView grid)
            {
                if (grid.GetFocusedRow() is ORDetails item)
                {
                    uc.lblParticulars.Text = item.Particulars;
                }
            }
        }

        private void BtnDelORDetailRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!User.UserInAction("can delete"))
                    return;
                if (sender is GridView gridView)
                    if (gridView.GetFocusedRow() is ORDetails item)
                    {
                        UnitOfWork unitOfWork = new UnitOfWork();
                        unitOfWork.ORDetailsRepo.Delete(m => m.Id == item.Id);
                        unitOfWork.Save();
                        Detail(item.Obligations);
                    }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditDV_Click(object sender, EventArgs e)
        {
            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                var rowHandle = uc.OBGridView.FocusedRowHandle;

                if (!User.CheckOwner(item.CreatedBy))
                    return;

                frmEditDisbursementVoucher frm = new frmEditDisbursementVoucher(new UnitOfWork().ObligationsRepo.Find(x => x.Id == item.Id));
                frm.ShowDialog();
                Detail(new UnitOfWork().ObligationsRepo.Find(x => x.Id == item.Id));
                uc.OBGridView.FocusedRowHandle = rowHandle;
                uc.OBGridView.MakeRowVisible(rowHandle);
            }
        }

        private void BtnEditRepoOBR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EditObR();

        }

        public void EditObR()
        {

            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                if (!User.CheckOwner(item.CreatedBy))
                    return;

                var rowHandle = uc.OBGridView.FocusedRowHandle;
                frmAddEditObligation frm = new frmAddEditObligation(MethodType.Edit, item);
                frm.ShowDialog();
                //    Init();
                Detail(new UnitOfWork().ObligationsRepo.Find(m => m.Id == item.Id));
                uc.OBGridView.FocusedRowHandle = rowHandle;
                uc.OBGridView.MakeRowVisible(rowHandle);
            }
        }
        public async void EditObR(Obligations item)
        {


            if (!User.CheckOwner(item.CreatedBy))
                return;

            var rowHandle = uc.OBGridView.FocusedRowHandle;
            frmAddEditObligation frm = new frmAddEditObligation(MethodType.Edit, item);
            frm.ShowDialog();
            //    Init();
            Detail(await new UnitOfWork().ObligationsRepo.FindAsync(m => m.Id == item.Id));
            uc.OBGridView.FocusedRowHandle = rowHandle;
            uc.OBGridView.MakeRowVisible(rowHandle);
        }
        private async void GridObligation_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetFocusedRow() is Obligations item)
                {
                    uc.lblStatus.Text = "Querying...";

                    Detail(await new UnitOfWork().ObligationsRepo.FindAsync(m => m.Id == item.Id));
                    uc.lblStatus.Text = "";
                }
            }
        }


        private async void BtnDeleteRepoOBR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!User.UserInAction("can delete"))
                    return;
                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (uc.OBGridView.GetFocusedRow() is Obligations item)
                {

                    TrashbinHelper trashbinHelper = new TrashbinHelper();
                    UnitOfWork unitOfWork = new UnitOfWork(false, false);
                    item = await unitOfWork.ObligationsRepo.FindAsync(x => x.Id == item.Id, false, includeProperties: "PurchaseOrders,ORDetails,Payrolls,PayrollWages,PayrollDifferentials,Liquidations,Letters");
                    trashbinHelper.Delete(item, "Obligations", item.Description, User.UserId, new StaticSettings().OfficeId);

                    unitOfWork.ObligationsRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void Init()
        {
            var staticSettings = new StaticSettings();
            var ft = Win.Properties.Settings.Default.FundType;

            uc.lblStatus.Text = "Querying...";
            uc.OBGridView.ShowLoadingPanel();


            if (Win.Properties.Settings.Default.FundType != "GF")
            {
                uc.OBGridControl.DataSource = await new UnitOfWork().ObligationsRepo.Fetch(
                    m => m.OfficeId == staticSettings.OfficeId && m.FT == ft,
                    orderBy: x => x.OrderByDescending(m => m.Id), includeProperties: "Payees,ORDetails,CreatedByUser").ToListAsync();
            }
            else
            {
                uc.OBGridControl.DataSource = await new UnitOfWork().ObligationsRepo.Fetch(
                    m => m.Year == year && m.OfficeId == staticSettings.OfficeId && m.FT == ft,
                    orderBy: x => x.OrderByDescending(m => m.Id), includeProperties: "Payees,ORDetails,CreatedByUser").ToListAsync();
            }

            uc.lblStatus.Text = "";
            //var res = new UnitOfWork(false, false).ObligationsRepo
            //    .Get(m => m.Year == year).Where(x => x.OfficeId == staticSettings.OfficeId).ToList();
            //uc.OBGridControl.DataSource = new BindingList<Obligations>(res);
            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                Detail(await new UnitOfWork().ObligationsRepo.Fetch(m => m.Id == item.Id, "Payees,ORDetails,CreatedByUser").FirstOrDefaultAsync());
            }

            uc.lblTotalOf.Text =
                $@"Total of: {new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year).Select(x => new { x.OfficeId }).Count(x => x.OfficeId == staticSettings.OfficeId)}";
            uc.OBGridView.HideLoadingPanel();
        }

        public async void Detail(Obligations item)
        {
            try
            {
                if (item == null)
                    return;
                uc.lblHeader.Text = item.ControlNo + " - " + item.Payees?.Name;
                uc.txtDate.Text = item.Date.ToString();
                uc.txtControl.Text = item.ControlNo;
                uc.txtPayee.Text = item.Payees?.Name;
                uc.txtOffice.Text = item.Payees?.Office;
                uc.txtAddress.Text = item.Payees?.Address;
                uc.txtORDescription.Text = item.Description;
                if (item.CreatedByUser.Offices.IsDivision != true)
                {
                    uc.txtRO.Text = item.OBRApprovedBy;
                    uc.txtROPOs.Text = item.OBRApprovedByPos;
                }
                else
                {

                    uc.txtChiefOfficer.Text = item.Chief;
                    uc.txtPosition.Text = item.ChiefPosition;
                }


                uc.txtAmount.Text = item.Amount.ToString("n2");
                uc.txtStatus.Text = item.Status;
                uc.txtBudgetCtl.Text = item.BudgetControlNo;
                uc.txtParticular.Text = item.DVParticular;
                uc.txtAdjustedAmount.Text = item.TotalAdjustedAmount?.ToString("n2");
                uc.ORDetailGridControl.DataSource = new BindingList<ORDetails>(await new UnitOfWork().ORDetailsRepo.Fetch(x => x.ObligationId == item.Id).ToListAsync());
                uc.tabPayroll.Controls.Clear();
                uc.tabPayroll.Controls.Add(new UCPayrolls(item.Id) { Dock = DockStyle.Fill });
                uc.tabPayrollWages.Controls.Clear();
                uc.tabPayrollWages.Controls.Add(new UCPayrollWages(item) { Dock = DockStyle.Fill });
                uc.tabPayrollDiff.Controls.Clear();
                uc.tabPayrollDiff.Controls.Add(new UCPayrollDifferentials(item) { Dock = DockStyle.Fill });
                uc.tabActions.Controls.Clear();
                uc.tabActions.Controls.Add(new UCDocumentActions(item.Id, item.ControlNo, item.BudgetControlNo, "Obligations") { Dock = DockStyle.Fill });
                uc.tabLR.Controls.Clear();
                uc.tabLR.Controls.Add(new UCLR(item) { Dock = DockStyle.Fill });
                uc.tabLetters.Controls.Clear();
                uc.tabLetters.Controls.Add(new UcLetters(item.Id, item.ControlNo, "Obligation") { Dock = DockStyle.Fill });
                uc.tabIOT.Controls.Clear();
                uc.tabIOT.Controls.Add(new UCIteneraryOfTravel(item.Id) { Dock = DockStyle.Fill });
                uc.lblTotal.Text = item.TotalAmount?.ToString("#,#.0#");
                uc.tabFiles.Controls.Clear();
                uc.tabFiles.Controls.Add(new UCFiles(item.Id, item.ControlNo)
                {
                    Dock = DockStyle.Fill
                });
                uc.txtCreatedBy.Text = item.CreatedByUser?.FullName;

                if (uc.ORDetailsGridView.GetFocusedRow() is ORDetails obr)
                {
                    uc.lblParticulars.Text = obr.Particulars;
                }

                uc.tabOT.Controls.Clear();
                uc.tabOT.Controls.Add(new UCPayrollOT(item.Id){Dock=DockStyle.Fill});

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            Search(search, false);
        }

        public void Search(string search, bool byYear)
        {
            if (byYear)
            {
                _search(search);
                return;
            }

            var staticSettings = new StaticSettings();

            var ob = new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year && m.OfficeId == staticSettings.OfficeId && m.FT == staticSettings.FT);
            if (staticSettings.FT != "GF")
                ob = new UnitOfWork().ObligationsRepo.Fetch(m => m.FT == staticSettings.FT && m.OfficeId == staticSettings.OfficeId);
            if (ob.Any(x => x.Description.Contains(search)))
                ob = ob.Where(x => x.Description.Contains(search));
            else if (ob.Any(x => x.ControlNo.Contains(search)))
                ob = ob.Where(x => x.ControlNo.Contains(search));
            else if (ob.Any(x => x.Payees.Name.Contains(search)))
                ob = ob.Where(x => x.Payees.Name.Contains(search));
            else
                ob = new List<Obligations>().AsQueryable(); if (uc.cboStatus.Text != "All")
                ob = ob.Where(x => x.Status.Contains(uc.cboStatus.Text));
            if (search.Contains("to"))
            {
                var amount = search.Split(new String[] { "to" }, StringSplitOptions.None);
                var amount1 = amount[0].ToDecimal();
                var amount2 = amount[1].ToDecimal();
                var res = new BindingList<Obligations>(new UnitOfWork().ObligationsRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId).ToList().Where(x => x.TotalAmount >= amount1 && x.TotalAmount <= amount2).ToList());
                this.uc.OBGridControl.DataSource = res;

                Detail(res.FirstOrDefault());
                return;
            }
            this.uc.OBGridControl.DataSource =
                new BindingList<Obligations>(ob.Where(x => x.OfficeId == staticSettings.OfficeId).ToList());
            Detail(ob.FirstOrDefault());
        }
        private void _search(string search)
        {
            var staticSettings = new StaticSettings();
            var ob = new UnitOfWork().ObligationsRepo.Fetch(m => m.OfficeId == staticSettings.OfficeId && m.FT == staticSettings.FT);
            if (ob.Any(x => x.Description.Contains(search)))
                ob = ob.Where(x => x.Description.Contains(search));
            else if (ob.Any(x => x.ControlNo.Contains(search)))
                ob = ob.Where(x => x.ControlNo.Contains(search));
            else if (ob.Any(x => x.Payees.Name.Contains(search)))
                ob = ob.Where(x => x.Payees.Name.Contains(search));
            else
                ob = new List<Obligations>().AsQueryable(); if (uc.cboStatus.Text != "All")
                ob = ob.Where(x => x.Status.Contains(uc.cboStatus.Text));
            this.uc.OBGridControl.DataSource =
                new BindingList<Obligations>(ob.Where(x => x.OfficeId == staticSettings.OfficeId).ToList());
            Detail(ob.FirstOrDefault());
        }
    }
}
