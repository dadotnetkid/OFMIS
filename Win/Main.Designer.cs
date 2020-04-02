namespace Win
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lblUsername = new DevExpress.XtraBars.BarHeaderItem();
            this.lblUserLevel = new DevExpress.XtraBars.BarHeaderItem();
            this.btnObligation = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.btnYear = new DevExpress.XtraBars.BarButtonItem();
            this.btnDefaultSettings = new DevExpress.XtraBars.BarButtonItem();
            this.btnSignatories = new DevExpress.XtraBars.BarButtonItem();
            this.btnORReports = new DevExpress.XtraBars.BarButtonItem();
            this.btnDetailedobligationRequest = new DevExpress.XtraBars.BarButtonItem();
            this.btnAOBReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnItems = new DevExpress.XtraBars.BarButtonItem();
            this.btnPR = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserlevel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPayees = new DevExpress.XtraBars.BarButtonItem();
            this.btnDefaultAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.lblUsername,
            this.lblUserLevel,
            this.btnObligation,
            this.btnAccounts,
            this.btnYear,
            this.btnDefaultSettings,
            this.btnSignatories,
            this.btnORReports,
            this.btnDetailedobligationRequest,
            this.btnAOBReport,
            this.btnItems,
            this.btnPR,
            this.btnUsers,
            this.btnUserlevel,
            this.btnPayees,
            this.btnDefaultAccounts});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(981, 154);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // lblUsername
            // 
            this.lblUsername.Caption = "Name: Mark Christopher Cacal";
            this.lblUsername.Id = 3;
            this.lblUsername.Name = "lblUsername";
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.Caption = "User Level: Administrator";
            this.lblUserLevel.Id = 4;
            this.lblUserLevel.Name = "lblUserLevel";
            // 
            // btnObligation
            // 
            this.btnObligation.Caption = "Add/Edit Obligation";
            this.btnObligation.Id = 5;
            this.btnObligation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnObligation.ImageOptions.Image")));
            this.btnObligation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnObligation.ImageOptions.LargeImage")));
            this.btnObligation.Name = "btnObligation";
            this.btnObligation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObligation_ItemClick);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Caption = "Accounts";
            this.btnAccounts.Id = 6;
            this.btnAccounts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAccounts.ImageOptions.Image")));
            this.btnAccounts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAccounts.ImageOptions.LargeImage")));
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccounts_ItemClick);
            // 
            // btnYear
            // 
            this.btnYear.Caption = "Years";
            this.btnYear.Id = 1;
            this.btnYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYear.ImageOptions.Image")));
            this.btnYear.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYear.ImageOptions.LargeImage")));
            this.btnYear.Name = "btnYear";
            this.btnYear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYear_ItemClick);
            // 
            // btnDefaultSettings
            // 
            this.btnDefaultSettings.Caption = "Default Settings";
            this.btnDefaultSettings.Id = 2;
            this.btnDefaultSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDefaultSettings.ImageOptions.Image")));
            this.btnDefaultSettings.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDefaultSettings.ImageOptions.LargeImage")));
            this.btnDefaultSettings.Name = "btnDefaultSettings";
            this.btnDefaultSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDefaultSettings_ItemClick);
            // 
            // btnSignatories
            // 
            this.btnSignatories.Caption = "Chief of Offices";
            this.btnSignatories.Id = 3;
            this.btnSignatories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSignatories.ImageOptions.Image")));
            this.btnSignatories.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSignatories.ImageOptions.LargeImage")));
            this.btnSignatories.Name = "btnSignatories";
            this.btnSignatories.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSignatories_ItemClick);
            // 
            // btnORReports
            // 
            this.btnORReports.Caption = "Obligation Requests";
            this.btnORReports.Id = 4;
            this.btnORReports.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnORReports.ImageOptions.Image")));
            this.btnORReports.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnORReports.ImageOptions.LargeImage")));
            this.btnORReports.Name = "btnORReports";
            this.btnORReports.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnORReports_ItemClick);
            // 
            // btnDetailedobligationRequest
            // 
            this.btnDetailedobligationRequest.Caption = "Detailed obligation Requests";
            this.btnDetailedobligationRequest.Id = 5;
            this.btnDetailedobligationRequest.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailedobligationRequest.ImageOptions.Image")));
            this.btnDetailedobligationRequest.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDetailedobligationRequest.ImageOptions.LargeImage")));
            this.btnDetailedobligationRequest.Name = "btnDetailedobligationRequest";
            this.btnDetailedobligationRequest.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDetailedobligationRequest_ItemClick);
            // 
            // btnAOBReport
            // 
            this.btnAOBReport.Caption = "AOB Report";
            this.btnAOBReport.Id = 6;
            this.btnAOBReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAOBReport.ImageOptions.Image")));
            this.btnAOBReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAOBReport.ImageOptions.LargeImage")));
            this.btnAOBReport.Name = "btnAOBReport";
            this.btnAOBReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAOBReport_ItemClick);
            // 
            // btnItems
            // 
            this.btnItems.Caption = "Items";
            this.btnItems.Id = 7;
            this.btnItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItems.ImageOptions.Image")));
            this.btnItems.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnItems.ImageOptions.LargeImage")));
            this.btnItems.Name = "btnItems";
            this.btnItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnItems_ItemClick);
            // 
            // btnPR
            // 
            this.btnPR.Caption = "Purchase Requests";
            this.btnPR.Id = 8;
            this.btnPR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPR.ImageOptions.Image")));
            this.btnPR.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPR.ImageOptions.LargeImage")));
            this.btnPR.Name = "btnPR";
            this.btnPR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPR_ItemClick);
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Users";
            this.btnUsers.Id = 9;
            this.btnUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.Image")));
            this.btnUsers.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsers.ImageOptions.LargeImage")));
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsers_ItemClick);
            // 
            // btnUserlevel
            // 
            this.btnUserlevel.Caption = "User Level";
            this.btnUserlevel.Id = 10;
            this.btnUserlevel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUserlevel.ImageOptions.Image")));
            this.btnUserlevel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUserlevel.ImageOptions.LargeImage")));
            this.btnUserlevel.Name = "btnUserlevel";
            this.btnUserlevel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserlevel_ItemClick);
            // 
            // btnPayees
            // 
            this.btnPayees.Caption = "Payees";
            this.btnPayees.Id = 11;
            this.btnPayees.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPayees.ImageOptions.Image")));
            this.btnPayees.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPayees.ImageOptions.LargeImage")));
            this.btnPayees.Name = "btnPayees";
            this.btnPayees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPayees_ItemClick);
            // 
            // btnDefaultAccounts
            // 
            this.btnDefaultAccounts.Caption = "Default Accounts";
            this.btnDefaultAccounts.Id = 12;
            this.btnDefaultAccounts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDefaultAccounts.ImageOptions.Image")));
            this.btnDefaultAccounts.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDefaultAccounts.ImageOptions.LargeImage")));
            this.btnDefaultAccounts.Name = "btnDefaultAccounts";
            this.btnDefaultAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDefaultAccounts_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.lblUsername);
            this.ribbonPageGroup1.ItemLinks.Add(this.lblUserLevel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Current User";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnObligation);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAccounts);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Manage Funds";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnPR);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnItems);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Purchase Request";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPayees);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnYear);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDefaultSettings);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSignatories);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDefaultAccounts);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Options";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Reports";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnORReports);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDetailedobligationRequest);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAOBReport);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Maintenance";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnUserlevel);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 645);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(981, 22);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 154);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(981, 491);
            this.pnlMain.TabIndex = 4;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 667);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "OFMIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarHeaderItem lblUsername;
        private DevExpress.XtraBars.BarHeaderItem lblUserLevel;
        private DevExpress.XtraBars.BarButtonItem btnObligation;
        private DevExpress.XtraBars.BarButtonItem btnAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraBars.BarButtonItem btnYear;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDefaultSettings;
        private DevExpress.XtraBars.BarButtonItem btnSignatories;
        private DevExpress.XtraBars.BarButtonItem btnORReports;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDetailedobligationRequest;
        private DevExpress.XtraBars.BarButtonItem btnAOBReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnItems;
        private DevExpress.XtraBars.BarButtonItem btnPR;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnUserlevel;
        private DevExpress.XtraBars.BarButtonItem btnPayees;
        private DevExpress.XtraBars.BarButtonItem btnDefaultAccounts;
    }
}

