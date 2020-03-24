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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnAccounts});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(981, 154);
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
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
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
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 154);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(981, 513);
            this.pnlMain.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 667);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl1;
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
        private DevExpress.XtraEditors.PanelControl pnlMain;
    }
}

