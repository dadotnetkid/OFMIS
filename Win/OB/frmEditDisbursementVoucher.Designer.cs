namespace Win.OB
{
    partial class frmEditDisbursementVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditDisbursementVoucher));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtOffice = new DevExpress.XtraEditors.TextEdit();
            this.txtControl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtParticulars = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.txtNote = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.cboPayee = new DevExpress.XtraEditors.TextEdit();
            this.cboApprovedBy = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.SpinEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticulars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPayee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboApprovedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(466, 54);
            this.panel1.TabIndex = 30;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Location = new System.Drawing.Point(97, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(143, 27);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Appropriation";
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
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 175);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.ReadOnly = true;
            this.txtDescription.Properties.UseReadOnlyAppearance = false;
            this.txtDescription.Size = new System.Drawing.Size(344, 20);
            this.txtDescription.TabIndex = 5;
            this.txtDescription.Tag = "Description is Required";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(110, 153);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.ReadOnly = true;
            this.txtAddress.Properties.UseReadOnlyAppearance = false;
            this.txtAddress.Size = new System.Drawing.Size(344, 20);
            this.txtAddress.TabIndex = 4;
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(111, 131);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Properties.ReadOnly = true;
            this.txtOffice.Properties.UseReadOnlyAppearance = false;
            this.txtOffice.Size = new System.Drawing.Size(344, 20);
            this.txtOffice.TabIndex = 3;
            // 
            // txtControl
            // 
            this.txtControl.Location = new System.Drawing.Point(110, 83);
            this.txtControl.Name = "txtControl";
            this.txtControl.Properties.ReadOnly = true;
            this.txtControl.Properties.UseReadOnlyAppearance = false;
            this.txtControl.Size = new System.Drawing.Size(344, 20);
            this.txtControl.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 178);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(78, 13);
            this.labelControl6.TabIndex = 48;
            this.labelControl6.Text = "OR Description";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "Address";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 133);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 46;
            this.labelControl4.Text = "Office";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 109);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 45;
            this.labelControl3.Text = "Payee";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 13);
            this.labelControl2.TabIndex = 43;
            this.labelControl2.Text = "Office Control No.";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "Date";
            // 
            // txtParticulars
            // 
            this.txtParticulars.Location = new System.Drawing.Point(111, 199);
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParticulars.Size = new System.Drawing.Size(344, 96);
            this.txtParticulars.TabIndex = 6;
            this.txtParticulars.Tag = "Particulars is Required";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 200);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Particulars";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(8, 322);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(64, 13);
            this.labelControl8.TabIndex = 48;
            this.labelControl8.Text = "Approved By";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(8, 346);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(42, 13);
            this.labelControl9.TabIndex = 48;
            this.labelControl9.Text = "Position";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(8, 370);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(25, 13);
            this.labelControl10.TabIndex = 48;
            this.labelControl10.Text = "Note";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(110, 343);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(344, 20);
            this.txtPosition.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(110, 367);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(344, 20);
            this.txtNote.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(349, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(242, 393);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDate
            // 
            this.txtDate.EditValue = null;
            this.txtDate.Location = new System.Drawing.Point(110, 61);
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.DisplayFormat.FormatString = "";
            this.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.EditFormat.FormatString = "";
            this.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.Mask.EditMask = "";
            this.txtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Properties.UseReadOnlyAppearance = false;
            this.txtDate.Size = new System.Drawing.Size(345, 20);
            this.txtDate.TabIndex = 0;
            // 
            // cboPayee
            // 
            this.cboPayee.Location = new System.Drawing.Point(110, 107);
            this.cboPayee.Name = "cboPayee";
            this.cboPayee.Properties.ReadOnly = true;
            this.cboPayee.Properties.UseReadOnlyAppearance = false;
            this.cboPayee.Size = new System.Drawing.Size(345, 20);
            this.cboPayee.TabIndex = 2;
            // 
            // cboApprovedBy
            // 
            this.cboApprovedBy.Location = new System.Drawing.Point(110, 319);
            this.cboApprovedBy.Name = "cboApprovedBy";
            this.cboApprovedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboApprovedBy.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Person", "Person"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Position", "Position"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Note", "Note")});
            this.cboApprovedBy.Properties.DisplayMember = "Person";
            this.cboApprovedBy.Properties.ImmediatePopup = true;
            this.cboApprovedBy.Properties.NullText = "";
            this.cboApprovedBy.Properties.PopupSizeable = false;
            this.cboApprovedBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboApprovedBy.Properties.ValueMember = "Person";
            this.cboApprovedBy.Size = new System.Drawing.Size(344, 20);
            this.cboApprovedBy.TabIndex = 8;
            this.cboApprovedBy.Tag = "Approved By is Required";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(9, 300);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(41, 13);
            this.labelControl11.TabIndex = 48;
            this.labelControl11.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAmount.Location = new System.Drawing.Point(111, 297);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAmount.Properties.DisplayFormat.FormatString = "#,#.00##";
            this.txtAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAmount.Properties.EditFormat.FormatString = "#,#.00##";
            this.txtAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtAmount.Size = new System.Drawing.Size(344, 20);
            this.txtAmount.TabIndex = 7;
            this.txtAmount.Tag = "Approved By is Required";
            // 
            // frmEditDisbursementVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 435);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtParticulars);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.txtControl);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cboPayee);
            this.Controls.Add(this.cboApprovedBy);
            this.Controls.Add(this.txtAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditDisbursementVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Disbursement Voucher";
            this.Load += new System.EventHandler(this.frmEditDisbursementVoucher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticulars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPayee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboApprovedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public DevExpress.XtraEditors.TextEdit txtDescription;
        public DevExpress.XtraEditors.TextEdit txtAddress;
        public DevExpress.XtraEditors.TextEdit txtOffice;
        public DevExpress.XtraEditors.TextEdit txtControl;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.MemoEdit txtParticulars;
        public DevExpress.XtraEditors.TextEdit txtPosition;
        public DevExpress.XtraEditors.TextEdit txtNote;
        public DevExpress.XtraEditors.DateEdit txtDate;
        public DevExpress.XtraEditors.TextEdit cboPayee;
        public DevExpress.XtraEditors.LookUpEdit cboApprovedBy;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        public DevExpress.XtraEditors.SpinEdit txtAmount;
    }
}