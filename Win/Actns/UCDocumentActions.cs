using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;
using Win.Xcanner;

namespace Win.Actns
{
    public partial class UCDocumentActions : DevExpress.XtraEditors.XtraUserControl, ILoad<DocumentActions>
    {
        private string tableName;
        private int refId;
        private string controlNo;
        private string documentNo;

        public UCDocumentActions(int refId, string controlNo, string documentNo, string tableName)
        {
            InitializeComponent();
            this.refId = refId;
            this.tableName = tableName;
            this.controlNo = controlNo;
            this.documentNo = documentNo;
            Init();
        }

        public async void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                esms.QueryableSource = await Task.Run(() => unitOfWork.DocumentActionsRepo.Fetch(x => x.RefId == refId && x.TableName == tableName));
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
                ControlNo = controlNo,
                TableName = this.tableName,
                RefId = this.refId,
                ObR_PR_No = documentNo
            });
            frm.ShowDialog();
            Init();
        }



        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (DocActionGridView.GetFocusedRow() is DocumentActions item)
            {
                if (!User.CheckOwner(item.CreatedBy))
                    return;
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
                    if (!User.CheckOwner(item.CreatedBy))
                        return;


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

        private void DocActionGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "colRoutedTo")
            {
                if (DocActionGridView.GetRow(e.RowHandle) is DocumentActions doc)
                {
                    if (doc.IsSend == true)
                    {
                        e.Appearance.BackColor = Color.Green;
                        e.Appearance.ForeColor = Color.White;
                    }
                }
            }
            if (e.Column.Name == "colActionTaken" || e.Column.Name == "colSubActivityId" || e.Column.Name == "colActivityId")
            {
                if (DocActionGridView.GetRow(e.RowHandle) is DocumentActions doc)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var files = unitOfWork.FilesRepo.Fetch(x => x.RefId == doc.Id && x.TableName == "Action");
                    if (files.Any())
                    {
                        e.Appearance.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void btnPreviewRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DocActionGridView.GetFocusedRow() is DocumentActions item)
            {
                using (NetworkShareAccesser.Access("PLGUNV_NAS", @"", "pitd.is_user", "Apple_01"))
                {
                    StaticSettings staticSettings = new StaticSettings();
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var root = $@"\\plgunv_nas\is_docs\ofmis\{staticSettings.Offices.OffcAcr}";
                    if (!Directory.Exists(root))
                        Directory.CreateDirectory(root);

                    var files = unitOfWork.FilesRepo.Find(x => x.RefId == item.Id && x.TableName == "Action");

                    if (files == null)
                        return;
                    var path = Path.Combine(root, files.Path + ".png");
                    frmPreviewer frm = new frmPreviewer(path);
                    frm.ShowDialog();
                }
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var document = unitOfWork.DocumentActionsRepo.Get(x => x.RefId == refId && x.TableName == tableName);
                rptDocumentLedger rpt = new rptDocumentLedger() { DataSource = document };
                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
