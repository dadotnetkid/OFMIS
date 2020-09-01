using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Win;
using Win.Actns;
using Win.Ltr;

namespace DMS.PAPS
{
    public partial class UCPAPsManager : DevExpress.XtraEditors.XtraUserControl
    {
        public UCPAPsManager()
        {
            InitializeComponent();
            Init();

        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                StaticSettings staticSettings = new StaticSettings();
                this.DocumentGridControl.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = unitOfWork.DocumentsRepo.Fetch(x => x.OfficeId == staticSettings.OfficeId),
                    ElementType = typeof(Documents)
                };
                this.cboSignatoryRepo.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().EmployeesRepo.Fetch()
                };
                this.cboSourceOfficeRepo.DataSource = new EntityServerModeSource()
                {
                    QueryableSource = new UnitOfWork().OfficesRepo.Fetch()
                };
                // this.documenty

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Details(Documents item)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                var staticSettings = new StaticSettings();
                item = unitOfWork.DocumentsRepo.Find(x => x.Id == item.Id);
                this.dtDate.EditValue = item.Date;
                this.txtCommType.EditValue = item.CommunicationType;
                this.txtDocType.EditValue = item.DocumentType;
                this.txtSignatory.Text = item.Employees?.EmployeeName;
                this.txtSubject.EditValue = item.Subject;
                this.lblSignatory.Text = item.Employees?.EmployeeName;
                this.lblType.Text = item.DocumentType;
                this.pctScannedImage.Image = ScannerHelper.LoadImage(item.Id, "Documents");
                tabActionTaken.Controls.Clear();
                tabActionTaken.Controls.Add(new UCDocumentActions(item.Id, item.ControlNo, "", "Documents")
                {
                    Dock = DockStyle.Fill
                });
                tabLetter.Controls.Clear();
                tabLetter.Controls.Add(new UcLetters(item.Id, item.ControlNo, "Documents",
                    $"[{staticSettings.Offices.OffcAcr}]Document Tracking System ({User.GetUserName()}) {item.ControlNo}")
                {
                    Dock = DockStyle.Fill
                });
                tabFiles.Controls.Clear();
                tabFiles.Controls.Add(new UCFiles(item.Id)
                {
                    Dock = DockStyle.Fill
                });
                var row = DocumentGridView.LocateByValue("Id", item.Id);
                this.DocumentGridView.FocusedRowHandle = row;
                this.DocumentGridView.MakeRowVisible(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DocumentGridView_GotFocus(object sender, EventArgs e)
        {

        }

        private async void UCPAPsManager_Load(object sender, EventArgs e)
        {

        }

        private void btnNewInc_Click(object sender, EventArgs e)
        {

            frmAddEditPAPsManager frm = new frmAddEditPAPsManager(MethodType.Add, new Documents()
            {
                CommunicationType = "Incoming"
            });

            frm.ShowDialog();
            this.Init();
        }

        private void btnNewOut_Click(object sender, EventArgs e)
        {
            frmAddEditPAPsManager frm = new frmAddEditPAPsManager(MethodType.Add, new Documents()
            {
                CommunicationType = "Outgoing"
            });

            frm.ShowDialog();
            this.Init();
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.DocumentGridView.GetFocusedRow() is Documents item)
            {
                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                    UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                    unitOfWork.DocumentsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    this.Init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.DocumentGridView.GetFocusedRow() is Documents item)
            {
                frmAddEditPAPsManager frm = new frmAddEditPAPsManager(MethodType.Edit, item);
                frm.ShowDialog(this);

                this.Init();
                Details(item);
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (this.DocumentGridView.GetFocusedRow() is Documents item)
            {
                frmDocActions frm = new frmDocActions(MethodType.Add, new DocumentActions()
                {
                    ControlNo = item.ControlNo,
                    RefId = item.Id,
                    TableName = "Documents",

                });
                frm.ShowDialog();
                Details(item);
                Init();
            }
        }

        private void DocumentGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (this.DocumentGridView.GetRow(e.FocusedRowHandle) is Documents item)
            {
                Details(item);
            }
        }

        private void btnLetter_Click(object sender, EventArgs e)
        {
            this.xtraTabControl1.SelectedTabPageIndex = 1;
            if (tabLetter.Controls[0] is UcLetters letters)
            {
                letters.btnNewLetter.PerformClick();
            }

        }
    }
}
