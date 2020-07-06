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
using Win.Properties;

namespace Win.Actns
{
    public partial class frmDocActions : DevExpress.XtraEditors.XtraForm, ITransactions<DocumentActions>
    {
        private DocumentActions documentActions;
        private bool isClosed;

        public frmDocActions(MethodType methodType, DocumentActions documentActions)
        {
            InitializeComponent();
            this.documentActions = documentActions;
            this.methodType = methodType;

        }

        public void Save()
        {
            try
            {
                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.DocumentActionsRepo.Find(x => x.Id == documentActions.Id);
                item.MainActivityId = this.cboMain.EditValue?.ToInt();
                item.ActivityId = this.cboActivity.EditValue?.ToInt();
                item.SubActivityId = cboSub.EditValue?.ToInt();
                item.ProgramId = cboPrograms.EditValue?.ToInt();
                item.ActionDate = dtDate.EditValue?.ToDate();
                item.Status = cboStatus.EditValue?.ToString();
                item.Remarks = txtRemarks.Text;
                item.Status = cboStatus.Text;
                unitOfWork.Save();
                isClosed = true;
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
                var item = unitOfWork.DocumentActionsRepo.Find(x => x.Id == documentActions.Id);
                this.cboPrograms.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.Category == "Programs", m => m.OrderBy(x => x.ItemOrder));
                cboPrograms.EditValue = item.ProgramId;
                cboMain.EditValue = item.MainActivityId;
                this.cboActivity.EditValue = item.ActivityId;
                cboSub.EditValue = item.SubActivityId;
             
                dtDate.EditValue = item.ActionDate;
                cboStatus.EditValue = item.Status;
                txtRemarks.Text = item.Remarks;
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
                documentActions = new DocumentActions()
                {
                    DateCreated = DateTime.Now,
                    ActionDate = DateTime.Now,
                    TableName = documentActions.TableName,
                    RefId = documentActions.RefId,
                    CreatedBy = documentActions.CreatedBy,

                };
                unitOfWork.DocumentActionsRepo.Insert(documentActions);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {

            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            if (methodType == MethodType.Edit)
                return;
            if (this.isClosed)
                return;
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.DocumentActionsRepo.Delete(x => x.Id == this.documentActions.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {

            }
        }
        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboStatus_EditValueChanged(object sender, EventArgs e)
        {
            //    if (cboStatus.GetSelectedDataRow() is Statuses item)
            //    {
            //        cboUsers.Enabled = false;
            //        cboUsers.EditValue = null;
            //        if (item.Value == "Endorsed To")
            //            cboUsers.Enabled = true;
            //    }
        }

        private void cboPrograms_EditValueChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (cboPrograms.GetSelectedDataRow() is Actions item)
            {
                this.cboMain.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.ParentId == item.Id, m => m.OrderBy(x => x.ItemOrder));
            }

        }

        private void cboMain_EditValueChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (cboPrograms.GetSelectedDataRow() is Actions item)
            {
                this.cboActivity.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.ParentId == item.Id, m => m.OrderBy(x => x.ItemOrder));
            }
        }

        private void cboActivity_EditValueChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (cboPrograms.GetSelectedDataRow() is Actions item)
            {
                this.cboSub.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.ParentId == item.Id, m => m.OrderBy(x => x.ItemOrder));
            }


        }

        private void btnAddAction_Click(object sender, EventArgs e)
        {
            //frmActionList frm = new frmActionList();
            //frm.ShowDialog();
            //ActionTakenBindingSource.DataSource = new UnitOfWork().ActionListsRepo.Get();
        }

        public MethodType methodType { get; set; }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmDocActions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (methodType == MethodType.Add)
                Close(e);
        }

        private void frmDocActions_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}