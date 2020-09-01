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

namespace Win.Pyrll
{
    public partial class frmAddEditPayrollOT : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private PayrollOT payroll;
        private bool isClosed;

        public frmAddEditPayrollOT(MethodType methodType, PayrollOT payroll)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.payroll = payroll;
            this.Init();
        }

        void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Details(payroll);
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                var PA = unitOfWork.Signatories.Find(x => x.Position.Contains("Accountant"));
                var PT = unitOfWork.Signatories.Find(x => x.Position.Contains("Treasuser"));
                var ProvAdmin = unitOfWork.Signatories.Find(x => x.Position.Contains("Provincial Administrator"));
                payroll = new PayrollOT()
                {
                    ObRId = payroll.ObRId,
                    Date = DateTime.Now,
                    HeadId = new StaticSettings().Offices.HeadId,
                    HeadPosition = new StaticSettings().HeadPos,
                    PAId = PA.Id,
                    PAPosition = PA.Position,
                    PTId = PT.Id,
                    PTPosition = PT.Position,
                    ApprovedById = ProvAdmin.Id,
                    ApprovedPosition = ProvAdmin.Position


                };
                unitOfWork.PayrollOTRepo.Insert(payroll);
                unitOfWork.Save();
                Details(payroll);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void Details(PayrollOT item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.signatoriesBindingSource.DataSource = unitOfWork.Signatories.Get();
                this.cboEmployee.DataSource = unitOfWork.EmployeesRepo.Get();

                item = unitOfWork.PayrollOTRepo.Find(x => x.Id == item.Id, includeProperties: "Obligations");
                txtDate.EditValue = item.Date;
                txtControl.EditValue = item.Obligations.ControlNo;
                txtPayDescription.EditValue = item.Description;
                txtPayTitle.EditValue = item.Title;
                CboHead.EditValue = item.HeadId;
                cboApprovedBy.EditValue = item.ApprovedById;
                txtAccountant.EditValue = item.PAId;
                txtTreasurer.EditValue = item.PTId;
                this.PayrollGridControl.DataSource =
                    new BindingList<PayrollOTDetails>(
                        unitOfWork.PayrollOTDetailsRepo.Get(x => x.PayrollOTId == payroll.Id));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PayrollGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (PayrollGridView.GetRow(e.RowHandle) is PayrollOTDetails item)
            {
                var ratePerDay = item.RatePerMonth / 22.0M;
                var ratePerHour = ratePerDay / 8.0M;
                item.RatePerDay = ratePerDay;
                item.RatePerHr = ratePerHour;
                var amountWeekEnd = ((item.WeekEndNoHrs ?? 0) * (item.RatePerHr ?? 0)) * 1.5m;
                var amountWeekDays = ((item.WeekDayNoHrs ?? 0) * (item.RatePerHr ?? 0)) * 1.25m;
                item.SubTotal = amountWeekEnd + amountWeekDays;
                item.TotalAmount = (item.SubTotal ?? 0) - (item.UnderPay ?? 0);
            }

            // PayrollGridView.RefreshRow(e.RowHandle);
        }

        private void PayrollGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is PayrollOTDetails item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                item.PayrollOTId = payroll.Id;
                if (item.Id == 0)
                {
                    item.DateCreated = DateTime.Now;
                    unitOfWork.PayrollOTDetailsRepo.Insert(item);

                }
                else
                {
                    var res = unitOfWork.PayrollOTDetailsRepo.Find(x => x.Id == item.Id);
                    res.EmployeeId = item.EmployeeId;
                    res.RatePerDay = item.RatePerDay;
                    res.RatePerHr = item.RatePerHr;
                    res.RatePerMonth = item.RatePerMonth;
                    res.SubTotal = item.SubTotal;
                    res.TotalAmount = item.TotalAmount;
                    res.UnderPay = item.UnderPay;
                    res.WeekDayNoHrs = item.WeekDayNoHrs;
                    res.WeekEndNoHrs = item.WeekEndNoHrs;
                    res.ItemNo = item.ItemNo;
                }
                unitOfWork.Save();
            }
        }

        void Save()
        {

            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.PayrollOTRepo.Find(x => x.Id == payroll.Id);
                res.Description = txtPayDescription.EditValue.ToString();
                res.Title = txtPayTitle.EditValue.ToString();
                if (CboHead.GetSelectedDataRow() is Signatories item)
                {

                }

                isClosed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEditPayrollOT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isClosed || methodType == MethodType.Edit)
                return;

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollOTRepo.Delete(x => x.Id == this.payroll.Id);
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}