using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.Repository;
using Win.OB;

namespace Win.BL
{
    public class AddEditLoadPayees : ITransactions<Payees>
    {
        private frmAddEditPayee frm;
        public bool isClosed;
        private Payees payees;
        private int payeeId;

        public AddEditLoadPayees(frmAddEditPayee frm, Payees payees)
        {
            this.frm = frm;
            this.payees = payees;
            

        }
        public MethodType methodType { get; set; }
        public void Save()
        {
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                var unitOfWork = new UnitOfWork();
                unitOfWork.PayeesRepo.Update(new Payees()
                {
                    Id = payeeId,
                    Name = frm.txtName.Text,
                    Office = frm.txtOffice.Text,
                    Address = frm.txtAddress.Text,
                    Note = frm.txtNote.Text
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
                var item = payees; //?? new UnitOfWork().PayeesRepo.Find(m => m.Id == this.pay);
                if (item == null) return;
                frm.txtName.Text = item.Name;
                frm.txtAddress.Text = item.Address;
                frm.txtOffice.Text = item.Office;
                frm.txtNote.Text = item.Note;
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
                this.payeeId =
                    (unitOfWork.PayeesRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                unitOfWork.PayeesRepo.Insert(new Payees()
                {
                    Id = payeeId,
                });
                unitOfWork.Save();
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs formClosing)
        {
            try
            {
                if (methodType == MethodType.Edit)
                    return;
                if (isClosed)
                    return;
                var unitOfWork = new UnitOfWork();
                this.payeeId =
                    (unitOfWork.PayeesRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                unitOfWork.PayeesRepo.Delete(m => m.Id == payeeId);
                unitOfWork.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
