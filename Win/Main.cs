﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.ToastNotifications;
using Helpers;
using Models.Repository;
using Win.Accnts;
using Win.Actns;
using Win.BGMembers;
using Win.BL;
using Win.Emps;
using Win.Ltr;
using Win.OB;
using Win.Ofcs;
using Win.PR;
using Win.Pyee;
using Win.Rprts;
using Win.TB;
using Win.Tmplts;
using Win.Usr;

namespace Win
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private string[] param;

        public Main(string[] param)
        {
            new frmSplashScreen().ShowDialog(this);
            InitializeComponent();
            this.param = param;
            if (param.Any())
                Impersonate(param);
            else
                Init();
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        void Impersonate(string[] param)
        {
            User.UserId = param[0];
            lblUsername.Caption = $"Name: {User.GetFullName() }";
            lblUserLevel.Caption = $"User Level: {User.GetUserLevel()}";
            var unitOfWork = new UnitOfWork();
            if (!unitOfWork.YearsRepo.Fetch().Any(x => x.IsActive == true))
            {
                MessageBox.Show("No Default Year Selected", "Default Year", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                var frm = new frmYears();
                frm.ShowDialog();
            }
        }
        void Init(bool isLogged = false)
        {
            Form frm = new frmLogin();
            if (isLogged == false)
                frm.ShowDialog();
            lblUsername.Caption = $"Name: {User.GetFullName() }";
            lblUserLevel.Caption = $"User Level: {User.GetUserLevel()}";
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCDashboard() { Dock = DockStyle.Fill });
            var unitOfWork = new UnitOfWork();
            if (!unitOfWork.YearsRepo.Fetch().Any(x => x.IsActive == true))
            {
                MessageBox.Show("No Default Year Selected", "Default Year", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frm = new frmYears();
                frm.ShowDialog();
            }
        }
        private void btnObligation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Obligations"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new ucObligations() { Dock = DockStyle.Fill });

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Accounts"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UcAccounts() { Dock = DockStyle.Fill });
        }

        private void btnYear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Years"))
                return;
            frmYears frm = new frmYears();
            frm.ShowDialog();
        }

        private void btnDefaultSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Years"))
                return;
            frmDefaultSettings frm = new frmDefaultSettings();
            frm.ShowDialog();
        }

        private void btnSignatories_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Signatories"))
                return;
            frmSignatories frm = new frmSignatories();
            frm.ShowDialog();
        }

        private void btnORReports_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("OB Reports"))
                return;
            frmObligationRequestReportViewer frm = new frmObligationRequestReportViewer();
            frm.ShowDialog();
        }

        private void btnDetailedobligationRequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("OB Detailed Reports"))
                return;
            frmDetailedObligationRequestReportViewer frm = new frmDetailedObligationRequestReportViewer();
            frm.ShowDialog();
        }

        private void btnAOBReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("AOB Report"))
                return;
            frmAOBReportViewer frm = new frmAOBReportViewer();
            frm.ShowDialog();
        }

        private void btnItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Items"))
                return;

            frmItems frm = new frmItems();
            frm.ShowDialog();
        }

        private void btnPR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Purchase Requests"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPurchaseRequest() { Dock = DockStyle.Fill });
        }

        private void btnUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Users"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCUsers() { Dock = DockStyle.Fill });
        }

        private void btnUserlevel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("User Level"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCUserLevels() { Dock = DockStyle.Fill });
        }

        private void btnPayees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Payees"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCPayees() { Dock = DockStyle.Fill });
        }

        private void btnDefaultAccounts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Default Accounts"))
                return;
            frmDefaultAccounts frm = new frmDefaultAccounts();
            frm.ShowDialog();
        }



        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

            if (MessageBox.Show("Do you want to close this application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            backstageViewControl1.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            Init(true);
        }

        private void btnOffices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Offices"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCOffices() { Dock = DockStyle.Fill });
        }

        private void btnEmployees_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Employees"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCEmployees() { Dock = DockStyle.Fill });
        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                if (this.pnlMain.Controls.Count > 0)
                {
                    var uc = this.pnlMain.Controls[0] as IUserControl;
                    uc.Refresh();
                }

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnBACMembers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("BAC Members"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UCBACMembers() { Dock = DockStyle.Fill });
        }

        private void btnTemplates_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Templates"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new UcTemplates() { Dock = DockStyle.Fill });
        }

        private void btnLetter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (!User.UserInAction("Letter"))
            //    return;
            //pnlMain.Controls.Clear();
            //pnlMain.Controls.Add(new UcLetters() { Dock = DockStyle.Fill });
        }

        private void btnLAR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLARReportViewer frm = new frmLARReportViewer();
            frm.Show();
        }

        private void btnActionTree_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Action Tree"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new Actns.UCActions() { Dock = DockStyle.Fill });
        }

        private void btnRecipientLists_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Recipient Lists"))
                return;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(new Pyee.UCRecipients() { Dock = DockStyle.Fill });
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool updateNow = true;
            while (updateNow)
            {
                Thread.Sleep(1000);
                if (UpdateHelpers.InstallUpdateSyncWithInfo())
                {
                    this.Invoke(new Action(() =>
                    {
                        updateNow = false;
                        lblTime.Caption = @"OFMIS: Update available(the system is updating)";
                        UpdateHelpers.applicationDeployment.UpdateCompleted += (se, ev) =>
                        {
                            new frmUpdateNotification().ShowDialog(this);
                        };
                        UpdateHelpers.applicationDeployment.UpdateProgressChanged += (se, ev) =>
                        {
                            lblTime.Caption = $@"OFMIS: Update available(the system is updating) {ev.ProgressPercentage}%";
                        };
                        UpdateHelpers.applicationDeployment.UpdateAsync();


                    }));

                }
            }
        }

        private void btnDashboard_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(new UCDashboard()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnAccomplishmentReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAccomplishmentReport frm = new frmAccomplishmentReport();
            frm.ShowDialog();
        }

        private void btnTrashbin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pnlMain.Controls.Clear();
            this.pnlMain.Controls.Add(new UCTrashbin()
            {
                Dock = DockStyle.Fill
            });
        }
    }
}
