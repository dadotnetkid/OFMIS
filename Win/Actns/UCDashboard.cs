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
                this.documentActionsBindingSource.DataSource = unitOfWork.DocumentActionsRepo.Get(x => x.Users.Any(m => m.Id == User.UserId) && x.IsSend == true && x.isDone !=true);
            }
            catch (Exception e)
            {

            }
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
                    obr.loadObligations.Search(documentActions.ControlNo);
                }
                else
                {
                    Main frm = Application.OpenForms["Main"] as Main;
                    frm.pnlMain.Controls.Clear();
                    var pr = new PR.UCPurchaseRequest() { Dock = DockStyle.Fill };
                    pr.txtSearch.Text = documentActions.ControlNo;
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
    }
}
