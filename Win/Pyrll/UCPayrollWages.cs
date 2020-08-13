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
using Helpers;
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

            frmAddEditPayrollWages frm = new frmAddEditPayrollWages(methodType, obligations);
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
                    this.btnDelete.Enabled = true;
                }
                else
                {
                    this.btnDelete.Enabled = false;
                    this.methodType = MethodType.Add;
                    this.btnEditNew.Text = "Add Payroll";
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
            var res = new UnitOfWork().PayrollWagesRepo.Find(x => x.Id == obligations.Id);

            res.PayrollWageDetails = res?.PayrollWageDetails?.Where(x => !string.IsNullOrEmpty(x.Employees?.TIN)).OrderBy(x => x.Employees.LastName).ToList();
            var rpt = new rptOBRPayrollWages()
            {
                DataSource = new List<PayrollWages>() { res }
            };
            if (res.Obligations.ORDetails.Any(x => x.Appropriations.AccountCode == "50211990"))
                rpt.lblDescription.BackColor = Color.White;
            frmReportViewer frm = new frmReportViewer(rpt);
            frm.ShowDialog();
        }

        private void btnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (PayrollGridView.GetFocusedRow() is PayrollWageDetails item)
            {
                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork(false, false);
                    TrashbinHelper trashbinHelper = new TrashbinHelper();
                    item = unitOfWork.PayrollWageDetailsRepo.Find(x => x.Id == item.Id, false);
                    trashbinHelper.Delete(item, "PayrollWageDetails", "APRs", User.UserId,
                        new StaticSettings().OfficeId);
                    unitOfWork.PayrollWagesRepo.Delete(x => x.Id == item.PayrollWageId);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollWagesRepo.Delete(x => x.Id == obligations.Id);
                unitOfWork.Save();
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
