using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.Accnts;

namespace Win.BL
{
    public class AddEditRealignment : ITransactions<ReAlignments>
    {
        private frmAddEditReAlignment frm;
        private ReAlignments item;
        private bool isClosed;

        public AddEditRealignment(frmAddEditReAlignment frm, ReAlignments item)
        {
            this.frm = frm;
            this.item = item;
            frm.cboTargetAccountCode.EditValueChanged += CboTargetAccountCode_EditValueChanged;
        }

        private void CboTargetAccountCode_EditValueChanged(object sender, EventArgs e)
        {
            if (sender is LookUpEdit cbo)
            {
                if (cbo.GetSelectedDataRow() is Appropriations app)
                {
                    frm.lblHeader.Text = "Realignment from " + item.SourceAppropriations.AccountCode + " to " + app.AccountCode;
                }
            }
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                var model = new ReAlignments()
                {
                    SourceAppropriationId = item.SourceAppropriationId,
                    TargetAppropriationId = frm.cboTargetAccountCode.EditValue?.ToInt(),
                    Amount = frm.txtAmount.Text .ToDecimal(),
                    Remarks = frm.txtRemarks.Text,
                    Date = frm.dtRealignmentDate.DateTime,
                    Id = item.Id,
                    DateCreated = item.DateCreated ?? DateTime.Now
                };
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ReAlignmentsRepo.Update(model);
               unitOfWork.Save();
                this.isClosed = true;
                frm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void Details()
        {
            try
            {
                if (item == null)
                    return;
                item = new UnitOfWork().ReAlignmentsRepo.Find(m => m.Id == item.Id);
                frm.dtRealignmentDate.DateTime = item.Date ?? DateTime.Now;
                frm.dtRealignmentDate.EditValue = item.Date;
                frm.cboSourceAccountCode.EditValue = item.SourceAppropriations.AccountName;
                frm.cboTargetAccountCode.EditValue = item.TargetAppropriationId;
                frm.txtAmount.EditValue = item.Amount;
                frm.txtRemarks.Text = item.Remarks;
                frm.lblHeader.Text = "Realignment from " + item.SourceAppropriations.AccountCode + " to ";
                LoadTargetAccount();
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

                UnitOfWork unitOfWork = new UnitOfWork();
                item = new ReAlignments()
                {
                    SourceAppropriationId = item.SourceAppropriations.Id,
                    Date = DateTime.Now,
                    DateCreated = DateTime.Now,
                };

                unitOfWork.ReAlignmentsRepo.Insert(item);
                unitOfWork.Save();
                Details();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            try
            {
                if (methodType == MethodType.Edit)
                    return;
                if (isClosed)
                    return;

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ReAlignmentsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadTargetAccount()
        {
            frm.cboTargetAccountCode.Properties.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().AppropriationsRepoRepo.Fetch().Where(x => x.Id != item.SourceAppropriations.Id)
            };
        }

    }
}
