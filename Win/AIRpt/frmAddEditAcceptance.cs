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

namespace Win.AIRpt
{
    public partial class frmAddEditAcceptance : DevExpress.XtraEditors.XtraForm, ITransactions<AIReports>
    {
        private AIReports aIReports;
        private bool isClosed;


        public frmAddEditAcceptance(MethodType methodType, AIReports aIReports)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.aIReports = aIReports;
            Init();
        }

        private void frmAddEditAcceptance_Load(object sender, EventArgs e)
        {

        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.AIReportsRepo.Find(x => x.Id == aIReports.Id);
                item.Date = dtDate.DateTime;
                item.ControlNo = txtControlNumber.Text;
                if (cboPropertyInspector.GetSelectedDataRow() is Employees emp)
                {
                    item.PropertyInspector = emp.EmployeeName;
                    item.PropertyInspectorPosition = emp.Position;
                }

                if (cboPropertyInspector2.GetSelectedDataRow() is Employees pgso)
                {
                    item.PropertyInspector2 = pgso.EmployeeName;
                    item.PropertyInspector2Position = pgso.Position;
                }

                if (cboHeadOffice.GetSelectedDataRow() is Signatories ao)
                {
                    item.Head = ao.Person;
                    item.HeadPosition = ao.Position;
                }

                if (cboPropertyOfficer.GetSelectedDataRow() is Employees po)
                {
                    item.PropertyOfficer = po.EmployeeName;
                    item.PropertyOfficerPosition = po.Position;
                }

                if (cboPGSO.GetSelectedDataRow() is Signatories notedBy)
                {
                    item.PGSOfficer = notedBy.Person;
                    item.PGSOfficerPosition = notedBy.Position;
                }

                if (cboPropertyOfficer2.GetSelectedDataRow() is Employees po2)
                {
                    item.PropertyOfficer2 = po2.EmployeeName;
                    item.PropertyOfficerPosition2 = po2.Position;
                }
                item.PreparedBy = User.UserId;

                item.RISDate = dtRISDate.DateTime;
                item.RISNo = txtRIS.Text?.ToInt();
                unitOfWork.Save();
                this.isClosed = true;
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
                var item = unitOfWork.AIReportsRepo.Find(x => x.Id == aIReports.Id);
                dtDate.EditValue = item.Date;
                txtControlNumber.Text = item.ControlNo;
                var employees = new List<Employees>() { new Employees() };
                employees.AddRange(unitOfWork.EmployeesRepo.Get());
                var signatories = new List<Signatories>() { new Signatories() };
                signatories.AddRange(unitOfWork.Signatories.Get());
                employeesBindingSource.DataSource = employees;
                signatoriesBindingSource.DataSource = signatories;
                dtRISDate.EditValue = item.RISDate ?? null;
                txtRIS.EditValue = item.RISNo;

                cboPropertyInspector.EditValue = item.PropertyInspector;
                cboPropertyInspector2.EditValue = item.PropertyInspector2;
                cboHeadOffice.EditValue = item.Head;
                cboPropertyOfficer.EditValue = item.PropertyOfficer;
                cboPropertyOfficer2.EditValue = item.PropertyOfficer2;
                cboPGSO.EditValue = item.PGSOfficer;

                ItemsGridControl.DataSource =
                    new BindingList<AIRDetails>(new UnitOfWork(false, false).AIRDetailsRepo.Get(x => x.AIReportId == item.Id));

            }
            catch (Exception e)
            {

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
                StaticSettings staticSettings = new StaticSettings();
                var id = unitOfWork.AIReportsRepo.Fetch(x => x.PurchaseRequests.OfficeId == staticSettings.OfficeId)
                    .OrderByDescending(x => x.Id)?.FirstOrDefault();
                this.aIReports = new AIReports()
                {
                    PRId = aIReports.PRId,
                    Date = DateTime.Now,
                    ControlNo = IdHelper.OfficeControlNo(id?.ControlNo, staticSettings.OfficeId, "APR", "Acceptance"),
                    PreparedBy = User.UserId,
                };
                unitOfWork.AIReportsRepo.Insert(aIReports);
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
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is AIRDetails item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    item.AIReportId = aIReports.Id;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.TotalAmount = item.Quantity * item.Cost;
                    item.Category = item.Category ?? "";

                    if (item.Id == 0)
                    {
                        unitOfWork.AIRDetailsRepo.Insert(item);
                    }
                    else
                    {
                        unitOfWork.AIRDetailsRepo.Update(item);
                    }

                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddFromPO frm = new frmAddFromPO(this.aIReports);
                frm.ShowDialog();
                ItemsGridControl.DataSource =
                    new BindingList<AIRDetails>(new UnitOfWork(false, false).AIRDetailsRepo.Get(x => x.AIReportId == aIReports.Id));
            }
            catch (Exception exception)
            {

            }
        }

        private void btnDeleteItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}