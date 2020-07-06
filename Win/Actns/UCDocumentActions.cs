using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Actns
{
    public partial class UCDocumentActions : DevExpress.XtraEditors.XtraUserControl, ILoad<DocumentActions>
    {
        private string tableName;
        private int refId;

        public UCDocumentActions(int refId, string tableName)
        {
            InitializeComponent();
            this.refId = refId;
            this.tableName = tableName;
            Init();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                esms.QueryableSource = unitOfWork.DocumentActionsRepo.Fetch();
            }
            catch (Exception e)
            {
            }
        }

        public void Detail(DocumentActions item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmDocActions frm = new frmDocActions(MethodType.Add, new DocumentActions()
            {
                TableName = this.tableName,
                RefId = this.refId
            });
            frm.ShowDialog();
            Init();
        }



        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (DocActionGridView.GetFocusedRow() is DocumentActions item)
            {
                frmDocActions frm = new frmDocActions(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DocActionGridView.GetFocusedRow() is DocumentActions item)
            {
                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.DocumentActionsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
