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
        StaticSettings staticSettings = new StaticSettings();
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
                item.Remarks = txtRemarks.Text;
                item.ActionTaken = txtActionTaken.Text;

                item.isSaved = true;
                //item.Users.Clear();
                //foreach (var i in cboUsers.Text.Split(','))
                //{
                //    var user = i.Trim();
                //    item.Users.Add(unitOfWork.UsersRepo.Get().FirstOrDefault(x => x.FullName == user));
                //}
                unitOfWork.Save();
                isClosed = true;
                Detail();

                if (MessageBox.Show("Do you want to close this?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                Close();
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

                var item = unitOfWork.DocumentActionsRepo.Find(x => x.Id == documentActions.Id, "Users");
                this.cboPrograms.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.Category == "Programs", m => m.OrderBy(x => x.ItemOrder));
                this.ActionTakenBindingSource.DataSource = new UnitOfWork().ActionTakensRepo.Get();
                // this.cboUsers.Properties.DataSource = unitOfWork.UsersRepo.Get();
                cboPrograms.EditValue = item.ProgramId;
                cboMain.EditValue = item.MainActivityId;
                this.cboActivity.EditValue = item.ActivityId;
                cboSub.EditValue = item.SubActivityId;
                txtActionTaken.EditValue = item.ActionTaken;
                dtDate.EditValue = item.ActionDate;
                txtRemarks.Text = item.Remarks;
                cboUsers.EditValue = item.RoutedToUsers;


                if (item.isSaved == true)
                    this.btnSend.Enabled = true;
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
                    CreatedBy = User.UserId,
                    ControlNo = documentActions.ControlNo

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
            if (((LookUpEdit)sender).GetSelectedDataRow() is Actions item)
            {
                this.cboMain.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.ParentId == item.Id, m => m.OrderBy(x => x.ItemOrder));
            }

        }

        private void cboMain_EditValueChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (((LookUpEdit)sender).GetSelectedDataRow() is Actions item)
            {
                this.cboActivity.Properties.DataSource =
                    unitOfWork.ActionsRepo.Get(m => m.ParentId == item.Id, m => m.OrderBy(x => x.ItemOrder));
            }
        }

        private void cboActivity_EditValueChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (((LookUpEdit)sender).GetSelectedDataRow() is Actions item)
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

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to send this?", "Send", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.DocumentActionsRepo.Find(x => x.Id == documentActions.Id, "Users");

                item.IsSend = true;
                unitOfWork.Save();
                Close();
            }
            catch (Exception exception)
            {

            }
        }

        private void btnRouteTo_Click(object sender, EventArgs e)
        {
            frmUsersInAccounts frm = new frmUsersInAccounts(new UnitOfWork().DocumentActionsRepo.Find(x => x.Id == documentActions.Id));
            frm.ShowDialog();
            var item = new UnitOfWork().DocumentActionsRepo.Find(x => x.Id == documentActions.Id);
            cboUsers.EditValue = item.RoutedToUsers;
        }

        private void btnActionTaken_Click(object sender, EventArgs e)
        {
            frmActionTaken frm = new frmActionTaken();
            frm.ShowDialog();
            this.ActionTakenBindingSource.DataSource = new UnitOfWork().ActionTakensRepo.Get();
        }
    }
}