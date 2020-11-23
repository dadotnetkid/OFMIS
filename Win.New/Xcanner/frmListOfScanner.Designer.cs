namespace Win.Xcanner
{
    partial class frmListOfScanner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfScanner));
            this.cboScanner = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.scannerViewModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cboScanner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerViewModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cboScanner
            // 
            this.cboScanner.Location = new System.Drawing.Point(11, 12);
            this.cboScanner.Name = "cboScanner";
            this.cboScanner.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboScanner.Properties.Appearance.Options.UseFont = true;
            this.cboScanner.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboScanner.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ScannerName", "Scanner Name", 112, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboScanner.Properties.DataSource = this.scannerViewModelsBindingSource;
            this.cboScanner.Properties.DisplayMember = "ScannerName";
            this.cboScanner.Properties.NullText = "";
            this.cboScanner.Properties.ValueMember = "Id";
            this.cboScanner.Size = new System.Drawing.Size(392, 28);
            this.cboScanner.TabIndex = 4;
            // 
            // btnSelect
            // 
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSelect.Location = new System.Drawing.Point(304, 46);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(99, 29);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // scannerViewModelsBindingSource
            // 
            this.scannerViewModelsBindingSource.DataSource = typeof(Models.ViewModels.ScannerViewModels);
            // 
            // frmListOfScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 85);
            this.Controls.Add(this.cboScanner);
            this.Controls.Add(this.btnSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListOfScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Devices";
            this.Load += new System.EventHandler(this.frmListOfScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboScanner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scannerViewModelsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cboScanner;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private System.Windows.Forms.BindingSource scannerViewModelsBindingSource;
    }
}