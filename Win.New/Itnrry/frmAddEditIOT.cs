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
using Helpers;
using Models;
using Models.Repository;

namespace Win.Itnrry
{
    public partial class frmAddEditIOT : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private ItenaryofTravels itenaryofTravels;

        public frmAddEditIOT(MethodType methodType, ItenaryofTravels itenaryofTravels)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.itenaryofTravels = itenaryofTravels;
            this.Init();
        }

        void Details(ItenaryofTravels item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.employeesBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();


                item = unitOfWork.ItenaryofTravelsRepo.Find(x => x.Id == item.Id);
                this.cboEmployeeName.EditValue = item.EmployeeId;
                this.dtDate.EditValue = item.DateCreated;
                this.txtPosition.EditValue = item.Position;
                this.txtStation.EditValue = item.OfficialAddress;
                this.txtPurpose.EditValue = item.Purpose;
                this.cboApprovedBy.EditValue = item.ApprovedBy;

                itenaryDetailsBindingSource.DataSource =
                    new BindingList<ItenaryDetails>(unitOfWork.ItenaryDetailsRepo.Get(x => x.IOTId == item.Id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Details(itenaryofTravels);
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                this.itenaryofTravels = new ItenaryofTravels()
                {
                    DateCreated = DateTime.Now,
                    OBRId = itenaryofTravels.OBRId,
                    CreatedBy = User.UserId,
                };
                unitOfWork.ItenaryofTravelsRepo.Insert(this.itenaryofTravels);
                unitOfWork.Save();
                Details(itenaryofTravels);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Save()
        {

            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.ItenaryofTravelsRepo.Find(x => x.Id == itenaryofTravels.Id);
                item.DateCreated = DateTime.Now;
                if (cboEmployeeName.GetSelectedDataRow() is Employees employees)
                {
                    item.EmployeeId = employees.Id;
                    item.Position = employees.Position;
                }

                item.OfficialAddress = txtStation.EditValue?.ToString();
                item.Purpose = txtPurpose.EditValue?.ToString();
                if (cboApprovedBy.GetSelectedDataRow() is Employees approvedBy)
                {
                    item.ApprovedBy = approvedBy.Id;
                    item.ApprovedByPos = approvedBy.Position;
                }

                unitOfWork.Save();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.IOTGridView.GetFocusedRow() is ItenaryDetails item)
            {


                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                try
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ItenaryDetailsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    this.itenaryDetailsBindingSource.DataSource =
                        new BindingList<ItenaryDetails>(
                            unitOfWork.ItenaryDetailsRepo.Get(x => x.IOTId == itenaryofTravels.Id));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void IOTGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            try
            {
                if (e.Row is ItenaryDetails item)
                {
                    item.IOTId = this.itenaryofTravels.Id;

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    if (item.Id == 0)
                    {
                        item.CreatedBy = User.UserId;
                        item.DateCreated = DateTime.Now;
                        unitOfWork.ItenaryDetailsRepo.Insert(item);
                    }
                    else
                    {
                        var res = unitOfWork.ItenaryDetailsRepo.Find(x => x.Id == item.Id);
                        res.Date = item.Date;
                        res.PlaceVisited = item.PlaceVisited;
                        res.DepartureTime = item.DepartureTime;
                        res.ArrivalTime = item.ArrivalTime;
                        res.MeansOfTransportation = item.MeansOfTransportation;
                        res.TransportationFee = item.TransportationFee;
                        res.PerDiems = item.PerDiems;
                        res.DailyAllowance = item.DailyAllowance;
                        res.TotalAmount = item.TotalAmount;
                    }

                    unitOfWork.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IOTGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (IOTGridView.GetRow(e.RowHandle) is ItenaryDetails item)
            {
                if (item.Date != null)
                {
                    item.DepartureTime =
                        Convert.ToDateTime(item.Date?.ToShortDateString() + " " +
                                           item.DepartureTime?.ToShortTimeString());
                    item.ArrivalTime =
                        Convert.ToDateTime(item.Date?.ToShortDateString() + " " +
                                           item.ArrivalTime?.ToShortTimeString());
                }

            }
        }

        private void cboEmployeeName_EditValueChanged(object sender, EventArgs e)
        {
            if (cboEmployeeName.GetSelectedDataRow() is Employees item)
            {
                txtPosition.Text = item.Position;

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}