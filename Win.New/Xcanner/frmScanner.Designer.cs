namespace Win.Xcanner
{
    partial class frmScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScanner));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pctScanImage = new DevExpress.XtraEditors.PictureEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.memoExEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.btnTestFileServer = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctScanImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 230);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Description";
            // 
            // pctScanImage
            // 
            this.pctScanImage.Location = new System.Drawing.Point(12, 12);
            this.pctScanImage.Name = "pctScanImage";
            this.pctScanImage.Properties.AllowScrollViaMouseDrag = true;
            this.pctScanImage.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.pctScanImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctScanImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pctScanImage.Properties.ZoomAcceleration = 2D;
            this.pctScanImage.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.ControlMouseWheel;
            this.pctScanImage.Size = new System.Drawing.Size(392, 211);
            this.pctScanImage.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.Location = new System.Drawing.Point(301, 385);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(103, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnScan
            // 
            this.btnScan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnScan.Location = new System.Drawing.Point(192, 385);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(103, 23);
            this.btnScan.TabIndex = 5;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // memoExEdit1
            // 
            this.memoExEdit1.Location = new System.Drawing.Point(13, 249);
            this.memoExEdit1.Name = "memoExEdit1";
            this.memoExEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoExEdit1.Size = new System.Drawing.Size(391, 130);
            this.memoExEdit1.TabIndex = 7;
            // 
            // btnTestFileServer
            // 
            this.btnTestFileServer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTestFileServer.Location = new System.Drawing.Point(83, 385);
            this.btnTestFileServer.Name = "btnTestFileServer";
            this.btnTestFileServer.Size = new System.Drawing.Size(103, 23);
            this.btnTestFileServer.TabIndex = 5;
            this.btnTestFileServer.Text = "Test File Server";
            this.btnTestFileServer.Click += new System.EventHandler(this.btnTestFileServer_Click);
            // 
            // frmScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 423);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pctScanImage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnTestFileServer);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.memoExEdit1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.pctScanImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoExEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.PictureEdit pctScanImage;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private DevExpress.XtraEditors.MemoEdit memoExEdit1;
        private DevExpress.XtraEditors.SimpleButton btnTestFileServer;
    }
}