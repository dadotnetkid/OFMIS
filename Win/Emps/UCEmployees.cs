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

namespace Win.Emps
{
    public partial class UCEmployees : DevExpress.XtraEditors.XtraUserControl, ILoad<Employees>
    {
        private StaticSettings staticSettings = new StaticSettings();
        public UCEmployees()
        {
            InitializeComponent();
            EmployeesGridView.RowUpdated += EmployeesGridView_RowUpdated;
            cboOffices.DataSource =
                new BindingList<Offices>(new UnitOfWork().OfficesRepo.Get(m => m.Id == staticSettings.OfficeId));
            btnDeleteRepo.ButtonClick += BtnDeleteRepo_ButtonClick;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            Init();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void BtnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to Delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (EmployeesGridView.GetFocusedRow() is Employees item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.EmployeesRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeesGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (e.Row is Employees item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var office = unitOfWork.OfficesRepo.Find(m => m.Id == staticSettings.OfficeId);

                    if (item.Id == 0)
                        unitOfWork.EmployeesRepo.Insert(new Employees()
                        {
                            FirstName = item.FirstName,
                            MiddleName = item.MiddleName,
                            LastName = item.LastName,
                            OfficeId = staticSettings.OfficeId,
                            OfficeName = office.OfficeName,
                            OffcAcr = office.OffcAcr,
                            Position = item.Position
                        });
                    else
                        unitOfWork.EmployeesRepo.Update(new Employees()
                        {
                            Id = item.Id,
                            FirstName = item.FirstName,
                            MiddleName = item.MiddleName,
                            LastName = item.LastName,
                            OfficeId = staticSettings.OfficeId,
                            OfficeName = office.OfficeName,
                            OffcAcr = office.OffcAcr,
                            Position = item.Position
                        });
                    unitOfWork.Save();
                }


                Init();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            EmployeesGridControl.DataSource =
                new BindingList<Employees>(unitOfWork.EmployeesRepo.Get(m => m.OfficeId == staticSettings.OfficeId));
        }

        public void Detail(Employees item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            IQueryable<Employees> employees = unitOfWork.EmployeesRepo.Fetch();
            if (employees.Any(m => m.OffcAcr.Contains(search)))
                employees = employees.Where(m => m.OffcAcr.Contains(search));
            if (employees.Any(m => m.OfficeName.Contains(search)))
                employees = employees.Where(m => m.OfficeName.Contains(search));
            if (employees.Any(m => (m.FirstName + " " + m.LastName).Contains(search)))
                employees = employees.Where(m => (m.FirstName + " " + m.LastName).Contains(search));

            EmployeesGridControl.DataSource = new BindingList<Employees>(employees.ToList());
        }
    }
}
