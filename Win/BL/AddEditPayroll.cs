using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.Repository;
using Win.Pyrll;

namespace Win.BL
{
    public class AddEditPayroll : ITransactions<Payrolls>
    {
        private Payrolls payrolls;
        private frmAddEditPayroll frm;

        public AddEditPayroll(frmAddEditPayroll frm, Payrolls payrolls)
        {
            this.payrolls = payrolls;
            this.frm = frm;
        }
        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var p = unitOfWork.PayrollsRepo.Find(m => m.Id == payrolls.Id);


                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {

        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (methodType == MethodType.Add)
                {
                    payrolls = new Payrolls()
                    {
                        OBId = payrolls.OBId,
                    };
                    unitOfWork.PayrollsRepo.Insert(payrolls);
                    unitOfWork.Save();
                }

                Detail();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}
