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
using Win.BL;

namespace Win.Pyrll
{
    public partial class frmAddEditPayrollDifferentials : DevExpress.XtraEditors.XtraForm, ITransactions<PayrollDifferentials>
    {
        private PayrollDifferentials payrollDifferentials;


        public frmAddEditPayrollDifferentials(PayrollDifferentials payrollDifferentials, MethodType methodType)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.payrollDifferentials = payrollDifferentials;

            Init();
        }

        private void frmAddEditPayrollDifferentials_Load(object sender, EventArgs e)
        {

        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.PayrollDifferentialsRepo.Find(x => x.Id == this.payrollDifferentials.Id);
                item.Date = txtDate.DateTime;
                item.Description = txtPayDescription.Text;
                item.Title = txtPayTitle.Text; item.ApprovedBy = txtDeptHead.Text;
                item.ApprovedById = (txtDeptHead.GetSelectedDataRow() as Signatories)?.Id;
                item.Accountant = txtAccountant.Text;
                item.AccountantPos = (txtAccountant.GetSelectedDataRow() as Signatories)?.Position;
                item.Treasurer = txtTreasurer.Text;
                item.TreasurerPos = (txtTreasurer.GetSelectedDataRow() as Signatories)?.Position;
                unitOfWork.Save();
                this.Close();
            }
            catch (Exception e)
            {

            }
        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                var item = unitOfWork.PayrollDifferentialsRepo.Find(x => x.Id == this.payrollDifferentials.Id);
                this.lookUpEditEmployees.DataSource = unitOfWork.EmployeesRepo.Get(); this.txtAccountant.Properties.DataSource = unitOfWork.Signatories.Get();
                this.txtTreasurer.Properties.DataSource = unitOfWork.Signatories.Get();
                this.txtDeptHead.Properties.DataSource = unitOfWork.Signatories.Get();

                this.txtDate.EditValue = item.Date;
                this.txtControl.EditValue = item.ControlNo;
                this.txtPayDescription.EditValue = item.Description;
                this.txtPayTitle.EditValue = item.Title;
                this.PayrollDiffDetailGridControl.DataSource =
                    new BindingList<PayrollDifferentialDetails>(
                        unitOfWork.PayrollDifferentialDetailsRepo.Get(x => x.PayrollDiffentialId == item.Id));
                if (staticSettings.Offices.IsDivision == true)
                {
                    this.txtDivisionChief.EditValue = item.ChiefOfOffice;
                    this.txtPosition.EditValue = item.Position;
                    this.txtDeptHead.EditValue = item.ApprovedBy;
                }
                else
                {
                    this.txtDeptHead.EditValue = item.ApprovedBy;
                }

                this.txtAccountant.EditValue = item.Accountant;
                this.txtTreasurer.EditValue = item.Treasurer;


            }
            catch (Exception e)
            {

            }
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                var diff = unitOfWork.PayrollDifferentialsRepo.Fetch(x => x.Obligations.OfficeId == staticSettings.OfficeId)
                    .OrderByDescending(x => x.Id)?.FirstOrDefault();
                var item = new PayrollDifferentials()
                {
                    ObId = payrollDifferentials.ObId,
                    Description =
                        "WE HEREBY ACKNOWLEDGE RECEIPT of the sum shown opposite our names as full compensation for the services rendered to the period stated",
                    Date = DateTime.Now,
                    ControlNo = IdHelper.OfficeControlNo(diff?.ControlNo, staticSettings.OfficeId,"PAYROLL", "Differential"),


                };
                if (staticSettings.Offices.IsDivision == true)
                {
                    item.ChiefOfOffice = staticSettings.Head;
                    item.Position = staticSettings.HeadPos;
                    item.ApprovedBy = staticSettings.Offices?.UnderOfOffice?.Chief;
                    item.ApprovedByPos = staticSettings.Offices?.UnderOfOffice?.ChiefPosition;
                    item.ApprovedById = staticSettings.Offices?.UnderOfOffice?.HeadId;
                }
                else
                {
                    item.ApprovedBy = staticSettings.Offices?.Chief;
                    item.ApprovedByPos = staticSettings.Offices?.ChiefPosition;
                    item.ApprovedById = staticSettings.Offices?.HeadId;
                }

                var accountant = unitOfWork.Signatories.Find(x => x.Position == "Provincial Accountant");
                item.Accountant = accountant?.Person;
                item.AccountantPos = accountant?.Position;
                var treasurer = unitOfWork.Signatories.Find(x => x.Position == "Provincial Treasurer");
                item.Treasurer = treasurer?.Person;
                item.TreasurerPos = treasurer?.Position;
                unitOfWork.PayrollDifferentialsRepo.Insert(item);
                unitOfWork.Save();
                payrollDifferentials = item;
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void PayrollDiffDetailGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is PayrollDifferentialDetails item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.PayrollDiffentialId = payrollDifferentials.Id;
                    //var oldvsNew = (item.NewRate ?? 0) - (item.OldRate ?? 0);
                    //var grossDifferential = (oldvsNew) * (item.Month ?? 0);
                    //item.TotalAmount = grossDifferential - ((item.PHPS ?? 0) + (item.PIPS));
                    //item.Amount = oldvsNew;
                    //item.DiffBonus = grossDifferential;
                    if (item.Id == 0)
                    {
                        unitOfWork.PayrollDifferentialDetailsRepo.Insert(item);
                    }
                    else
                    {
                        //unitOfWork.PayrollDifferentialDetailsRepo.Update(item);
                        var res = unitOfWork.PayrollDifferentialDetailsRepo.Find(x => x.Id == item.Id);
                        res.EmployeeName = item.EmployeeName;
                        res.EmployeeId = item.EmployeeId;
                        res.Designation = item.Designation;
                        res.OldRate = item.OldRate;
                        res.NewRate = item.NewRate;
                        res.SalaryGrade = item.SalaryGrade;
                        res.Month = item.Month;
                        res.DiffBonus = item.DiffBonus;
                        res.Amount = item.Amount;
                        res.PHGS = item.PHGS;
                        res.PHPS = item.PHPS;
                        res.PIGS = item.PIGS;
                        res.PIPS = item.PIPS;
                        res.GSISGS = item.GSISGS;
                        res.GSISPS = item.GSISPS;
                        res.ItemNumber = item.ItemNumber;

                    }
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void PayrollDiffDetailGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (PayrollDiffDetailGridView.GetRow(e.RowHandle) is PayrollDifferentialDetails item)
            {
                if (e.Column.Name == "colName")
                {

                    UnitOfWork unitOfWork = new UnitOfWork();
                    var employee = unitOfWork.EmployeesRepo.Find(x => x.Id == item.EmployeeId);
                    item.Designation = employee.Position;
                    item.EmployeeName = employee.EmployeeName;
                    item.SalaryGrade = employee.SG;

                }


                if (e.Column.Name == "colNewRate" || e.Column.Name == "colOldRate")
                {

                    item.Amount = (item.NewRate ?? 0) - (item.OldRate ?? 0);

                }

                if (e.Column.Name == "colMonth" || e.Column.Name == "colMidYear")
                {
                    item.DiffBonus = (item.Amount ?? 0) * (item.Month ?? 0);
                    item.DiffBonus = item.DiffBonus + (item.DiffMidYearBonus?? 0);
                    item.TotalAmount = item.DiffBonus;
                }

                string[] deductions = new string[] { "colPHPS", "colPIPS", "colGSISPS" };
                if (deductions.Contains(e.Column.Name))
                {
                    var deduction = (item.GSISPS ?? 0) + (item.PHPS ?? 0) + (item.PIPS ?? 0);
                    item.TotalAmount = (item.DiffBonus ?? 0) - deduction;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (PayrollDiffDetailGridView.GetFocusedRow() is PayrollDifferentialDetails item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollDifferentialDetailsRepo.Delete(x => x.Id == item.Id);
                unitOfWork.Save();
                Init();
            }
        }
    }
}