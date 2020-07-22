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

namespace Win.Actns
{
    public partial class frmTaskDone : DevExpress.XtraEditors.XtraForm
    {
        private DocumentActions document;

        public frmTaskDone(DocumentActions document)
        {
            InitializeComponent();
            this.document = document;
            this.Detail();
        }

        private void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                this.documentActionsBindingSource.DataSource =
                    unitOfWork.DocumentActionsRepo.Get(x => x.CreatedBy == User.UserId && x.RefId == document.RefId);
                this.usersBindingSource.DataSource = unitOfWork.UsersRepo.Get();
                document = unitOfWork.DocumentActionsRepo.Find(x => x.Id == document.Id);
                this.txtDocuement.Text = document.Description;
                this.txtTask.Text = document.Remarks;
                this.cboAssignedBy.EditValue = document.CreatedBy;

            }
            catch (Exception e)
            {

            }
        }

        private void frmTaskDone_Load(object sender, EventArgs e)
        {

        }

        private void btnTaskDone_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                document = unitOfWork.DocumentActionsRepo.Find(x => x.Id == document.Id);
                if (cboActionDone.GetSelectedDataRow() is DocumentActions item)
                {
                    document.isDone = true;
                    document.ActionId = item.Id;
                    unitOfWork.Save();
                }

                Close();
            }
            catch (Exception exception)
            {

            }
        }
    }
}