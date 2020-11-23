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
using Models;
using Models.Repository;
using Win.BL;

namespace Win.BGMembers
{
    public partial class UCBACMembers : DevExpress.XtraEditors.XtraUserControl, ILoad<BACMembers>
    {
        public UCBACMembers()
        {
            InitializeComponent();
            Init();
        }

        private void BACGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (BACGridView.GetRow(e.RowHandle) is BACMembers item)
            {
                if (e.Column.Name == "colName")
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var name = e.Value.ToString();
                    var employee = unitOfWork.EmployeesRepo.Get().FirstOrDefault(x => x.EmployeeName == name);
                    item.LastName = employee.LastName;
                    item.MiddleName = employee.MiddleName;
                    item.OffcAcr = employee.OffcAcr;
                    item.OfficeId = employee.OfficeId;
                    item.OfficeName = employee.OfficeName;
                    item.Position = employee.Position;
                    item.EmployeeId = employee.Id;
                    item.FirstName = employee.FirstName;

                }
            }
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                cboEmployeeRepo.DataSource = new BindingList<Employees>(unitOfWork.EmployeesRepo.Get());
                BACGridControl.DataSource = new BindingList<BACMembers>(unitOfWork.BACMembersRepo.Get());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail(BACMembers item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void BACGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (BACGridView.GetFocusedRow() is BACMembers item)
                {
                    if (item.Id == 0)
                    {
                        unitOfWork.BACMembersRepo.Insert(item);
                        unitOfWork.Save();
                    }
                    else
                    {
                        unitOfWork.BACMembersRepo.Update(new BACMembers()
                        {
                            Id = item.Id,
                            EmployeeId = item.Id,
                            FirstName = item.FirstName,
                            MiddleName = item.MiddleName,
                            LastName = item.LastName,
                            OffcAcr = item.OffcAcr,
                            OfficeName = item.OfficeName,
                            OfficeId = item.OfficeId,
                            Position = item.Position
                        });
                        unitOfWork.Save();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
