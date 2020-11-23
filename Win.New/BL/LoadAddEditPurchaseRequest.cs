using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using Helpers;
using Models;
using Models.Repository;
using Win.Actns;
using Win.AIRpt;
using Win.AOQ;
using Win.APR;
using Win.Ltr;
using Win.OB;
using Win.PO;
using Win.PQ;
using Win.PropAckRcpt;
using Win.PropIsSlp;
using Win.PR;
using Win.Rprts;
using Win.ReqIsSlp;

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
                UnitOfWork unitOfWork = new UnitOfWork();
                var model = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == pr.Id);
                var officeId = User.OfficeId();
                var office = unitOfWork.OfficesRepo.Find(x => x.Id == officeId);
                model.PRDetails = model?.PRDetails.OrderBy(x => x.ItemNo).ToList();
                model.ControlNo = IdHelper.ReplaceOldControlNo(officeId, "PR", model.ControlNo);
                foreach (var i in model.PRDetails.Where(x => !x.Item.Contains("rtf1")))
                {

                    var rtf = new RichTextBox();
                    rtf.Font = new Font("Calibri", 9.5f);
                    rtf.Text = i.Item;
                    i.Item = rtf.Rtf;
                }

                unitOfWork.Save();
                var rpt = new rptPurchaseRequest()
                {
                    DataSource = new List<PurchaseRequests>() { model }
                };
                if (office.IsDivision != true)
                {
                    foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => x.Tag == "Division"))
                    {
                        control.Visible = false;
                    }

                    rpt.lblDepName.DataBindings.Clear();
                    rpt.lblDepName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
                        new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[OfficeName]")});
                }

                rpt.CreateDocument();
                if (rpt.Pages.Count == 1)
                {
                    rpt.grpFooter.PrintAtBottom = true;
                }


                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }
        }

        private void BtnEditRepoPR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ucPR.PRGrid.GetFocusedRow() is PurchaseRequests pr)
                {
                    var rowHandle = ucPR.PRGrid.FocusedRowHandle;
                    if (!User.CheckOwner(pr.CreatedBy))
                        return;
                    frmAddEditPurchaseRequest frm = new frmAddEditPurchaseRequest(MethodType.Edit, pr);
                    frm.lblHeader.Text = "Edit Purchase Request";
                    frm.ShowDialog();
                    // ((ILoad<PurchaseRequests>) this).Init();
                    Detail(pr);
                    ucPR.PRGrid.FocusedRowHandle = rowHandle;
                    ucPR.PRGrid.MakeRowVisible(rowHandle);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //       ;
        }

        private void BtnDeleteRepoPR_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!User.UserInAction("can delete"))
                    return;
                if (ucPR.PRGrid.GetFocusedRow() is PurchaseRequests pr)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork(false, false);
                    TrashbinHelper trashbinHelper = new TrashbinHelper();
                    pr = unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == pr.Id, false, includeProperties: "AIReports,AOQ,APRs,PIS,PRDetails,PriceQuotations,PurchaseOrders,PAR,ICS");
                    trashbinHelper.Delete(pr, "PurchaseRequests", pr.Description, User.UserId, new StaticSettings().OfficeId);
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
            frm.btnCreateObR.Click += btnCreateObR_Click;

        }

        private void btnCreateObR_Click(object sender, EventArgs e)
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
                    var prId = pr.Id;
                    unitOfWork.PRDetailsRepo.Delete(m => m.Id == pr.Id);
                    unitOfWork.Save();
                    int counter = 1;
                    foreach (var i in unitOfWork.PRDetailsRepo.Get(x => x.PRId == prId))
                    {

                        i.ItemNo = counter;
                        counter++;
                    }
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
                    i.PRId = item.Id;
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

        public bool isClosed;
        private frmAddEditPurchaseRequest frmAddEditPurchaseRequest;
        public PurchaseRequests item;
        private UCPurchaseRequest ucPR;
        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                StaticSettings staticSettings = new StaticSettings();
                UnitOfWork unitOfWork = new UnitOfWork();

                item = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == item.Id);
                if (frmAddEditPurchaseRequest.chkIsCancelled.Checked)
                    if (string.IsNullOrEmpty(item.CancellationReason) && item.IsCancelled != true)
                    {
                        new frmCancellationReason(item.Id).ShowDialog();
                        unitOfWork.DocumentActionsRepo.Insert(new DocumentActions()
                        {
                            ActionDate = DateTime.Now,
                            ActionTaken = "PR Cancelled",
                            RefId = item.Id,
                            TableName = "PurchaseRequests",
                            DateCreated = DateTime.Now,
                            CreatedBy = User.UserId,
                            Year = staticSettings.Year,
                            ControlNo = item.ControlNo,
                        });
                    }

                item.Date = frmAddEditPurchaseRequest.dtDate.DateTime;
                item.ControlNo = frmAddEditPurchaseRequest.txtControlNumber.Text;
                item.Description = frmAddEditPurchaseRequest.txtDescription.Text;
                item.AppropriationId = frmAddEditPurchaseRequest.cboAccountCode.EditValue?.ToInt();
                item.Purpose = frmAddEditPurchaseRequest.txtPurpose.Text;
                item.TotalAmount = item.PRDetails.Sum(m => m.TotalAmount);
                item.TotalAmount = item.PRDetails.Sum(m => m.TotalAmount);
                item.BudgetControlNo = frmAddEditPurchaseRequest.txtBudgetControl.Text;
                item.IsCancelled = frmAddEditPurchaseRequest.chkIsCancelled.Checked;
                if (frmAddEditPurchaseRequest.cboApprovedBy.GetSelectedDataRow() is Signatories pa)
                {
                    item.PA = pa.Person; //unitOfWork.Signatories.Find(m => m.Position == "Provincial Administrator")?.Person;
                    item.PAPos = pa.Position;//unitOfWork.Signatories.Find(m => m.Position == "Provincial Administrator")?.Position;
                }

                item.DivisionHead = staticSettings.Head;
                item.DivisionHeadPos = staticSettings.HeadPos;
                item.IsEarmark = frmAddEditPurchaseRequest.chkEarmarked.EditValue?.ToBool();

                var appropriation = unitOfWork.AppropriationsRepoRepo.Find(x => x.Id == item.AppropriationId);

                /* item.Purpose =
                     item?.Purpose?.Replace($" charged to {appropriation?.AccountName} - {appropriation?.AccountCode}", "") + $" charged to {appropriation?.AccountName} - {appropriation?.AccountCodeText}";*/
                if (frmAddEditPurchaseRequest.cboDeptHead.GetSelectedDataRow() is Signatories signatories)
                {
                    item.DeptHead = signatories.Person;
                    item.DeptHeadPos = signatories.Position;
                }

                if (frmAddEditPurchaseRequest.cboObRNo.GetSelectedDataRow() is Obligations obr)
                {
                    if (obr.PRNo != null)
                    {

                        if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                    }

                    if (item.Obligations.Any())
                    {
                        item.Obligations.Clear();
                    }
                    obr = unitOfWork.ObligationsRepo.Find(x => x.Id == obr.Id);
                    obr.PRNo = item.Id;
                }

             //   item.IsClosed = frmAddEditPurchaseRequest.chkIsClosed.Checked;
                if (item.IsClosed)
                {
                    if (!unitOfWork.DocumentActionsRepo.Fetch(x => x.ActionTaken == "Transaction completed" && x.RefId == item.Id && x.TableName == "PurchaseRequests").Any())
                        unitOfWork.DocumentActionsRepo.Insert(new DocumentActions()
                        {
                            ControlNo = item.ControlNo,
                            ObR_PR_No = item.BudgetControlNo,
                            ActionDate = DateTime.Now,
                            DateCreated = DateTime.Now,
                            CreatedBy = User.UserId,
                            ActionTaken = "Transaction completed",
                            RefId = item.Id,
                            TableName = "PurchaseRequests",

                        });
                }
                unitOfWork.Save();


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
            this.frmAddEditPurchaseRequest.cboObRNo.Properties.DataSource = unitOfWork.ObligationsRepo.Get(m => m.OfficeId == staticSettings.OfficeId);
            this.frmAddEditPurchaseRequest.cboApprovedBy.Properties.DataSource = unitOfWork.Signatories.Get(x => x.Position == "Provincial Administrator" || x.Position == "Governor" || x.Office == "Governor's Office");
            item = unitOfWork.PurchaseRequestsRepo.Find(m => m.Id == item.Id);
            frmAddEditPurchaseRequest.dtDate.EditValue = item.Date ?? DateTime.Now;
            frmAddEditPurchaseRequest.txtControlNumber.Text = item.ControlNo;
            frmAddEditPurchaseRequest.txtDescription.Text = item.Description;
            frmAddEditPurchaseRequest.cboAccountCode.EditValue = item.AppropriationId;
            frmAddEditPurchaseRequest.txtPurpose.Text = item.Purpose;
            frmAddEditPurchaseRequest.txtBudgetControl.Text = item.BudgetControlNo;
            var officeName = staticSettings.Offices?.UnderOfOffice?.OfficeName ?? staticSettings.OfficeName;
            frmAddEditPurchaseRequest.cboDeptHead.Properties.DataSource =
                new BindingList<Signatories>(unitOfWork.Signatories.Get(m => m.Office == officeName));

            frmAddEditPurchaseRequest.txtChiefOfficer.Text = item.DivisionHead?.ToUpper();
            frmAddEditPurchaseRequest.cboDeptHead.EditValue = item.DeptHead ?? unitOfWork.Signatories
                .Get(m => m.Office == officeName).FirstOrDefault()?.Person;

            frmAddEditPurchaseRequest.ItemsGridControl.DataSource =
                new BindingList<PRDetails>(unitOfWork.PRDetailsRepo.Get(m => m.PRId == item.Id).OrderBy(x => x.ItemNo).ToList());

            frmAddEditPurchaseRequest.cboUOMRepo.DataSource =
                unitOfWork.ItemsRepo.Fetch().GroupBy(x => x.UOM).Select(x => new { UOM = x.Key }).ToList();
            frmAddEditPurchaseRequest.cboCategoryRepo.DataSource = unitOfWork.CategoriesRepo.Get();
            frmAddEditPurchaseRequest.chkEarmarked.EditValue = item.IsEarmark;
            frmAddEditPurchaseRequest.cboApprovedBy.EditValue = item.PA;
         //   frmAddEditPurchaseRequest.chkIsClosed.Checked = item.IsClosed;
            frmAddEditPurchaseRequest.chkIsCancelled.Checked = item.IsCancelled.ToBool();
        }

        void ITransactions<PurchaseRequests>.Init()
        {
            try
            {
                if (methodType == MethodType.Add)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    StaticSettings staticSettings = new StaticSettings();
                    var pr = unitOfWork.PurchaseRequestsRepo.Fetch(m => m.OfficeId == staticSettings.OfficeId)
                        .OrderByDescending(m => m.Id).FirstOrDefault();
                    item = new PurchaseRequests()
                    {
                        ControlNo = IdHelper.OfficeControlNo(pr?.ControlNo, staticSettings.OfficeId, "PR", "PurchaseRequests"),
                        DivisionHead = staticSettings.Offices.IsDivision == true ? staticSettings.Head : "",
                        DivisionHeadPos = staticSettings.Offices.IsDivision == true ? staticSettings.Head : "",
                        OfficeId = staticSettings.OfficeId,
                        CreatedBy = User.UserId,
                        Year = staticSettings.Year,
                        FT = Win.Properties.Settings.Default.FundType
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
            frmItems frmItems = new frmItems(item, frmAddEditPurchaseRequest);
            frmItems.ShowDialog();
            frmAddEditPurchaseRequest.ItemsGridControl.DataSource =
                new BindingList<PRDetails>(new UnitOfWork().PRDetailsRepo.Get(m => m.PRId == item.Id));
            Save();
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
            var ft = Win.Properties.Settings.Default.FundType;
            ucPR.PRGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PurchaseRequestsRepo.Fetch(m => m.OfficeId == staticSetting.OfficeId && m.Year == staticSetting.Year && m.FT == ft),
                DefaultSorting = "Id ASC"
            };


        }
        void Init(PurchaseRequests pr)
        {
            var staticSetting = new StaticSettings();
            ucPR.PRGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PurchaseRequestsRepo
                    .Fetch(m => m.OfficeId == staticSetting.OfficeId && m.Year == staticSetting.Year)
            };

            /*new BindingList<PurchaseRequests>(new UnitOfWork().PurchaseRequestsRepo
            .Fetch(m => m.OfficeId == staticSetting.OfficeId).ToList());*/

            var id = ucPR.PRGrid.LocateByValue("Id", pr.Id);
            ucPR.PRGrid.FocusedRowHandle = id;
            ucPR.PRGrid.MakeRowVisible(id);
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddEditPurchaseRequest frmAddEditPurchaseRequest = new frmAddEditPurchaseRequest(MethodType.Add, new PurchaseRequests());
            frmAddEditPurchaseRequest res = (frmAddEditPurchaseRequest)frmAddEditPurchaseRequest.ShowDialogBox();
            Init(res.Item);
            //res.Item

            Detail(res.Item);
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
            ucPR.chkIsClosed.Checked = pr.IsClosed;
            ucPR.chkEarmarked.Checked = pr.IsEarmark ?? false;
            ucPR.chkCancelled.Checked = pr.IsCancelled ?? false;
            ucPR.txtReason.EditValue = pr.CancellationReason;
            ucPR.ItemsGridControl.DataSource = new BindingList<PRDetails>(pr.PRDetails.OrderBy(x => x.ItemNo).ToList());

            ucPR.PQTabPage.Controls.Clear();
            ucPR.PQTabPage.Controls.Add(new UCPQ(pr) { Dock = DockStyle.Fill });
            ucPR.tabPO.Controls.Clear();
            ucPR.tabPO.Controls.Add(new UCPO(pr) { Dock = DockStyle.Fill });
            ucPR.tabAOQ.Controls.Clear();
            ucPR.tabAOQ.Controls.Add(new UCAOQ(pr) { Dock = DockStyle.Fill });
            ucPR.LetterTabPage.Controls.Clear();
            ucPR.LetterTabPage.Controls.Add(new UcLetters(pr.Id, pr.ControlNo, "PurchaseRequest") { Dock = DockStyle.Fill });
            ucPR.tabAPR.Controls.Clear();
            ucPR.tabAPR.Controls.Add(new UCAPRs(pr) { Dock = DockStyle.Fill });
            ucPR.tabActions.Controls.Clear();
            ucPR.tabActions.Controls.Add(new UCDocumentActions(pr.Id, pr.ControlNo, pr.BudgetControlNo, "PurchaseRequests") { Dock = DockStyle.Fill });
            ucPR.tabAcceptance.Controls.Clear();
            ucPR.tabAcceptance.Controls.Add(new UCAIReports(pr) { Dock = DockStyle.Fill });
            ucPR.tabPIS.Controls.Clear();
            ucPR.tabPIS.Controls.Add(new UCPIS(pr) { Dock = DockStyle.Fill });
            ucPR.tabPAR.Controls.Clear();
            ucPR.tabPAR.Controls.Add(new UCPAR(pr) { Dock = DockStyle.Fill });
            ucPR.tabRIS.Controls.Clear();
            ucPR.tabRIS.Controls.Add(new UCRIS(pr.Id) {Dock = DockStyle.Fill});
        }

        public void Search(string search)
        {
            Search(search, false);
        }

        public void Search(string search, bool byYear)
        {
            try
            {
                if (byYear)
                {
                    _search(search);
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                var status = ucPR.chkIsClosed.Checked;

                ucPR.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => x.Year == staticSettings.Year && (x.OfficeId == staticSettings.OfficeId && (x.Description.Contains(search) || x.ControlNo == search)) && x.IsClosed == status));
                if (search.ToDecimal() > 0)
                {
                    var amount = search.ToDecimal();
                    ucPR.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => x.Year == staticSettings.Year && (x.OfficeId == staticSettings.OfficeId && (x.TotalAmount >= amount && x.TotalAmount <= amount)) && x.IsClosed == status));
                }

                if (ucPR.PRGridControl.DataSource is BindingList<PurchaseRequests> list)
                {
                    Detail(list.FirstOrDefault());
                }
            }
            catch (Exception exception)
            {

            }
        }

        void _search(string search)
        {
            try
            {


                UnitOfWork unitOfWork = new UnitOfWork();
                ucPR.txtSearch.Text = search;
                StaticSettings staticSettings = new StaticSettings();
                var status = ucPR.chkIsClosed.Checked;

                ucPR.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => (x.OfficeId == staticSettings.OfficeId && (x.Description.Contains(search) || x.ControlNo == search)) && x.IsClosed == status));
                if (search.ToDecimal() > 0)
                {
                    var amount = search.ToDecimal();
                    ucPR.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => (x.OfficeId == staticSettings.OfficeId && (x.TotalAmount >= amount && x.TotalAmount <= amount)) && x.IsClosed == status));
                }

                if (ucPR.PRGridControl.DataSource is BindingList<PurchaseRequests> list)
                {
                    Detail(list.FirstOrDefault());
                }
            }
            catch (Exception exception)
            {

            }
        }
    }
}
