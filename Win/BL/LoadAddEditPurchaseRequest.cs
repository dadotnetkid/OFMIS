using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Win.OB;
using Win.PO;
using Win.PQ;
using Win.PR;
using Win.Rprts;

namespace Win.BL
{
    public class LoadAddEditPurchaseRequest : ILoad<PurchaseRequests>, ITransactions<PurchaseRequests>
    {
        public LoadAddEditPurchaseRequest(UCPurchaseRequest uc)
        {
            this.ucPR = uc;
            ucPR.btnNew.Click += BtnNew_Click;
            ucPR.PRGrid.FocusedRowChanged += PRGrid_FocusedRowChanged;
            ucPR.btnDeleteRepoPR.ButtonClick += BtnDeleteRepoPR_ButtonClick;
            ucPR.btnEditRepoPR.ButtonClick += BtnEditRepoPR_ButtonClick;
            ucPR.btnPreview.Click += BtnPreview_Click;


        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (ucPR.PRGrid.GetFocusedRow() is PurchaseRequests pr)
            {
                frmReportViewer frm = new frmReportViewer(new rptPurchaseRequest()
                {
                    DataSource = new UnitOfWork().PurchaseRequestsRepo.Get(m => m.Id == pr.Id)
                });
                frm.ShowDialog();
            }
        }

        private void BtnEditRepoPR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ucPR.PRGrid.GetFocusedRow() is PurchaseRequests pr)
                {
                    frmAddEditPurchaseRequest frm = new frmAddEditPurchaseRequest(MethodType.Edit, pr);
                    frm.ShowDialog();
                    Detail(pr);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ((ILoad<PurchaseRequests>)this).Init();
        }

        private void BtnDeleteRepoPR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ucPR.PRGrid.GetFocusedRow() is PurchaseRequests pr)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PurchaseRequestsRepo.Delete(m => m.Id == pr.Id);
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ((ILoad<PurchaseRequests>)this).Init();
        }

        public LoadAddEditPurchaseRequest(frmAddEditPurchaseRequest frm, PurchaseRequests item)
        {
            this.frmAddEditPurchaseRequest = frm;
            this.item = item;
            frm.btnAddItems.Click += BtnAddItems_Click;
            frm.ItemsGridView.RowUpdated += ItemsGridView_RowUpdated;
            frm.btnDeleteItemRepo.ButtonClick += BtnDeleteItemRepo_ButtonClick;
            frm.btnAppropriations.Click += BtnAppropriations_Click;

        }

        private void BtnAppropriations_Click(object sender, EventArgs e)
        {
            {
                item.AppropriationId = frmAddEditPurchaseRequest.cboAccountCode.EditValue.ToInt();
                if (item.AppropriationId == 0 || item.AppropriationId == null)
                {
                    MessageBox.Show("Enter Account Code", "Incomplete Data", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //var pr = new UnitOfWork().ObligationsRepo.Fetch(m => m.PRNo == item.Id);
                //if (pr.Any())
                //{
                //    MessageBox.Show($@"Purchase request has already an obligation request with control no {pr.FirstOrDefault()?.ControlNo }.", @"Existing", MessageBoxButtons.OK,
                //        MessageBoxIcon.Error);
                //    return;
                //}

                var unitOfWork = new UnitOfWork();
                var payee = unitOfWork.PayeesRepo.Find(m => m.Name == "Earmarked PR");
                if (payee == null)
                {
                    payee = new Payees()
                    {
                        Name = "Earmarked PR",

                    };
                    unitOfWork.PayeesRepo.Insert(payee);
                    unitOfWork.Save();
                }
                frmAddEditObligation frmOBR = new frmAddEditObligation(MethodType.Add, new Obligations()
                {
                    Earmarked = true,
                    ORDetails = new List<ORDetails>() { new ORDetails() { AppropriationId = item.AppropriationId, Particulars = "PR Description" } },
                    PayeeId = payee?.Id,
                    PayeeAddress = payee?.Address,
                    PayeeOffice = payee?.Office,
                    PRNo = item.Id,
                });
                this.Save();
                frmOBR.ShowDialog();
                ((ITransactions<PurchaseRequests>)this).Detail();
            };
        }

        private void BtnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (frmAddEditPurchaseRequest.ItemsGridView.GetFocusedRow() is PRDetails pr)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PRDetailsRepo.Delete(m => m.Id == pr.Id);
                    unitOfWork.Save();
                    Detail();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            if (e.Row is PRDetails i)
            {
                i.TotalAmount = i.Quantity * i.Cost;
                if (i.Id == 0)
                {
                    unitOfWork.PRDetailsRepo.Insert(i);
                }
                else
                {
                    unitOfWork.PRDetailsRepo.Update(new PRDetails()
                    {
                        Id = i.Id,
                        Category = i.Category,
                        Item = i.Item,
                        Cost = i.Cost,
                        PRId = i.PRId,
                        ItemNo = i.ItemNo,
                        Quantity = i.Quantity,
                        TotalAmount = i.TotalAmount,
                        UOM = i.UOM
                    });
                }
                unitOfWork.Save();
            }
        }

        private bool isClosed;
        private frmAddEditPurchaseRequest frmAddEditPurchaseRequest;
        private PurchaseRequests item;
        private UCPurchaseRequest ucPR;
        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                StaticSettings staticSettings = new StaticSettings();
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == item.Id);
                item.Date = frmAddEditPurchaseRequest.dtDate.DateTime;
                item.ControlNo = frmAddEditPurchaseRequest.txtControlNumber.Text;
                item.Description = frmAddEditPurchaseRequest.txtDescription.Text;
                item.AppropriationId = frmAddEditPurchaseRequest.cboAccountCode.EditValue?.ToInt();
                item.Purpose = frmAddEditPurchaseRequest.txtPurpose.Text;
                item.TotalAmount = item.PRDetails.Sum(m => m.TotalAmount);
                item.TotalAmount = item.PRDetails.Sum(m => m.TotalAmount);
                item.OfficeId = new StaticSettings().OfficeId;

                item.PA = unitOfWork.ChiefOfOfficesRepo.Find(m => m.Position == "Public Administrator")?.Person;
                item.PAPos = unitOfWork.ChiefOfOfficesRepo.Find(m => m.Position == "Public Administrator")?.Position;
                item.DivisionHead = staticSettings.Head;
                item.DivisionHeadPos = staticSettings.HeadPos;

                if (frmAddEditPurchaseRequest.cboApprovedBy.GetSelectedDataRow() is Signatories signatories)
                {
                    item.DeptHead = signatories.Person;
                    item.DeptHeadPos = signatories.Position;
                }
                unitOfWork.Save();
                isClosed = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Detail()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var staticSettings = new StaticSettings();

            frmAddEditPurchaseRequest.cboAccountCode.Properties.DataSource =
                new BindingList<Appropriations>(unitOfWork.AppropriationsRepoRepo.Get(m => m.Year == staticSettings.Year && m.OfficeId == staticSettings.OfficeId));
            item = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == item.Id);
            frmAddEditPurchaseRequest.dtDate.EditValue = item.Date ?? DateTime.Now;
            frmAddEditPurchaseRequest.txtControlNumber.Text = item.ControlNo;
            frmAddEditPurchaseRequest.txtDescription.Text = item.Description;
            frmAddEditPurchaseRequest.cboAccountCode.EditValue = item.AppropriationId;
            frmAddEditPurchaseRequest.txtPurpose.Text = item.Purpose;
            frmAddEditPurchaseRequest.cboApprovedBy.Properties.DataSource =
                new BindingList<Signatories>(unitOfWork.ChiefOfOfficesRepo.Get(m => m.Office == staticSettings.Offices.UnderOfOffice.OfficeName));
            frmAddEditPurchaseRequest.txtChiefOfficer.Text = string.IsNullOrWhiteSpace(item.DivisionHead) ? staticSettings.Head : item.DivisionHead;
            frmAddEditPurchaseRequest.cboApprovedBy.EditValue = item.DeptHead ?? unitOfWork.ChiefOfOfficesRepo
                .Get(m => m.Office == staticSettings.Offices.UnderOfOffice.OfficeName).FirstOrDefault()?.Person;

            frmAddEditPurchaseRequest.ItemsGridControl.DataSource =
                new BindingList<PRDetails>(unitOfWork.PRDetailsRepo.Get(m => m.PRId == item.Id));

            frmAddEditPurchaseRequest.cboUOMRepo.DataSource =
                unitOfWork.ItemsRepo.Fetch().GroupBy(x => x.UOM).Select(x => new { UOM = x.Key }).ToList();
            frmAddEditPurchaseRequest.cboCategoryRepo.DataSource = unitOfWork.CategoriesRepo.Get();
        }

        void ITransactions<PurchaseRequests>.Init()
        {
            try
            {
                if (methodType == MethodType.Add)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();

                    var id = ((unitOfWork.PurchaseRequestsRepo.Fetch().OrderByDescending(m => m.Id).FirstOrDefault()
                                   ?.Id ?? 0) + 1);
                    var controlNo = DateTime.Now.ToString("yyyy-MM-") + id.ToString("0000");
                    item = new PurchaseRequests()
                    {
                        ControlNo = controlNo,
                        Id = id,
                        OfficeId = new StaticSettings().OfficeId
                    };
                    unitOfWork.PurchaseRequestsRepo.Insert(item);
                    unitOfWork.Save();
                }
                Detail();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddItems_Click(object sender, EventArgs e)
        {
            frmItems frmItems = new frmItems(item);
            frmItems.ShowDialog();
            Detail();
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            try
            {
                if (this.isClosed)
                {

                    return;
                }
                if (this.methodType == MethodType.Edit)
                    return;
                if (MessageBox.Show("Do you want to close this?", "close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PurchaseRequestsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ILoad<PurchaseRequests>.Init()
        {
            var staticSetting = new StaticSettings();
            ucPR.PRGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PurchaseRequestsRepo.Fetch(m => m.OfficeId == staticSetting.OfficeId),
                DefaultSorting = "Id ASC"
            };


        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddEditPurchaseRequest frmAddEditPurchaseRequest = new frmAddEditPurchaseRequest(MethodType.Add, new PurchaseRequests());
            frmAddEditPurchaseRequest.ShowDialog();
            ((ILoad<PurchaseRequests>)this).Init();
        }

        private void PRGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetFocusedRow() is PurchaseRequests pr)
                {
                    Detail(pr);
                }
            }
        }

        public void Detail(PurchaseRequests pr)
        {
            pr = new UnitOfWork().PurchaseRequestsRepo.Find(m => m.Id == pr.Id);
            if (pr == null)
                return;
            ucPR.lblHeader.Text = pr.ControlNo + " - " + pr.Description;
            ucPR.dtDate.EditValue = pr.Date;
            ucPR.txtControlNumber.Text = pr.ControlNo;
            ucPR.txtDescription.Text = pr.Description;
            ucPR.txtPurpose.Text = pr.Purpose;
            ucPR.txtAmount.EditValue = pr.TotalAmount;
            ucPR.txtAccountCode.EditValue = pr.Appropriations?.AccountCode + " - " + pr.Appropriations?.AccountName;
            ucPR.ItemsGridControl.DataSource = new BindingList<PRDetails>(pr.PRDetails.ToList());
            ucPR.PQTabPage.Controls.Clear();
            ucPR.PQTabPage.Controls.Add(new UCPQ(pr) { Dock = DockStyle.Fill });
            ucPR.tabPO.Controls.Clear();
            ucPR.tabPO.Controls.Add(new UCPO(pr) { Dock = DockStyle.Fill });
        }

        public void Search(string search)
        {

        }
    }
}
