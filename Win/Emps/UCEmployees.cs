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
                new BindingList<Offices>(new UnitOfWork().OfficesRepo.Get());
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
                    var office = unitOfWork.OfficesRepo.Find(x => x.Id == item.OfficeId);

                    if (item.Id == 0)
                        unitOfWork.EmployeesRepo.Insert(new Employees()
                        {
                            FirstName = item.FirstName,
                            MiddleName = item.MiddleName,
                            LastName = item.LastName,
                            ExtName = item.ExtName,
                            OfficeId = office.Id,
                            OfficeName = office.OfficeName,
                            OffcAcr = office.OffcAcr,
                            Position = item.Position,
                            TIN = item.TIN,
                            PhilHealth = item.PhilHealth,
                            PagIbig = item.PagIbig,
                            SSS = item.SSS,
                            Status = item.Status,

                        });
                    else
                        unitOfWork.EmployeesRepo.Update(new Employees()
                        {
                            Id = item.Id,
                            FirstName = item.FirstName,
                            MiddleName = item.MiddleName,
                            LastName = item.LastName,
                            ExtName = item.ExtName,
                            OfficeId = office.Id,
                            OfficeName = office.OfficeName,
                            OffcAcr = office.OffcAcr,
                            Position = item.Position,
                            TIN = item.TIN,
                            PhilHealth = item.PhilHealth,
                            PagIbig = item.PagIbig,
                            Status = item.Status,
                            SSS = item.SSS

                        });
                    unitOfWork.Save();
                }
                Search(txtSearch.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            StaticSettings staticSettings = new StaticSettings();
            EmployeesGridControl.DataSource =
                new BindingList<Employees>(unitOfWork.EmployeesRepo.Get(x => x.OfficeId == staticSettings.OfficeId));
            cboStatusRepo.DataSource = new List<string>() { "Permanent", "Casual", "COS" }.Select(x => new { Status = x });
            cboOfficeSearch.Properties.DataSource = unitOfWork.OfficesRepo.Get();
            cboOfficeSearch.EditValue = staticSettings.OfficeId;
            Search(txtSearch.Text);
        }

        public void Detail(Employees item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            IQueryable<Employees> employees = unitOfWork.EmployeesRepo.Fetch();
            StaticSettings staticSettings = new StaticSettings();
            if (employees.Any(m => m.OffcAcr.Contains(search)))
                employees = employees.Where(m => m.OffcAcr.Contains(search));
            if (employees.Any(m => m.OfficeName.Contains(search)))
                employees = employees.Where(m => m.OfficeName.Contains(search));
            if (employees.Any(m => (m.FirstName + " " + m.LastName).Contains(search)))
                employees = employees.Where(m => (m.FirstName + " " + m.LastName).Contains(search));
            if (cboOfficeSearch.GetSelectedDataRow() is Offices item)
            {
                employees = employees.Where(x => x.OfficeId == item.Id);
            }
            else
            {
                employees = employees.Where(x => x.OfficeId == staticSettings.OfficeId);
            }
            EmployeesGridControl.DataSource = new BindingList<Employees>(employees.ToList());
        }

        private void cboOfficeSearch_EditValueChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            IQueryable<Employees> employees = unitOfWork.EmployeesRepo.Fetch();
            if (cboOfficeSearch.GetSelectedDataRow() is Offices item)
            {
                employees = employees.Where(x => x.OfficeId == item.Id);
            }

            EmployeesGridControl.DataSource = new BindingList<Employees>(employees.ToList());
        }
    }
}
