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
using Models.Repository;

namespace Win.Pyee
{
    public partial class frmMembers : DevExpress.XtraEditors.XtraForm
    {
        private Payees payees;
        private List<int> employeeIds;
        public frmMembers(Payees payees)
        {
            InitializeComponent();
            this.payees = payees;
            employeeIds = payees.Employees.Select(x => x.Id).ToList();
            Init();
        }
        private void Init()
        {
            this.Search(txtSearch.Text);
        }

        private void Search(string search = "")
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var employees = unitOfWork.EmployeesRepo.Get(x => (x.FirstName + " " + ". " + x.LastName).Contains(search));

            foreach (var i in employees)
            {
                i.isSelected = payees.Employees.Any(x => x.Id == i.Id);
            }

            foreach (var i in employees)
            {
                i.isSelected = employeeIds.Any(x => x == i.Id);
            }
            this.EmployeesGridControl.DataSource = employees;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Search(this.txtSearch.Text);
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.PayeesRepo.Find(x => x.Id == payees.Id, "Employees");
                res.Employees.Clear();
                foreach (var i in employeeIds)
                {
                    res.Employees.Add(unitOfWork.EmployeesRepo.Find(x => x.Id == i));
                }

                unitOfWork.Save();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeesGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (EmployeesGridView.GetRow(e.RowHandle) is Employees item)
            {

                if (item.isSelected)
                {
                    employeeIds.Add(item.Id);
                }
                else
                {
                    employeeIds.Remove(item.Id);
                }
            }
        }
    }
}