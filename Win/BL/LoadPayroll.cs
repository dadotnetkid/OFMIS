using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.Pyrll;

namespace Win.BL
{
    public class LoadPayroll : ILoad<Payrolls>
    {
        private UCPayrolls uCPayrolls;
        private Payrolls payrolls;
        internal SimpleButton btnEditNew;


        public LoadPayroll(Action<LoadPayroll> action)
        {
            
        }

        public LoadPayroll(UCPayrolls uCPayrolls, Payrolls payrolls)
        {
            this.uCPayrolls = uCPayrolls;
            this.payrolls = payrolls;
            btnEditNew = uCPayrolls.btnEditNew;
            btnEditNew.Click += BtnEditNew_Click;
        }

        private void BtnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uCPayrolls.PayrollGridView.GetFocusedRow() is Payrolls item)
            {

            }
        }

      
        private void BtnEditNew_Click(object sender, EventArgs e)
        {
                AddEditPayroll addEditPayroll = new AddEditPayroll(null);
        }

        public void Init()
        {
            uCPayrolls.PayrollGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PayrollDetailsRepo.Fetch(m => m.PayrollId == payrolls.Id)
            };
            if (payrolls == null)
                btnEditNew.Text = "New Payroll";
            else
                btnEditNew.Text = "Edit Payroll";
        }

        public void Detail(Payrolls item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}
