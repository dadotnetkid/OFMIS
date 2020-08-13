namespace Win.OB
{
    partial class frmAddEditPayee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPayee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtOffice = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.LookUpEdit();
            this.cboMembers = new DevExpress.XtraEditors.TextEdit();
            this.btnMembers = new DevExpress.XtraEditors.SimpleButton();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMembers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 54);
            this.panel1.TabIndex = 29;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Location = new System.Drawing.Point(97, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 27);
            this.lblHeader.TabIndex = 12;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(12, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(78, 52);
            this.pictureEdit1.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.EnterMoveNextControl = true;
            this.txtAddress.Location = new System.Drawing.Point(77, 105);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.UseReadOnlyAppearance = false;
            this.txtAddress.Size = new System.Drawing.Size(397, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Tag = "Address is Required";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 107);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 13);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "Address";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Office";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "Name";
            // 
            // txtNote
            // 
            this.txtNote.EnterMoveNextControl = true;
            this.txtNote.Location = new System.Drawing.Point(77, 127);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(397, 96);
            this.txtNote.TabIndex = 3;
            this.txtNote.Tag = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Note";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(369, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(262, 251);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOffice
            // 
            this.txtOffice.EnterMoveNextControl = true;
            this.txtOffice.Location = new System.Drawing.Point(77, 83);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtOffice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "Office Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address")});
            this.txtOffice.Properties.DataSource = this.officesBindingSource;
            this.txtOffice.Properties.DisplayMember = "OffcAcr";
            this.txtOffice.Properties.NullText = "";
            this.txtOffice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtOffice.Properties.UseReadOnlyAppearance = false;
            this.txtOffice.Properties.ValueMember = "OfficeName";
            this.txtOffice.Size = new System.Drawing.Size(397, 20);
            this.txtOffice.TabIndex = 1;
            this.txtOffice.Tag = "";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "Members";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 61);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.txtName.Properties.DisplayMember = "Name";
            this.txtName.Properties.NullText = "";
            this.txtName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtName.Properties.UseReadOnlyAppearance = false;
            this.txtName.Properties.ValueMember = "Name";
            this.txtName.Size = new System.Drawing.Size(398, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Tag = "Name is Required";
            // 
            // cboMembers
            // 
            this.cboMembers.Location = new System.Drawing.Point(77, 225);
            this.cboMembers.Name = "cboMembers";
            this.cboMembers.Properties.ReadOnly = true;
            this.cboMembers.Size = new System.Drawing.Size(379, 20);
            this.cboMembers.TabIndex = 4;
            this.cboMembers.Tag = "";
            // 
            // btnMembers
            // 
            this.btnMembers.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembers.Appearance.Options.UseFont = true;
            this.btnMembers.AutoWidthInLayoutControl = true;
            this.btnMembers.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnMembers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMembers.ImageOptions.Image")));
            this.btnMembers.Location = new System.Drawing.Point(456, 224);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(20, 22);
            this.btnMembers.TabIndex = 36;
            this.btnMembers.Click += new System.EventHandler(this.btnMembers_Click);
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataSource = typeof(Models.Offices);
            // 
            // frmAddEditPayee
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 292);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEditPayee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Payee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditPayee_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditPayee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMembers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.MemoEdit txtNote;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.LookUpEdit txtOffice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LookUpEdit txtName;
        public DevExpress.XtraEditors.TextEdit cboMembers;
        private DevExpress.XtraEditors.SimpleButton btnMembers;
        private System.Windows.Forms.BindingSource officesBindingSource;
    }
}