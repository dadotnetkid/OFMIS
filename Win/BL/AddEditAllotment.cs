using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Models;
using Models.Repository;
using Win.Accnts;

namespace Win.BL
{
    public class AddEditAllotment : ITransactions<Allotments>
    {
        private Allotments allotments;
        private frmAddEditAllotment frm;
        private bool isClosed;

        public AddEditAllotment(frmAddEditAllotment frm, Allotments allotments)
        {
            this.frm = frm;
            this.allotments = allotments;
        }
        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.AllotmentsRepo.Update(new Allotments()
                {
                    Id = allotments.Id,
                    AppropriationId = allotments.AppropriationId,
                    AllotmentAmount = frm.txtAllotmentAmount.EditValue?.ToDecimal(),
                    Remarks = frm.txtRemarks.Text,
                    DateCreated = DateTime.Now,
                    AllotmentDate = frm.dtAllotmentDate.EditValue?.ToDate(),
                });
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
                frm.lblHeader.Text = allotments.Appropriations?.AccountName;
                if (methodType == MethodType.Add)
                    return;
                if (allotments == null)
                    return;
                frm.dtAllotmentDate.EditValue = allotments.AllotmentDate;
                frm.txtAllotmentAmount.EditValue = allotments.AllotmentAmount;
                frm.txtRemarks.Text = allotments.Remarks;

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
                frm.lblHeader.Text = allotments.Appropriations?.AccountName;
                allotments = new Allotments()
                {
                    AppropriationId = allotments.Appropriations?.Id
                };
                unitOfWork.AllotmentsRepo.Insert(allotments);
                unitOfWork.Save();

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
                unitOfWork.AllotmentsRepo.Delete(m => m.Id == allotments.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
