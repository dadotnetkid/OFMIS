using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Win.BL;
using Helpers;
using Models.Repository;
using Win.Pyee;

namespace Win.OB
{
    public partial class frmAddEditPayee : DevExpress.XtraEditors.XtraForm
    {
        private AddEditPayees addEditLoadPayees;
        private MethodType methodType;
        private Payees payees;

        public frmAddEditPayee(MethodType methodType, Payees payees)
        {
            InitializeComponent();
            this.addEditLoadPayees = new AddEditPayees(this, payees) { methodType = methodType };
            addEditLoadPayees.Init();
            this.methodType = methodType;
            this.payees = payees;
        }

        private void frmAddEditPayee_Load(object sender, EventArgs e)
        {
            addEditLoadPayees.Detail();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addEditLoadPayees.isClosed = false;
            if (this.txtName.GetSelectedDataRow() is Payees item && methodType == MethodType.Add)
            {
                MessageBox.Show($"{item.Name} is already existed", "Existing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (((XtraForm)this).ValidateForm())
            {
                addEditLoadPayees.Save();
                addEditLoadPayees.isClosed = true;
                this.Close();
            }

        }

        private void frmAddEditPayee_FormClosing(object sender, FormClosingEventArgs e)
        {
            addEditLoadPayees.Close(e);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers(payees);
            frm.ShowDialog();
            UnitOfWork unitOfWork = new UnitOfWork();
            var res = unitOfWork.PayeesRepo.Find(x => x.Id == payees.Id);
            cboMembers.EditValue = string.Join(",", res.Employees.Select(x => x.EmployeeName));}
    }
}