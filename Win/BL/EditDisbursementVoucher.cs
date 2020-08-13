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
    public class EditDisbursementVoucher : ITransactions<Obligations>
    {
        private Obligations item;
        private frmEditDisbursementVoucher frm;

        public EditDisbursementVoucher(frmEditDisbursementVoucher frm, Obligations item)
        {
            this.item = item;
            this.frm = frm;
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.ObligationsRepo.Find(m => m.Id == item.Id);
                item.DVParticular = frm.txtParticulars.Text;
                item.DVApprovedBy = frm.cboApprovedBy.Text;
                item.DVApprovedByPosition = frm.txtPosition.Text;
                item.DVNote = frm.txtNote.Text;
                item.DVAmount = frm.txtAmount.EditValue?.ToDecimal();
                unitOfWork.Save();
                frm.Close();}
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            if (item == null)
                return;
            frm.txtDate.DateTime = item.Date.ToDate();
            frm.txtControl.EditValue = item.ControlNo;
            frm.cboPayee.EditValue = item.Payees?.Name;
            frm.txtAddress.EditValue = item.PayeeAddress;
            frm.txtOffice.EditValue = item.PayeeOffice;
            frm.txtDescription.EditValue = item.Description;
            frm.txtParticulars.EditValue = item.DVParticular;
            frm.cboApprovedBy.EditValue  = item.DVApprovedBy;
            frm.txtPosition.EditValue = item.DVApprovedByPosition;
            frm.txtNote.EditValue = item.DVNote;
            frm.lblHeader.Text = item.ControlNo + " - " + item.Payees?.Name;
            frm.txtAmount.EditValue = item.TotalAmount;

        }

        public void Init()
        {
            try
            {
                frm.cboApprovedBy.Properties.DataSource = new BindingList<Signatories>(new UnitOfWork().Signatories.Get());
                frm.cboApprovedBy.EditValueChanged += CboApprovedBy_EditValueChanged;
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboApprovedBy_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit lookUpEdit)
            {
                if (lookUpEdit.GetSelectedDataRow() is Signatories signatories)
                {
                    frm.txtPosition.Text = string.IsNullOrWhiteSpace(item.DVApprovedByPosition) ? signatories.Position : item.DVApprovedByPosition;
                    frm.txtNote.Text = signatories.Note;
                }
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
