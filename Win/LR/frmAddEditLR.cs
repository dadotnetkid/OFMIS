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

namespace Win.LR
{
    public partial class frmAddEditLR : DevExpress.XtraEditors.XtraForm
    {
        private Liquidations liquidations;
        private MethodType methodType;
        private bool isClosed;

        public frmAddEditLR(Liquidations liquidations, MethodType methodType)
        {
            InitializeComponent();
            this.liquidations = liquidations;
            this.methodType = methodType;
            Init();
        }

        private void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    this.Details();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();

                liquidations = new Liquidations()
                {
                    Date = DateTime.Now,
                    DateCreated = DateTime.Now,
                    ObRId = liquidations.ObRId,
                    CreatedBy = User.UserId
                };
                if (staticSettings.Offices.IsDivision == true)
                {
                    liquidations.HeadOfDep = staticSettings.Offices.UnderOfOffice.HeadId;
                }
                else
                {
                    liquidations.HeadOfDep = staticSettings.Offices.HeadId;
                }

                var accountant = unitOfWork.Signatories.Find(x =>
                    x.Office.Contains("Accounting") || x.Position.Contains("Provincial Accountant"));
                liquidations.PAId = accountant?.Id;
                liquidations.AccountantName = accountant?.Person;
                liquidations.AccountantPosition = accountant?.Position;
                unitOfWork.LiquidationsRepo.Insert(liquidations);
                unitOfWork.Save();
                Details();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Details()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                cboAccountant.Properties.DataSource = unitOfWork.Signatories.Get(x => x.Office.Contains("Accounting") || x.Position.Contains("Accountant"));
                cboDepthead.Properties.DataSource =
                    unitOfWork.Signatories.Get(x => x.Office.Contains(staticSettings.OfficeName));
                if (staticSettings.Offices.IsDivision == true)
                {
                    cboDepthead.Properties.DataSource =
                        unitOfWork.Signatories.Get(x => x.Office.Contains(staticSettings.Offices.UnderOfOffice.OfficeName));
                }
                cboPayee.Properties.DataSource = unitOfWork.EmployeesRepo.Get();

                var item = unitOfWork.LiquidationsRepo.Find(x => x.Id == liquidations.Id);
                cboPayee.EditValue = item.EmployeeId;
                cboAccountant.EditValue = item.PAId;
                cboDepthead.EditValue = item.HeadOfDep;
                dtDate.EditValue = item.Date;
                txtParticulars.EditValue = item.Particulars;
                txtAmount.EditValue = item.Amount;
                txtPeriodCovered.EditValue = item.PeriodCovered;
            }
            catch (Exception e)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.LiquidationsRepo.Find(x => x.Id == liquidations.Id);
                if (cboPayee.GetSelectedDataRow() is Employees emp)
                {
                    item.EmployeeId = emp.Id;
                }
                item.Particulars = item.Particulars;
                if (cboDepthead.GetSelectedDataRow() is Signatories head)
                {
                    item.HeadOfDep = head.Id;
                    item.HeadName = head.Person;
                    item.HeadPosition = head.Position;
                }

                if (cboAccountant.GetSelectedDataRow() is Signatories pa)
                {
                    item.PAId = pa.Id;
                    item.AccountantName = pa.Person;
                    item.AccountantPosition = pa.Position;
                }
                item.Date = dtDate.DateTime;
                item.Amount = this.txtAmount.EditValue?.ToDecimal();
                item.Particulars = txtParticulars.Text;
                item.PeriodCovered = txtPeriodCovered.Text;
                unitOfWork.Save();
                isClosed = true;
                Close();
            }
            catch (Exception e)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmAddEditLR_Load(object sender, EventArgs e)
        {

        }

        private void frmAddEditLR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isClosed)
            {

                if (MessageBox.Show("Do you want to delete this?", "delete", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.LiquidationsRepo.Delete(x => x.Id == liquidations.Id);
                unitOfWork.Save();
            }
        }
    }
}