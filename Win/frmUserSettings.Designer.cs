namespace Win
{
    partial class frmUserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserSettings));
            this.cboYear = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.yearsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboYear
            // 
            this.cboYear.Location = new System.Drawing.Point(12, 32);
            this.cboYear.Name = "cboYear";
            this.cboYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboYear.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Year", "Year", 31, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboYear.Properties.DataSource = this.yearsBindingSource;
            this.cboYear.Properties.DisplayMember = "Year";
            this.cboYear.Properties.NullText = "";
            this.cboYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboYear.Properties.ValueMember = "Year";
            this.cboYear.Size = new System.Drawing.Size(273, 20);
            this.cboYear.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Year";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPO.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(210, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 8;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // yearsBindingSource
            // 
            this.yearsBindingSource.DataSource = typeof(Models.Years);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 59);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Set Default Year";
            this.checkEdit1.Size = new System.Drawing.Size(138, 18);
            this.checkEdit1.TabIndex = 9;
            // 
            // frmUserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 91);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cboYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Setting";
            ((System.ComponentModel.ISupportInitialize)(this.cboYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit cboYear;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource yearsBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}