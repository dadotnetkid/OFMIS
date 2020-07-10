namespace Win.PPMS
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
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.btnLogout = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.btnClose = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.lblUsername = new DevExpress.XtraBars.BarHeaderItem();
            this.lblUserLevel = new DevExpress.XtraBars.BarHeaderItem();
            this.btnObligation = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbnGrpPR = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.homeOpt = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnItems = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.lblUsername,
            this.lblUserLevel,
            this.btnObligation});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 23;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.Size = new System.Drawing.Size(981, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Items.Add(this.btnLogout);
            this.backstageViewControl1.Items.Add(this.btnClose);
            this.backstageViewControl1.Location = new System.Drawing.Point(77, 231);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.ribbonControl1;
            this.backstageViewControl1.Size = new System.Drawing.Size(480, 229);
            this.backstageViewControl1.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Logout";
            this.btnLogout.ImageOptions.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.ItemNormal.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.btnLogout_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Close";
            this.btnClose.ImageOptions.ItemNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.ItemNormal.Image")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.btnClose_ItemClick);
            // 
            // lblUsername
            // 
            this.lblUsername.Caption = "Name: ";
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
            this.btnObligation.Caption = "Obligation Requests";
            this.btnObligation.Id = 5;
            this.btnObligation.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnObligation.ImageOptions.Image")));
            this.btnObligation.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnObligation.ImageOptions.LargeImage")));
            this.btnObligation.Name = "btnObligation";
            this.btnObligation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnObligation_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.rbnGrpPR,
            this.homeOpt});
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
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Manage Funds";
            // 
            // rbnGrpPR
            // 
            this.rbnGrpPR.Name = "rbnGrpPR";
            // 
            // homeOpt
            // 
            this.homeOpt.Name = "homeOpt";
            this.homeOpt.Text = "Options";
            this.homeOpt.Visible = false;
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
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 636);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(981, 31);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 143);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(981, 493);
            this.pnlMain.TabIndex = 4;
            // 
            // Main
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 667);
            this.Controls.Add(this.backstageViewControl1);
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
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        public DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup homeOpt;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbnGrpPR;
        private DevExpress.XtraBars.BarButtonItem btnItems;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem btnLogout;
    }
}

