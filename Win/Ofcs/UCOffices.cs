using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Ofcs
{
    public partial class UCOffices : DevExpress.XtraEditors.XtraUserControl, ILoad<Offices>
    {
        public UCOffices()
        {
            InitializeComponent();
            OfficesGridView.RowUpdated += OfficesGridView_RowUpdated;
            OfficesGridView.CustomRowCellEdit += OfficesGridView_CustomRowCellEdit;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnDeleteUserRepo.ButtonClick += BtnDeleteUserRepo_ButtonClick;
            Init();
        }

        private void BtnDeleteUserRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (OfficesGridView.GetFocusedRow() is Offices item)
            {
                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.OfficesRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OfficesGridView_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.Name == "colIsDivision")
            {
                //if (OfficesGridView.row.Columns["colUnderOf"].ColumnEdit is RepositoryItemLookUpEdit cbo)
                //{
                //    cbo.ReadOnly = !e.CellValue.ToBool();
                //}
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }

        private void OfficesGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is Offices item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    if (item.Id == 0)
                        unitOfWork.OfficesRepo.Insert(item);
                    else
                        unitOfWork.OfficesRepo.Update(new Offices()
                        {
                            Id = item.Id,
                            Chief = item.Chief,
                            ChiefPosition = item.ChiefPosition,
                            CreatedBy = User.GetFullName(),
                            DateCreated = DateTime.Now,
                            IsDivision = item.IsDivision,
                            OffcAcr = item.OffcAcr,
                            OfficeName = item.OfficeName,
                            ResponsibilityCenter = item.ResponsibilityCenter,
                            ResponsibilityCenterCode = item.ResponsibilityCenterCode,
                            UnderOf = item.UnderOf == 0 ? null : item.UnderOf,
                            Address = item.Address,
                            TelNo = item.TelNo,
                            InsideAddress = item.InsideAddress
                        });
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            var res = new List<Offices>() { new Offices() { OffcAcr = "" } };
            res.AddRange(new UnitOfWork().OfficesRepo.Get());
            OfficesGridControl.DataSource = new BindingList<Offices>(new UnitOfWork().OfficesRepo.Get());
            cboOffices.DataSource = new BindingList<Offices>(res);
            cboChief.DataSource = new BindingList<Employees>(new UnitOfWork().EmployeesRepo.Get());
        }

        public void Detail(Offices item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            IQueryable<Offices> offices = unitOfWork.OfficesRepo.Fetch();
            if (offices.Any(m => m.OffcAcr.Contains(search)))
                offices = offices.Where(m => m.OffcAcr.Contains(search));
            if (offices.Any(m => m.OfficeName.Contains(search)))
                offices = offices.Where(m => m.OfficeName.Contains(search));
            if (offices.Any(m => m.ResponsibilityCenter.Contains(search)))
                offices = offices.Where(m => m.ResponsibilityCenter.Contains(search));
            if (offices.Any(m => m.Chief.Contains(search)))
                offices = offices.Where(m => m.Chief.Contains(search));
            if (offices.Any(m => m.ChiefPosition.Contains(search)))
                offices = offices.Where(m => m.ChiefPosition.Contains(search));
            if (offices.Any(m => m.UnderOfOffice.OfficeName.Contains(search)))
                offices = offices.Where(m => m.UnderOfOffice.OfficeName.Contains(search));

            OfficesGridControl.DataSource = new BindingList<Offices>(offices.ToList());

        }

    

        private void OfficesGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colChief")
                if (OfficesGridView.GetRow(e.RowHandle) is Offices item)
                {
                    var employees = new UnitOfWork().EmployeesRepo.Get()
                        .FirstOrDefault(x => x.EmployeeName == item.Chief);
                    if (employees == null)
                        return;
                    item.ChiefPosition = item.ChiefPosition;
                }
        }

        private void btnEditUserRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnEditOffice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (OfficesGridView.GetFocusedRow() is Offices item)
            {
                frmAddEditOffice frm = new frmAddEditOffice(item, MethodType.Edit);
                frm.ShowDialog();
                Init();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditOffice frm = new frmAddEditOffice(new Offices(), MethodType.Edit);
            frm.ShowDialog();
            Init();
        }
    }
}
