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
                unitOfWork.Save();
                frm.Close();
            }
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
            frm.txtControl.Text = item.ControlNo;
            frm.cboPayee.Text = item.Payees?.Name;
            frm.txtAddress.Text = item.PayeeAddress;
            frm.txtOffice.Text = item.PayeeOffice;
            frm.txtDescription.Text = item.Description;
            frm.txtParticulars.Text = item.DVParticular;
            frm.cboApprovedBy.Text = item.DVApprovedBy;
            frm.txtPosition.Text = item.DVApprovedByPosition;
            frm.txtNote.Text = item.DVNote;
            frm.lblHeader.Text = item.ControlNo + " - " + item.Payees?.Name;
        }

        public void Init()
        {
            try
            {
                frm.cboApprovedBy.Properties.DataSource = new BindingList<Signatories>(new UnitOfWork().SignatoriesRepo.Get());
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
                    frm.txtNote.Text = string.IsNullOrWhiteSpace(item.DVNote) ? signatories.Note : item.DVNote;
                }
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
