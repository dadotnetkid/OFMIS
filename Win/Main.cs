﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Models.Repository;
using Win.Accnts;
using Win.OB;
using Win.PR;
using Win.Pyee;
using Win.Rprts;
using Win.Usr;

namespace Win
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            new frmSplashScreen().ShowDialog();
            InitializeComponent();


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
            Form frm = new frmLogin();
            frm.ShowDialog();
            lblUsername.Caption = $"Name: {User.GetFullName() }";
            lblUserLevel.Caption = $"User Level: {User.GetUserLevel()}";
            var unitOfWork = new UnitOfWork();
            if (!unitOfWork.YearsRepo.Fetch().Any(x => x.IsActive == true))
            {
                MessageBox.Show("No Default Year Selected", "Default Year", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                frm = new frmYears();
                frm.ShowDialog();
            }
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

        private void btnLogout_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            backstageViewControl1.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

            if (MessageBox.Show("Do you want to close this application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }
    }
}
