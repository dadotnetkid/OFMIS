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
using Win.OB;

namespace Win.Actns
{
    public partial class UCDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private StaticSettings staticSettings = new StaticSettings();
        public UCDashboard()
        {
            InitializeComponent();
            this.Init();
        }


        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var documents = unitOfWork.DocumentActionsRepo.Get(x => x.RoutedToUsers.Any(m => m.Id == User.UserId) && x.IsSend == true && x.isDone != true);
                this.usersBindingSource.DataSource =
                    unitOfWork.UsersRepo.Get(x => x.OfficeId == staticSettings.OfficeId); this.documentActionsBindingSource.DataSource = documents;
                this.cboUsers.EditValue = User.UserId;
                this.Detail(documents.FirstOrDefault());
            }
            catch (Exception e)
            {

            }
        }

        private void Detail(DocumentActions document)
        {
            if (document == null)
                return;
            this.ActionTakenGridControl.DataSource =
                new UnitOfWork().DocumentActionsRepo.Get(x =>
                    x.RefId == document.RefId && x.TableName == document.TableName, orderBy: x => x.OrderByDescending(m => m.DateCreated));
        }

        private void lblControlNumber_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void lblControlNo_Click(object sender, EventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions documentActions)
            {
                if (documentActions.TableName == "Obligations")
                {
                    Main frm = Application.OpenForms["Main"] as Main;
                    frm.pnlMain.Controls.Clear();
                    var obr = new ucObligations() { Dock = DockStyle.Fill };
                    obr.txtSearch.Text = documentActions.ControlNo;
                    frm.pnlMain.Controls.Add(obr);
                    obr.loadObligations.Search(documentActions.ControlNo, true);
                }
                else
                {
                    Main frm = Application.OpenForms["Main"] as Main;
                    frm.pnlMain.Controls.Clear();



                    var pr = new PR.UCPurchaseRequest(documentActions.ControlNo) { Dock = DockStyle.Fill };
                    //pr.txtSearch.Text = documentActions.ControlNo;
                    pr.loadAddEditPurchaseRequest.Search(documentActions.ControlNo, true);
                    frm.pnlMain.Controls.Add(pr);
                    pr.btnSearch.PerformClick();
                }
            }
        }

        private void btnAddAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions item)
            {
                frmDocActions frm = new frmDocActions(MethodType.Add, new DocumentActions()
                {
                    TableName = item.TableName,
                    ActionDate = DateTime.Now,
                    RefId = item.RefId,
                    CreatedBy = User.UserId,
                    DateCreated = DateTime.Now,
                    ControlNo = item.ControlNo,
                    Year = item.Year
                });
                frm.ShowDialog();
                Init();
            }
        }

        private void btnTaskDone_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions item)
            {
                frmTaskDone frm = new frmTaskDone(item);
                frm.ShowDialog();
                Init();
            }
        }

        private void DashboardGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (DashboardGridView.GetFocusedRow() is DocumentActions item)
            {
                Detail(item);
            }
        }

        private void cboUsers_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        void Search()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var documents = unitOfWork.DocumentActionsRepo.Fetch(x => x.RoutedToUsers.Any(m => m.Id == User.UserId) && x.IsSend == true && x.isDone != true);
                if (cboUsers.EditValue != null)
                {
                    var user = cboUsers.EditValue.ToString();
                    documents = documents.Where(x => x.RoutedToUsers.Any(m => m.Id == user));

                }

                if (dtFrom.EditValue != null && dtTo.EditValue != null)
                {
                    var dateTo = dtTo.DateTime.AddHours(11).AddMinutes(59).AddSeconds(59);
                    documents = documents.Where(x => x.ActionDate >= dtFrom.DateTime && x.ActionDate <= dateTo);

                }
                this.documentActionsBindingSource.DataSource = documents.ToList();
                this.Detail(documents.FirstOrDefault());
            }
            catch (Exception e)
            {

            }
        }

        private void dtTo_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
