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


        public frmAddEditPayrollWages(MethodType methodType, PayrollWages payrollWages)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.payrollWages = payrollWages;
            Init();
            PayrollGridView.RowUpdated += PayrollGridView_RowUpdated;
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.PayrollWagesRepo.Find(m => m.Id == payrollWages.Id);
                item.Date = txtDate.DateTime;
                item.ControlNo = txtControl.Text;
                item.Description = txtPayDescription.Text;
                item.Title = txtPayTitle.Text;
                item.ChiefOfOffice = txtChief.Text;
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
                payrollWages = unitOfWork.PayrollWagesRepo.Find(m => m.Id == payrollWages.Id);
                txtAccountant.Properties.DataSource = new BindingList<Signatories>(unitOfWork.ChiefOfOfficesRepo.Get());
                txtGovernor.Properties.DataSource = new BindingList<Signatories>(unitOfWork.ChiefOfOfficesRepo.Get());
                txtTreasurer.Properties.DataSource = new BindingList<Signatories>(unitOfWork.ChiefOfOfficesRepo.Get());
                txtDate.EditValue = payrollWages.Date;
                txtControl.EditValue = payrollWages.ControlNo;
                txtPayTitle.EditValue = payrollWages.Title;
                txtPayDescription.EditValue = payrollWages.Description;
                txtChief.EditValue = payrollWages.ChiefOfOffice;
                txtPosition.EditValue = payrollWages.Position;
                txtGovernor.EditValue = payrollWages.ApprovedBy;
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
                    var total = (wages + (item.PERA ?? 0)) - ((item.PHPS ?? 0)+  (item.PIPS ?? 0));
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
                            RatePerDay = item.RatePerDay,
                            Total = item.Total
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
                    Id = (res?.Id ?? 0) + 1,
                    Date = DateTime.Now,
                    Accountant = (unitOfWork.ChiefOfOfficesRepo.Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")))?.FirstOrDefault()?.Person,
                    AccountantPos = (unitOfWork.ChiefOfOfficesRepo.Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")))?.FirstOrDefault()?.Position,
                    Treasurer = (unitOfWork.ChiefOfOfficesRepo.Get(m => m.Office.Contains("Treasurer")))?.FirstOrDefault()?.Person,
                    TreasurerPos = (unitOfWork.ChiefOfOfficesRepo.Get(m => m.Office.Contains("Treasurer")))?.FirstOrDefault()?.Position,
                    ChiefOfOffice = staticSettings.Head,
                    Position = staticSettings.HeadPos,
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
    }
}