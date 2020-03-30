using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
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


        public AddEditObligations(frmAddEditObligation frm, Obligations obligations)
        {
            this.frm = frm;
            this.obligations = obligations;
            frm.txtDate.EditValue = DateTime.Now;
            frm.cboPayee.EditValueChanged += CboPayee_EditValueChanged;
            frm.ORDetailsGridView.RowUpdated += ORDetailsGridView_RowUpdated;
            frm.btnDelORDetailRepo.ButtonClick += BtnDelORDetailRepo_ButtonClick;

            frm.ORDetailGridControl.DataSource = new BindingSource() { DataSource = new List<ORDetails>() };
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
                    item.ObligationId = obId;
                    var unitOfWork = new UnitOfWork();
                    if (item.Id == 0)
                        unitOfWork.ORDetailsRepo.Insert(item);
                    else
                        unitOfWork.ORDetailsRepo.Update(item);
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

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                var unitOfWork = new UnitOfWork();
                var ob = new Obligations()
                {
                    Id = obId,
                    ControlNo = controlNo,
                    Date = obligations.Date ?? DateTime.Now,
                    BudgetControlNo = frm.txtPBOControl.EditValue?.ToString(),
                    PayeeId = frm.cboPayee.EditValue?.ToInt(),
                    PayeeAddress = frm.txtAddress.EditValue?.ToString(),
                    PayeeOffice = frm.txtOffice.EditValue?.ToString(),
                    Description = frm.txtDescription.EditValue?.ToString(),
                    Chief = frm.txtChiefOfficer.EditValue?.ToString(),
                    ChiefPosition = frm.txtChiefPosition.EditValue?.ToString(),
                    PBO = frm.txtBudgetOfficer.Text,
                    PBOPos = frm.txtPBOPos.Text,
                    Amount = unitOfWork.ORDetailsRepo.Fetch(m => m.ObligationId == obId).Sum(x => x.Amount) ?? 0,
                    Status = frm.chkClosed.CheckState == CheckState.Checked ? "Closed" : "Active",
                    Earmarked = frm.chkEarmarked.Checked,
                    Closed = frm.chkClosed.Checked,
                    Year = obligations.Year ?? new StaticSettings().Year


                };
                if (obligations.DateClosed == null && frm.chkClosed.Checked)
                    ob.DateClosed = DateTime.Now;
                if (obligations.DateClosed != null && frm.chkClosed.Checked)
                    ob.DateClosed = obligations.DateClosed;

                unitOfWork.ObligationsRepo.Update(ob);
                unitOfWork.Save();

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
                var item = obligations ?? new UnitOfWork().ObligationsRepo.Find(m => m.Id == this.obId);
                if (item == null) return;
                frm.txtDate.EditValue = item.Date;
                frm.txtControl.EditValue = item.ControlNo;
                frm.txtPBOControl.EditValue = item.BudgetControlNo;
                frm.cboPayee.EditValue = item.PayeeId;
                frm.txtOffice.EditValue = item.PayeeOffice;
                frm.txtAddress.EditValue = item.PayeeAddress;
                frm.txtDescription.EditValue = item.Description;
                frm.txtBudgetOfficer.EditValue = item.PBO;
                frm.txtPBOPos.EditValue = item.PBOPos;
                frm.txtChiefOfficer.EditValue = item.Chief;
                frm.txtChiefPosition.EditValue = item.ChiefPosition;
                this.obId = obligations?.Id ?? obId;
                this.controlNo = obligations?.ControlNo ?? controlNo;
                frm.lblHeader.Text = methodType == MethodType.Add ? controlNo + " - New Payee" : controlNo + " - " + item?.Payees?.Name;
                frm.txtControl.EditValue = controlNo;
                frm.chkClosed.CheckState = item.Status == "Closed" ? CheckState.Checked : CheckState.Unchecked;
                frm.chkEarmarked.Checked = item.Earmarked ?? false;
                frm.ORDetailGridControl.DataSource = new BindingList<ORDetails>(item.ORDetails.ToList());
                frm.txtBudgetOfficer.Text = string.IsNullOrWhiteSpace(item.PBO) ? new StaticSettings().PBO : item.PBO;
                frm.txtPBOPos.Text = string.IsNullOrWhiteSpace(item.PBOPos) ? new StaticSettings().PBOPos : item.PBOPos;
                frm.txtChiefOfficer.Text = string.IsNullOrWhiteSpace(item.Chief) ? new StaticSettings().ChiefOfOffice : item.Chief;
                frm.txtChiefPosition.Text = string.IsNullOrWhiteSpace(item.ChiefPosition) ? new StaticSettings().ChiefOfOfficePos : item.ChiefPosition;

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
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                var unitOfWork = new UnitOfWork();
                this.obId =
                    (unitOfWork.ObligationsRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                this.controlNo = DateTime.Now.ToString("yyyy-MM-") + obId.ToString("0000");
                unitOfWork.ObligationsRepo.Insert(new Obligations()
                {
                    Id = obId,
                    ControlNo = controlNo,
                    Year = new StaticSettings().Year
                });
                unitOfWork.Save();

                Detail();
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.controlNo = DateTime.Now.ToString("yyyy-MM-") + "0001";

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
            frm.cboPayee.Properties.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PayeesRepo.Fetch()
            };
        }

        public void LoadAppropriation()
        {
            frm.cboAppropriationLookUpRepo.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().AppropriationsRepoRepo.Fetch()
            };
        }

        void LoadOrDetails()
        {
            frm.ORDetailGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().ORDetailsRepo.Fetch(m => m.ObligationId == obId)
            };
        }
    }
}
