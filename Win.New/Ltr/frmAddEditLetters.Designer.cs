namespace Win.Ltr
{
    partial class frmAddEditLetterV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditLetterV2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboLetterType = new DevExpress.XtraEditors.LookUpEdit();
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.lettersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTemplate = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboOffice = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboSalutation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboClosing = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.memoCC = new DevExpress.XtraEditors.MemoEdit();
            this.chkForInTheAbsence = new DevExpress.XtraEditors.CheckEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.letterViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLetterType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTemplate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSalutation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClosing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkForInTheAbsence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterViewModelBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1228, 54);
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
            this.lblHeader.Size = new System.Drawing.Size(161, 27);
            this.lblHeader.TabIndex = 9999;
            this.lblHeader.Text = "Add Edit Letter";
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
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 10001;
            this.labelControl3.Text = "Type";
            // 
            // cboLetterType
            // 
            this.cboLetterType.EnterMoveNextControl = true;
            this.cboLetterType.Location = new System.Drawing.Point(59, 59);
            this.cboLetterType.Name = "cboLetterType";
            this.cboLetterType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLetterType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Type")});
            this.cboLetterType.Properties.DisplayMember = "Type";
            this.cboLetterType.Properties.NullText = "";
            this.cboLetterType.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboLetterType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboLetterType.Properties.UseReadOnlyAppearance = false;
            this.cboLetterType.Properties.ValueMember = "Type";
            this.cboLetterType.Size = new System.Drawing.Size(181, 20);
            this.cboLetterType.TabIndex = 10000;
            this.cboLetterType.Tag = "Payee is Required";
            this.cboLetterType.EditValueChanged += new System.EventHandler(this.cboLetterType_EditValueChanged);
            // 
            // richEditControl1
            // 
            this.richEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richEditControl1.Location = new System.Drawing.Point(13, 137);
            this.richEditControl1.MenuManager = this.barManager1;
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.MailMerge.DataSource = this.letterViewModelBindingSource;
            this.richEditControl1.Options.MailMerge.ViewMergedData = true;
            this.richEditControl1.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            this.richEditControl1.Size = new System.Drawing.Size(1203, 429);
            this.richEditControl1.TabIndex = 10002;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 22;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1228, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 617);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1228, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 617);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1228, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 617);
            // 
            // lettersBindingSource
            // 
            this.lettersBindingSource.DataSource = typeof(Models.Letters);
            // 
            // cboTemplate
            // 
            this.cboTemplate.EnterMoveNextControl = true;
            this.cboTemplate.Location = new System.Drawing.Point(59, 85);
            this.cboTemplate.Name = "cboTemplate";
            this.cboTemplate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTemplate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Type"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.cboTemplate.Properties.DisplayMember = "Name";
            this.cboTemplate.Properties.NullText = "";
            this.cboTemplate.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboTemplate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTemplate.Properties.UseReadOnlyAppearance = false;
            this.cboTemplate.Properties.ValueMember = "Id";
            this.cboTemplate.Size = new System.Drawing.Size(181, 20);
            this.cboTemplate.TabIndex = 10000;
            this.cboTemplate.Tag = "Payee is Required";
            this.cboTemplate.EditValueChanged += new System.EventHandler(this.cboTemplate_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 10001;
            this.labelControl1.Text = "Template";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(246, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 10001;
            this.labelControl2.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(292, 59);
            this.dtDate.MenuManager = this.barManager1;
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Size = new System.Drawing.Size(168, 20);
            this.dtDate.TabIndex = 10007;
            this.dtDate.EditValueChanged += new System.EventHandler(this.dtDate_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(246, 88);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 10001;
            this.labelControl4.Text = "Office";
            // 
            // cboOffice
            // 
            this.cboOffice.EnterMoveNextControl = true;
            this.cboOffice.Location = new System.Drawing.Point(292, 85);
            this.cboOffice.Name = "cboOffice";
            this.cboOffice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOffice.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeName", "OfficeName")});
            this.cboOffice.Properties.DisplayMember = "OfficeName";
            this.cboOffice.Properties.NullText = "";
            this.cboOffice.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboOffice.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboOffice.Properties.UseReadOnlyAppearance = false;
            this.cboOffice.Properties.ValueMember = "Id";
            this.cboOffice.Size = new System.Drawing.Size(168, 20);
            this.cboOffice.TabIndex = 10000;
            this.cboOffice.Tag = "Payee is Required";
            this.cboOffice.EditValueChanged += new System.EventHandler(this.cboOffice_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 10001;
            this.labelControl5.Text = "Salution";
            // 
            // cboSalutation
            // 
            this.cboSalutation.Location = new System.Drawing.Point(59, 111);
            this.cboSalutation.Name = "cboSalutation";
            this.cboSalutation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSalutation.Properties.Items.AddRange(new object[] {
            "Madam",
            "Sir"});
            this.cboSalutation.Properties.PopupSizeable = true;
            this.cboSalutation.Properties.UseReadOnlyAppearance = false;
            this.cboSalutation.Size = new System.Drawing.Size(181, 20);
            this.cboSalutation.TabIndex = 10000;
            this.cboSalutation.Tag = "Payee is Required";
            this.cboSalutation.SelectedIndexChanged += new System.EventHandler(this.cboSalutation_SelectedIndexChanged);
            this.cboSalutation.EditValueChanged += new System.EventHandler(this.cboTemplate_EditValueChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(246, 114);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(39, 13);
            this.labelControl6.TabIndex = 10001;
            this.labelControl6.Text = "Closing";
            // 
            // cboClosing
            // 
            this.cboClosing.Location = new System.Drawing.Point(292, 111);
            this.cboClosing.Name = "cboClosing";
            this.cboClosing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClosing.Properties.Items.AddRange(new object[] {
            "Sincerely yours,",
            "Respectfully yours,",
            "Truly yours,",
            "Very truly yours,"});
            this.cboClosing.Properties.PopupSizeable = true;
            this.cboClosing.Properties.UseReadOnlyAppearance = false;
            this.cboClosing.Size = new System.Drawing.Size(168, 20);
            this.cboClosing.TabIndex = 10000;
            this.cboClosing.Tag = "Payee is Required";
            this.cboClosing.SelectedIndexChanged += new System.EventHandler(this.cboClosing_SelectedIndexChanged);
            this.cboClosing.EditValueChanged += new System.EventHandler(this.cboOffice_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(475, 62);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 13);
            this.labelControl7.TabIndex = 10001;
            this.labelControl7.Text = "CC";
            // 
            // memoCC
            // 
            this.memoCC.Location = new System.Drawing.Point(495, 59);
            this.memoCC.Name = "memoCC";
            this.memoCC.Properties.UseReadOnlyAppearance = false;
            this.memoCC.Size = new System.Drawing.Size(330, 42);
            this.memoCC.TabIndex = 10000;
            this.memoCC.Tag = "Payee is Required";
            this.memoCC.EditValueChanged += new System.EventHandler(this.memoCC_EditValueChanged);
            // 
            // chkForInTheAbsence
            // 
            this.chkForInTheAbsence.Location = new System.Drawing.Point(475, 107);
            this.chkForInTheAbsence.MenuManager = this.barManager1;
            this.chkForInTheAbsence.Name = "chkForInTheAbsence";
            this.chkForInTheAbsence.Properties.Caption = "For and in the absence of the PITD";
            this.chkForInTheAbsence.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkForInTheAbsence.Size = new System.Drawing.Size(205, 18);
            this.chkForInTheAbsence.TabIndex = 10012;
            this.chkForInTheAbsence.CheckedChanged += new System.EventHandler(this.chkForInTheAbsence_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1111, 572);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 10018;
            this.btnClose.Text = "&Close";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(1004, 572);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 10017;
            this.btnSave.Text = "Save ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // letterViewModelBindingSource
            // 
            this.letterViewModelBindingSource.DataSource = typeof(Models.ViewModels.LetterViewModel);
            // 
            // frmAddEditLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 617);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkForInTheAbsence);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.richEditControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboOffice);
            this.Controls.Add(this.cboTemplate);
            this.Controls.Add(this.cboLetterType);
            this.Controls.Add(this.cboSalutation);
            this.Controls.Add(this.cboClosing);
            this.Controls.Add(this.memoCC);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditLetters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Letter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddEditLetters_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLetterType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lettersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTemplate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSalutation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClosing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkForInTheAbsence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letterViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LookUpEdit cboLetterType;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LookUpEdit cboTemplate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LookUpEdit cboOffice;
        private System.Windows.Forms.BindingSource lettersBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit cboSalutation;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cboClosing;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit memoCC;
        private DevExpress.XtraEditors.CheckEdit chkForInTheAbsence;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.BindingSource letterViewModelBindingSource;
    }
}