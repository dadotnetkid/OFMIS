using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataProcessing.InMemoryDataProcessor;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Pyrll
{
    public partial class frmAddEditPayrollWages : DevExpress.XtraEditors.XtraForm, IAddEditTransaction<PayrollWages>
    {
        private PayrollWages payrollWages;
        private bool isClosed;
        StaticSettings staticSettings = new StaticSettings();
        private Obligations obligations;


        public frmAddEditPayrollWages(MethodType methodType, Obligations obligations)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.obligations = obligations;
            Init();
            PayrollGridView.RowUpdated += PayrollGridView_RowUpdated;
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.PayrollWagesRepo.Find(m => m.Id == obligations.Id);
                item.Date = txtDate.DateTime;
                item.ControlNo = txtControl.Text;
                item.Description = txtPayDescription.Text;
                item.Title = txtPayTitle.Text;
                item.ChiefOfOffice = txtDivisionChief.Text;
                item.Position = txtPosition.Text;
                item.ApprovedBy = (txtGovernor.GetSelectedDataRow() as Signatories)?.Person;
                item.ApprovedByPos = (txtGovernor.GetSelectedDataRow() as Signatories)?.Position;
                item.ApprovedById = (txtGovernor.GetSelectedDataRow() as Signatories)?.Id;
                item.Accountant = (txtAccountant.GetSelectedDataRow() as Signatories)?.Person;
                item.AccountantPos = (txtAccountant.GetSelectedDataRow() as Signatories)?.Position;
                item.Treasurer = (txtTreasurer.GetSelectedDataRow() as Signatories)?.Person;
                item.TreasurerPos = (txtTreasurer.GetSelectedDataRow() as Signatories)?.Position;
                unitOfWork.Save();
                this.isClosed = true;
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                payrollWages = unitOfWork.PayrollWagesRepo.Find(m => m.Id == obligations.Id);
                txtAccountant.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get());
                txtGovernor.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get());
                txtTreasurer.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get());
                txtDate.EditValue = payrollWages.Date;
                txtControl.EditValue = payrollWages.ControlNo;
                txtPayTitle.EditValue = payrollWages.Title;
                txtPayDescription.EditValue = payrollWages.Description;
                txtDivisionChief.EditValue = payrollWages.ChiefOfOffice;
                txtPosition.EditValue = payrollWages.Position;
                if (staticSettings.Offices.IsDivision == true && (staticSettings.Offices.UnderOfOffice.OfficeName == "Governor's Office" || staticSettings.Offices.UnderOfOffice.OfficeName == "GO" || staticSettings.Offices.UnderOfOffice.OfficeName == "Governor Office" || staticSettings.Offices.UnderOfOffice.OfficeName == "Governors Office"))
                {
                    txtGovernor.EditValue = payrollWages.ApprovedBy ?? unitOfWork.Signatories.Find(x => x.Position == "Governor")?.Person;
                }
                else
                {
                    txtGovernor.EditValue = staticSettings.Head;
                }

                txtAccountant.EditValue = payrollWages.Accountant;
                txtTreasurer.EditValue = payrollWages.Treasurer;
                PayrollGridControl.DataSource =
                    new BindingList<PayrollWageDetails>(payrollWages.PayrollWageDetails?.ToList() ??
                                                        new List<PayrollWageDetails>());
                lookUpEditEmployees.DataSource = new BindingList<Employees>(unitOfWork.EmployeesRepo.Get());


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PayrollGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (e.Row is PayrollWageDetails item)
                {
                    var wages = item.NoOfdays * item.RatePerDay;
                    var ot = (item.OT ?? 0) * (item.RatePerDay ?? 0);
                    var deduction = (item.SSSPS ?? 0) + (item.MPL ?? 0) + (item.PIFCalLoan ?? 0) + (item.SSSLoan ?? 0) + (item.NVPEA ?? 0) + (item.LBP ?? 0) + (item.DBP ?? 0) + (item.BIRWH ?? 0);
                    var total = (wages + ot + (item.PERA ?? 0)) - ((item.PHPS ?? 0) + (item.PIPS ?? 0)) - deduction;
                    item.Total = total;
                    item.GrossAmount = wages;
                    item.PayrollWageId = payrollWages.Id;
                    if (item.Id == 0)
                    {

                        unitOfWork.PayrollWageDetailsRepo.Insert(item);
                    }
                    else
                    {

                        unitOfWork.PayrollWageDetailsRepo.Update(new PayrollWageDetails()
                        {
                            Id = item.Id,
                            EmployeeId = item.EmployeeId,
                            GrossAmount = item.GrossAmount,
                            ItemNumber = item.ItemNumber,
                            NoOfdays = item.NoOfdays,
                            PayrollWageId = item.PayrollWageId,
                            PERA = item.PERA,
                            PHGS = item.PHGS,
                            PHPS = item.PHPS,
                            PIGS = item.PIGS,
                            PIPS = item.PIPS,
                            SSSPS = item.SSSPS,
                            RatePerDay = item.RatePerDay,
                            Total = item.Total,
                            BIRWH = item.BIRWH,
                            DBP = item.DBP,
                            GSISConsol = item.GSISConsol,
                            GSISPolicy = item.GSISPolicy,
                            LBP = item.LBP,
                            MPL = item.MPL,
                            NVPEA = item.NVPEA,
                            PIFCalLoan = item.PIFCalLoan,
                            SSSLoan = item.SSSLoan
                        });
                    }

                    unitOfWork.Save();
                    PayrollGridControl.DataSource =
                        new BindingList<PayrollWageDetails>(unitOfWork.PayrollWageDetailsRepo.Get(m => m.PayrollWageId == payrollWages.Id));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.PayrollWagesRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault();
                payrollWages = new PayrollWages()
                {
                    ControlNo = IdHelper.OfficeControlNo(res?.ControlNo),
                    Id = obligations.Id,
                    Date = DateTime.Now,
                    Accountant = (unitOfWork.Signatories.Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")))?.FirstOrDefault()?.Person,
                    AccountantPos = (unitOfWork.Signatories.Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")))?.FirstOrDefault()?.Position,
                    Treasurer = (unitOfWork.Signatories.Get(m => m.Office.Contains("Treasurer")))?.FirstOrDefault()?.Person,
                    TreasurerPos = (unitOfWork.Signatories.Get(m => m.Office.Contains("Treasurer")))?.FirstOrDefault()?.Position,
                    ChiefOfOffice = staticSettings.Head,
                    Position = staticSettings.HeadPos,
                    Description = "WE HEREBY ACKNOWLEDGE RECEIPT of the sum shown opposite our names as full compensation for the services rendered to the period stated",
                    PayrollWageDetails = new List<PayrollWageDetails>()

                };
                unitOfWork.PayrollWagesRepo.Insert(payrollWages);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            try
            {
                if (methodType == MethodType.Edit)
                    return;

                if (isClosed)
                    return;

                if (MessageBox.Show("Do you want to close this?", "Close", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    eventArgs.Cancel = true;
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollWagesRepo.Delete(m => m.Id == payrollWages.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(PayrollWages item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollWageDetailsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (((XtraForm)this).ValidateForm())
            {
                Save();
            }

            ;
        }

        private void btnDeletePayrollRepo_Click(object sender, EventArgs e)
        {
            try
            {
                if (PayrollGridView.GetFocusedRow() is PayrollWages item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PayrollWageDetailsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    PayrollGridControl.DataSource =
                        new BindingList<PayrollWageDetails>(payrollWages.PayrollWageDetails?.ToList() ??
                                                            new List<PayrollWageDetails>());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}