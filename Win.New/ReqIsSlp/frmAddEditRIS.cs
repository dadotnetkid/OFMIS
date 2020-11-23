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


namespace Win.ReqIsSlp
{
    public partial class frmAddEditRIS : DevExpress.XtraEditors.XtraForm
    {
        private RISHeader model;
        private MethodType methodType;
        private bool isClosed;

        public frmAddEditRIS(MethodType methodType, RISHeader model)
        {
            InitializeComponent();
            this.model = model;
            this.methodType = methodType;
            Init();
        }


        void Details(RISHeader item)
        {
            try
            {
                if (item == null)
                    MessageBox.Show("Detail is null");
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                item = unitOfWork.RISHeaderRepo.Find(x => x.Id == item.Id);
                this.dtDate.EditValue = item.Date;
                this.employeesBindingSource.DataSource =
                    unitOfWork.EmployeesRepo.Get(x => x.OfficeId == staticSettings.OfficeId);
                this.approvedByBindingSource.DataSource =
                    unitOfWork.Signatories.Get(x => x.Office == "Provincial General Services Office");
                this.gsoEmployeesBindingSource.DataSource = unitOfWork.EmployeesRepo.Get(x => x.OffcAcr == "PGSO");
                this.requestedByBindingSource.DataSource =
                    unitOfWork.Signatories.Get(x => x.Office == staticSettings.OfficeName);
                if (string.IsNullOrEmpty(item.ApprovedBy))
                    item.ApprovedBy = (approvedByBindingSource.DataSource as List<Signatories>)?.FirstOrDefault()
                        ?.Person;
                if (string.IsNullOrEmpty(item.RequestedBy))
                    item.RequestedBy = (requestedByBindingSource.DataSource as List<Signatories>)?.FirstOrDefault()
                        ?.Person;
                this.cboRecevedBy.EditValue = item.ReceivedBy;
                this.cboRequestedBy.EditValue = item.RequestedBy;
                this.cboApprovedBy.EditValue = item.ApprovedBy;
                this.cboIssuedBy.EditValue = item.IssuedBy;
                this.txtPurpose.EditValue = item.Purpose;
                this.ItemsGridControl.DataSource = new BindingList<RISDetails>(item.RISDetails.ToList());
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
                UnitOfWork unitOfWork = new UnitOfWork();
                if (methodType == MethodType.Edit)
                {
                    this.Details(model);
                    return;
                }

                model = new RISHeader()
                {
                    Date = DateTime.Now,
                    CreatedBy = User.UserId,
                    PRId = this.model.PRId,
                    OfficeId= model.OfficeId,
                    
                };
                unitOfWork.RISHeaderRepo.Insert(model);
                unitOfWork.Save();
                Details(model);
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
                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.RISHeaderRepo.Find(x => x.Id == model.Id);
                if (cboRequestedBy.GetSelectedDataRow() is Signatories requestedBy)
                {
                    item.RequestedBy = requestedBy.Person;
                    item.RequestedByPos = requestedBy.Position;
                }

                if (cboApprovedBy.GetSelectedDataRow() is Signatories approvedBy)
                {
                    item.ApprovedBy = approvedBy.Person;
                    item.ApprovedByPos = approvedBy.Position;
                }

                if (cboIssuedBy.GetSelectedDataRow() is Employees issuedBy)
                {
                    item.IssuedBy = issuedBy.EmployeeName;
                    item.IssuedByPos = issuedBy.Position;
                }

                if (cboRecevedBy.GetSelectedDataRow() is Employees receivedBy)
                {
                    item.ReceivedBy = receivedBy.EmployeeName;
                    item.ReceivedByPos = receivedBy.Position;
                }
                
                item.Date = dtDate.DateTime;
                item.Purpose = txtPurpose.Text;
                unitOfWork.Save();
                this.isClosed = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmAddEditRIS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (methodType == MethodType.Edit || this.isClosed)
                return;

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.RISHeaderRepo.Delete(x => x.Id == model.Id);
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemsGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is RISDetails item)
                {
                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.No)
                        return;


                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.RISId = model.Id;
                    item.TotalAmount = item.Quantity * item.Cost;
                    if (item.Id == 0)
                    {
                        unitOfWork.RISDetailsRepo.Insert(item);
                    }
                    else
                    {
                        var res = unitOfWork.RISDetailsRepo.Find(x => x.Id == item.Id);
                        res.ItemNo = item.ItemNo;
                        res.Quantity = item.Quantity;
                        res.TotalAmount = item.TotalAmount;
                        res.Cost = item.Cost;
                        res.Category = item.Category;
                        res.Item = item.Item;
                    }

                    unitOfWork.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            frmAddFromPO frm = new frmAddFromPO(new UnitOfWork().RISHeaderRepo.Find(x => x.Id == this.model.Id));
            frm.ShowDialog();
            this.ItemsGridControl.DataSource =
                new BindingList<RISDetails>(new UnitOfWork().RISDetailsRepo.Get(x => x.RISId == model.Id));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}