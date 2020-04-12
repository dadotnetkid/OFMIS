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
using Win.Rprts;

namespace Win.BL
{
    public class LoadPayroll : ILoad<Payrolls>
    {
        private UCPayrolls uCPayrolls;
        private Payrolls payrolls;
        internal SimpleButton btnEditNew;
        private int obId;


        public LoadPayroll(UCPayrolls uCPayrolls, int obId)
        {
            this.uCPayrolls = uCPayrolls;
            this.obId = obId;
            payrolls = new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId);
            btnEditNew = uCPayrolls.btnEditNew;
            btnEditNew.Click += BtnEditNew_Click;
            uCPayrolls.btnPreview.Click += BtnPreview_Click;
        }

        private void BtnPreview_Click(object sender, EventArgs e)
        {
            var res = new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId);
            frmReportViewer frm =
                new frmReportViewer(new rptOBRPayroll(res?.Obligations.ResponsibilityCenter + " - " + res?.ControlNo)
            {
                DataSource = new List<Payrolls>() { res }
            });
            frm.ShowDialog();
        }

        private void BtnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uCPayrolls.PayrollGridView.GetFocusedRow() is Payrolls item)
            {

            }
        }


        private void BtnEditNew_Click(object sender, EventArgs e)
        {
            frmAddEditPayroll frm;
            if (payrolls == null)
                frm = new frmAddEditPayroll(MethodType.Add, obId);
            else
                frm = new frmAddEditPayroll(MethodType.Edit, obId);
            frm.ShowDialog();
            Init();

        }

        public void Init()
        {
            uCPayrolls.PayrollGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PayrollDetailsRepo.Fetch(m => m.PayrollId == obId)
            };
            payrolls = new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId);
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
