using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.OB;

namespace Win.BL
{
    public class AddEditLoadObligations : ITransactions<Obligations>
    {
        private frmAddEditObligation frm;
        private string controlNo;
        private int obId;
        private Obligations obligations;
        public bool isClosed;


        public AddEditLoadObligations(frmAddEditObligation frm, Obligations obligations)
        {
            this.frm = frm;
            this.obligations = obligations;
            frm.txtDate.EditValue = DateTime.Now;
            frm.cboPayee.EditValueChanged += CboPayee_EditValueChanged;
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
                unitOfWork.ObligationsRepo.Update(new Obligations()
                {
                    Id = obId,
                    ControlNo = controlNo,
                    Date = DateTime.Now,
                    BudgetControlNo = frm.txtPBOControl.EditValue?.ToString(),
                    PayeeId = frm.cboPayee.EditValue?.ToInt(),
                    PayeeAddress = frm.txtAddress.EditValue?.ToString(),
                    PayeeOffice = frm.txtOffice.EditValue?.ToString(),
                    Description = frm.txtDescription.EditValue?.ToString(),
                    Chief = frm.txtChiefOfficer.EditValue?.ToString(),
                    ChiefPosition = frm.txtChiefPosition.EditValue?.ToString(),
                    PBO = frm.txtBudgetOfficer.Text,
                    PBOPos = frm.txtPBOPos.Text,
                });
                unitOfWork.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void Details()
        {
            if (methodType == MethodType.Add)
                return;
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
                frm.lblHeader.Text = controlNo + " - " + item?.Payees?.Name;
                LoadPayees();
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
                    Details();
                    return;
                }
                var unitOfWork = new UnitOfWork();
                this.obId =
                    (unitOfWork.ObligationsRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                this.controlNo = DateTime.Now.ToString("yyyy-MM-") + obId.ToString("0000");
                unitOfWork.ObligationsRepo.Insert(new Obligations()
                {
                    Id = obId,
                    ControlNo = controlNo
                });
                unitOfWork.Save();
                frm.lblHeader.Text = controlNo + " - New Payee";
                frm.txtControl.EditValue = controlNo;
                LoadPayees();
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
            frm.cboPayee.Properties.DataSource = new BindingList<Payees>(new UnitOfWork().PayeesRepo.Get());
        }
    }
}
