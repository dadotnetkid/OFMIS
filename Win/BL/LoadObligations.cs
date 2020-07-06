using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Models.Repository;
using Win.Actns;
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

        private void GridObligation_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetFocusedRow() is Obligations item)
                {
                    Detail(new UnitOfWork().ObligationsRepo.Find(m => m.Id == item.Id));
                }
            }
        }

        private void BtnDeleteRepoOBR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (uc.OBGridView.GetFocusedRow() is Obligations item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
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

        public void Init()
        {
            var staticSettings = new StaticSettings();
            uc.OBGridControl.DataSource = new EntityServerModeSource()
            { QueryableSource = new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year).Where(x => x.OfficeId == staticSettings.OfficeId) };
            if (uc.OBGridView.GetFocusedRow() is Obligations item)
            {
                Detail(new UnitOfWork().ObligationsRepo.Find(m => m.Id == item.Id));
            }

            uc.lblTotalOf.Text =
                $@"Total of: {new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year).Count(x => x.OfficeId == staticSettings.OfficeId)}";
        }

        public void Detail(Obligations item)
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
                uc.txtBudgetOfficer.Text = item.PBO;
                uc.txtChiefOfficer.Text = item.Chief;
                uc.txtPosition.Text = item.ChiefPosition;
                uc.txtAmount.Text = item.Amount.ToString("n2");
                uc.txtStatus.Text = item.Status;
                uc.txtBudgetCtl.Text = item.BudgetControlNo;
                uc.txtParticular.Text = item.DVParticular;
                uc.txtAdjustedAmount.Text = item.TotalAdjustedAmount?.ToString("n2");
                uc.ORDetailGridControl.DataSource = new BindingList<ORDetails>(item.ORDetails.ToList());
                uc.tabPayroll.Controls.Clear();
                uc.tabPayroll.Controls.Add(new UCPayrolls(item.Id) { Dock = DockStyle.Fill });
                uc.tabPayrollWages.Controls.Clear();
                uc.tabPayrollWages.Controls.Add(new UCPayrollWages(item) { Dock = DockStyle.Fill });
                uc.tabPayrollDiff.Controls.Clear();
                uc.tabPayrollDiff.Controls.Add(new UCPayrollDifferentials(item) { Dock = DockStyle.Fill });
                uc.tabActions.Controls.Clear();
                uc.tabActions.Controls.Add(new UCDocumentActions(item.Id, "Obligatins") { Dock = DockStyle.Fill });
                uc.lblTotal.Text = item.TotalAmount?.ToString("#,#.0#");
                uc.txtCreatedBy.Text = User.GetFullName(item.CreatedBy);
                if (uc.ORDetailsGridView.GetFocusedRow() is ORDetails obr)
                {
                    uc.lblParticulars.Text = obr.Particulars;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string search)
        {
            var staticSettings = new StaticSettings();
            var ob = new UnitOfWork().ObligationsRepo.Fetch(m => m.Year == year && m.OfficeId == staticSettings.OfficeId);
            if (ob.Any(x => x.Description.Contains(search)))
                ob = ob.Where(x => x.Description.Contains(search));
            else if (ob.Any(x => x.ControlNo.Contains(search)))
                ob = ob.Where(x => x.ControlNo.Contains(search));
            else if (ob.Any(x => x.Payees.Name.Contains(search)))
                ob = ob.Where(x => x.Payees.Name.Contains(search));
            else
                ob = new List<Obligations>().AsQueryable();
            if (uc.cboStatus.Text != "All")
                ob = ob.Where(x => x.Status.Contains(uc.cboStatus.Text));
            this.uc.OBGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = ob.Where(x => x.OfficeId == staticSettings.OfficeId)
            };
            Detail(ob.FirstOrDefault());
        }

    }
}
