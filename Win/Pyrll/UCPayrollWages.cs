using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;

namespace Win.Pyrll
{
    public partial class UCPayrollWages : DevExpress.XtraEditors.XtraUserControl, ILoad<PayrollWages>
    {
        private Obligations obligations;
        private MethodType methodType;

        public UCPayrollWages(Obligations obligations)
        {
            InitializeComponent();
            this.obligations = obligations;
            Init();
        }

        private void btnEditNew_Click(object sender, EventArgs e)
        {

            frmAddEditPayrollWages frm = new frmAddEditPayrollWages(methodType, obligations.PayrollWages);
            frm.ShowDialog();
            Init();

        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                this.PayrollGridControl.DataSource =
                    new BindingList<PayrollWageDetails>(unitOfWork.PayrollWageDetailsRepo.Get(m => m.PayrollWageId == obligations.Id));
                if (unitOfWork.PayrollWagesRepo.Fetch(m => m.Id == obligations.Id).Any())
                {
                    this.methodType = MethodType.Edit;
                    this.btnEditNew.Text = "Edit Payroll";
                }
                else
                {
                    this.methodType = MethodType.Add;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(PayrollWages item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var res = new UnitOfWork().PayrollWagesRepo.Get(x => x.Id == obligations.Id);


            frmReportViewer frm = new frmReportViewer(new rptOBRPayrollWages()
            {
                DataSource = res
            });
            frm.ShowDialog();
        }
    }
}
