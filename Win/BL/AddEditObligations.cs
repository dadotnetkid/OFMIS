using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Win.OB;

namespace Win.BL
{
    public class AddEditObligations : ITransactions<Obligations>
    {
        private frmAddEditObligation frm;
        private string controlNo;
        private int obId;
        private Obligations obligations;
        public bool isClosed;
        public bool isPrompt = true;


        public AddEditObligations(frmAddEditObligation frm, Obligations obligations)
        {
            this.frm = frm;
            this.obligations = obligations;
            frm.txtDate.EditValue = DateTime.Now;
            frm.cboPayee.EditValueChanged += CboPayee_EditValueChanged;
            frm.ORDetailsGridView.RowUpdated += ORDetailsGridView_RowUpdated;

            frm.btnDelORDetailRepo.ButtonClick += BtnDelORDetailRepo_ButtonClick;

            frm.ORDetailGridControl.DataSource = new BindingList<ORDetails>(new List<ORDetails>());
            LoadAppropriation();
            LoadPayees();

        }



        private void BtnDelORDetailRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (frm.ORDetailsGridView.GetFocusedRow() is ORDetails item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ORDetailsRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    LoadOrDetails();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ORDetailsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {


                if (e.Row is ORDetails item)
                {
                    var unitOfWork = new UnitOfWork();
                    var appropriation = unitOfWork.AppropriationsRepoRepo.Find(m => m.Id == item.AppropriationId);
                    if ((item.Amount + (appropriation.ObligationsOffice ?? 0)) > appropriation.Allotment)
                    {
                        //    var oldItem = new UnitOfWork().ORDetailsRepo.Find(m => m.Id == item.Id);
                        MessageBox.Show(@"The amount indicated in the ObR is greater than the allotment balance.\nPlease prepare Request of Release of Allotment addressed to the PBO.",
                            @"Insufficient Allotment Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //  item.Amount = oldItem?.Amount;
                        //return;
                    }

                    item.ObligationId = obId;

                    if (item.Id == 0)
                        unitOfWork.ORDetailsRepo.Insert(item);
                    else
                    {
                        var res = unitOfWork.ORDetailsRepo.Find(m => m.Id == item.Id);
                        res.Id = item.Id;
                        res.Amount = item.Amount;
                        res.ObligationId = item.ObligationId;
                        res.AppropriationId = item.AppropriationId;
                        res.Particulars = item.Particulars;
                        res.AdjustedAmount = item.AdjustedAmount;

                    }
                    unitOfWork.Save();
                    LoadOrDetails();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CboPayee_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Payees item)
                {
                    frm.txtAddress.Text = item.Address;
                    frm.txtOffice.Text = item.Office;

                }
            }
        }

        public MethodType methodType { get; set; }

        public void Save()
        {

            if (this.isPrompt == true)
            {
                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            try
            {
                var unitOfWork = new UnitOfWork();
                //    var oldData = unitOfWork.ObligationsRepo.Find(m => m.Id == this.obligations.Id);
                obligations = unitOfWork.ObligationsRepo.Find(m => m.Id == this.obligations.Id);
                if (obligations == null)
                {
                    ReInit();
                    obligations = unitOfWork.ObligationsRepo.Find(m => m.Id == this.obligations.Id);
                }
                //       obligations.Id = this.obligations.Id;
                //obligations.ControlNo = this.obligations.ControlNo;
                obligations.Date = frm.txtDate.EditValue?.ToDate() ?? DateTime.Now;
                obligations.BudgetControlNo = frm.txtPBOControl.EditValue?.ToString();
                obligations.PayeeId = frm.cboPayee.EditValue?.ToInt();
                obligations.PayeeAddress = frm.txtAddress.EditValue?.ToString();
                obligations.PayeeOffice = frm.txtOffice.EditValue?.ToString();
                obligations.Description = frm.txtDescription.EditValue?.ToString();
                obligations.Chief = frm.txtChiefOfficer.EditValue?.ToString();
                obligations.ChiefPosition = new StaticSettings().HeadPos;
                obligations.PBO = frm.txtBudgetOfficer.Text;
                obligations.PBOPos = (frm.txtBudgetOfficer.GetSelectedDataRow() as Signatories)?.Position;
                obligations.OBRApprovedBy = frm.cboApprovedBy.Text;
                obligations.OBRApprovedByPos = (frm.cboApprovedBy.GetSelectedDataRow() as Signatories)?.Position;
                obligations.Accountant = (frm.cboAccountant.GetSelectedDataRow() as Signatories)?.Person;
                obligations.AccountantPos = (frm.cboAccountant.GetSelectedDataRow() as Signatories)?.Position;
                obligations.Treasurer = (frm.cboTreasurer.GetSelectedDataRow() as Signatories)?.Person;
                obligations.TreasurerPos = (frm.cboTreasurer.GetSelectedDataRow() as Signatories)?.Position;

                obligations.Amount = unitOfWork.ORDetailsRepo.Fetch(m => m.ObligationId == obId).Sum(x => x.Amount) ?? 0;
                obligations.Status = frm.chkClosed.CheckState == CheckState.Checked ? "Closed" : "Active";
                obligations.Earmarked = frm.chkEarmarked.Checked;
                obligations.Closed = frm.chkClosed.Checked;
                obligations.Year = this.obligations.Year ?? new StaticSettings().Year;
                obligations.ResponsibilityCenter = new StaticSettings().ResponsibilityCenter;
                obligations.ResponsibilityCenterCode = new StaticSettings().ResponsibilityCenterCode;
                obligations.PRNo = this.obligations.PRNo;
                obligations.DateClosed = this.obligations.DateClosed;
                obligations.DVApprovedBy = this.obligations.DVApprovedBy;
                obligations.DVApprovedByPosition = this.obligations.DVApprovedByPosition;
                obligations.DVNote = this.obligations.DVNote;
                obligations.DVParticular = this.obligations.DVParticular;

                obligations.TotalAdjustedAmount = this.obligations.ORDetails?.Sum(x => x.AdjustedAmount) ?? 0;

                if (this.obligations.DateClosed == null && frm.chkClosed.Checked)
                    this.obligations.DateClosed = DateTime.Now;
                if (this.obligations.DateClosed != null && frm.chkClosed.Checked)
                    this.obligations.DateClosed = this.obligations.DateClosed;
                if (methodType == MethodType.Add)
                {
                    obligations.DateCreated = DateTime.Now;
                    obligations.CreatedBy = User.UserId;
                }
                else
                {
                    obligations.DateModified = DateTime.Now;
                    obligations.ModifiedBy = User.UserId;
                }
                if (frm.chkClosed.Checked)
                {
                    if (!unitOfWork.DocumentActionsRepo.Fetch(x => x.ActionTaken == "Transaction completed" && x.RefId == obligations.Id && x.TableName == "Obligations").Any())
                        unitOfWork.DocumentActionsRepo.Insert(new DocumentActions()
                        {
                            ControlNo = obligations.ControlNo,
                            ObR_PR_No = obligations.BudgetControlNo,
                            ActionDate = DateTime.Now,
                            DateCreated = DateTime.Now,
                            CreatedBy = User.UserId,
                            ActionTaken = "Transaction completed",
                            RefId = obligations.Id,
                            TableName = "Obligations",
                        });
                }
                unitOfWork.Save();
                this.isClosed = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void Detail()
        {
            //if (methodType == MethodType.Add)
            //    return;
            try
            {

                var staticSetting = new StaticSettings();
                UnitOfWork unitOfWork = new UnitOfWork();
                var chiefOfOffice = unitOfWork.Signatories.Find(m => m.Year == staticSetting.Year);
                var item = unitOfWork.ObligationsRepo.Find(m => m.Id == obligations.Id);
                if (item == null) return;
                frm.txtDate.EditValue = item.Date;
                frm.txtControl.EditValue = item.ControlNo;
                frm.txtPBOControl.EditValue = item.BudgetControlNo;
                frm.cboPayee.EditValue = item.PayeeId;
                frm.txtOffice.EditValue = item.PayeeOffice;
                frm.txtAddress.EditValue = item.PayeeAddress;
                frm.txtDescription.EditValue = item.Description;
                frm.txtBudgetOfficer.EditValue = item.PBO;
                frm.cboApprovedBy.EditValue = item.OBRApprovedBy;
                frm.txtChiefOfficer.EditValue = item.Chief;

                this.obId = obligations?.Id ?? obId;
                this.controlNo = obligations?.ControlNo ?? controlNo;
                frm.lblHeader.Text = methodType == MethodType.Add ? controlNo + " - New Payee" : controlNo + " - " + item?.Payees?.Name;
                frm.txtControl.EditValue = controlNo;
                frm.chkClosed.CheckState = item.Status == "Closed" ? CheckState.Checked : CheckState.Unchecked;
                frm.chkEarmarked.Checked = item.Earmarked ?? false;
                frm.ORDetailGridControl.DataSource = new BindingList<ORDetails>(item.ORDetails?.ToList());
                frm.txtBudgetOfficer.EditValue = string.IsNullOrWhiteSpace(item.PBO) ? staticSetting.chiefOfOffice.FirstOrDefault(m => m.Office == "Provincial Budget Office")?.Person : item.PBO;
                //frm.txtChiefOfficer.Text = string.IsNullOrWhiteSpace(item.Chief) ? staticSetting.Head : item.Chief;

                frm.cboAccountant.EditValue = unitOfWork.Signatories
                    .Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")).FirstOrDefault()
                    ?.Person;
                frm.cboTreasurer.EditValue = unitOfWork.Signatories
                    .Get(m => m.Office.Contains("Treasurer") || m.Office.Contains("Treasury")).FirstOrDefault()?.Person;
                if (staticSetting.Offices.IsDivision == true)
                {

                    frm.cboApprovedBy.EditValue = item.OBRApprovedBy ?? unitOfWork.Signatories
                        .Get(m => m.Office.Contains("Governor Office") || m.Office.Contains("Governor's Office")).FirstOrDefault()?.Person;
                    frm.txtChiefOfficer.Text = string.IsNullOrWhiteSpace(item.Chief) ? staticSetting.Head : item.Chief;
                }
                else
                {
                    frm.cboApprovedBy.EditValue = item.OBRApprovedBy ?? unitOfWork.Signatories
                                                      .Get(m => m.Office.Contains(staticSetting.OfficeName)).FirstOrDefault()?.Person;
                    frm.txtChiefOfficer.Tag = null;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                var staticSttings = new StaticSettings();
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                var unitOfWork = new UnitOfWork();
                var ob = unitOfWork.ObligationsRepo.Fetch(m => m.OfficeId == staticSttings.OfficeId).OrderByDescending(x => x.Id).FirstOrDefault();
                //  this.obId = (ob?.Id ?? 0) + 1;
                // this.controlNo = DateTime.Now.ToString("yyyy-MM-") + obId.ToString("0000");
                //var payee = unitOfWork.PayeesRepo.Find(m => m.Name == "Earmarked PR");
                this.obligations = new Obligations()
                {
                    ControlNo = IdHelper.OfficeControlNo(ob?.ControlNo, staticSttings.OfficeId, "ObR", "Obligations"),
                    Year = new StaticSettings().Year,
                    Date = DateTime.Now,
                    Earmarked = obligations?.Earmarked,
                    PayeeId = obligations?.PayeeId,
                    PayeeOffice = obligations?.PayeeOffice,
                    PayeeAddress = obligations?.PayeeAddress,
                    Description = obligations?.Description,
                    ORDetails = obligations?.ORDetails ?? new List<ORDetails>(),
                    PRNo = obligations?.PRNo,
                    OfficeId = new StaticSettings().OfficeId,
                    CreatedBy = User.UserId,
                    DateCreated = DateTime.Now
                };
                unitOfWork.ObligationsRepo.Insert(obligations);
                unitOfWork.Save();
                this.obId = obligations.Id;
                Detail();
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ///this.controlNo = DateTime.Now.ToString("yyyy-MM-") + "0001";

        }

        void ReInit()
        {
            try
            {
                var unitOfWork = new UnitOfWork();
                var staticSttings = new StaticSettings();
                var ob = unitOfWork.ObligationsRepo.Fetch(m => m.OfficeId == staticSttings.OfficeId).OrderByDescending(x => x.Id).FirstOrDefault();
                //  this.obId = (ob?.Id ?? 0) + 1;
                // this.controlNo = DateTime.Now.ToString("yyyy-MM-") + obId.ToString("0000");
                //var payee = unitOfWork.PayeesRepo.Find(m => m.Name == "Earmarked PR");
                this.obligations = new Obligations()
                {
                    ControlNo = IdHelper.OfficeControlNo(ob?.ControlNo, staticSttings.OfficeId, "ObR", "Obligations"),
                    Year = new StaticSettings().Year,
                    Date = DateTime.Now,
                    Earmarked = obligations?.Earmarked,
                    PayeeId = obligations?.PayeeId,
                    PayeeOffice = obligations?.PayeeOffice,
                    PayeeAddress = obligations?.PayeeAddress,
                    Description = obligations?.Description,
                    ORDetails = obligations?.ORDetails ?? new List<ORDetails>(),
                    PRNo = obligations?.PRNo,
                    OfficeId = new StaticSettings().OfficeId,
                };
                unitOfWork.ObligationsRepo.Insert(obligations);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void Close(FormClosingEventArgs formClosingEventArgs)
        {
            try
            {
                if (methodType == MethodType.Edit)
                    return;
                if (this.isClosed)
                    return;

                if (MessageBox.Show("Closing this form will delete this OR.\nDo you want to continue this?", "Closing",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    formClosingEventArgs.Cancel = true;
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ObligationsRepo.Delete(m => m.Id == obId);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadPayees()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            StaticSettings staticSettings = new StaticSettings();
            frm.cboPayee.Properties.DataSource = new EntityServerModeSource()
            {
                QueryableSource = unitOfWork.PayeesRepo.Fetch()
            };
            frm.cboAccountant.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories
                .Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")));
            frm.cboTreasurer.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories
                .Get(m => m.Office.Contains("Treasurer") || m.Office.Contains("Treasury")));

            frm.txtBudgetOfficer.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories
                .Get(m => m.Office.Contains("Provincial Budget Office")));
            if (staticSettings.Offices.IsDivision == true)
                frm.cboApprovedBy.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories
                    .Get(m => m.Office.Contains("Governor Office") || m.Office.Contains("Governor's Office")));
            else
                frm.cboApprovedBy.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories
                    .Get(m => m.Office.Contains(staticSettings.OfficeName)));
        }

        public void LoadAppropriation()
        {
            var year = new StaticSettings().Year;
            var staticSettings = new StaticSettings();
            UnitOfWork unitOfWork = new UnitOfWork();
            frm.cboAppropriationLookUpRepo.DataSource = new EntityServerModeSource()
            {
                QueryableSource = unitOfWork.AppropriationsRepoRepo.Fetch(m => m.Year == year && m.OfficeId == staticSettings.OfficeId)
            };


            frm.cboAccountRepo.DataSource = new BindingList<Appropriations>(
                unitOfWork.AppropriationsRepoRepo.Get(m => m.Year == year && m.OfficeId == staticSettings.OfficeId));
            frm.cboAccountRepo.PopulateViewColumns();
        }

        void LoadOrDetails()
        {
            frm.ORDetailGridControl.DataSource =
                new BindingList<ORDetails>(new UnitOfWork().ORDetailsRepo.Fetch(m => m.ObligationId == obId).ToList());
        }

        public void SaveWithoutPromp()
        {
            isPrompt = false;
            Save();
        }
    }
}
