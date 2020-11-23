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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboOffice = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOffcAcr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChief = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtSalutation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboTemplates = new DevExpress.XtraEditors.LookUpEdit();
            this.templatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBody = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboClosing = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSignatories = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtPosition = new DevExpress.XtraEditors.TextEdit();
            this.chkAbsence = new DevExpress.XtraEditors.CheckEdit();
            this.txtCC = new DevExpress.XtraEditors.MemoEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtInsideAddress = new DevExpress.XtraRichEdit.RichEditControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnAddTable = new DevExpress.XtraEditors.SimpleButton();
            this.btnBold = new DevExpress.XtraEditors.SimpleButton();
            this.btnItalic = new DevExpress.XtraEditors.SimpleButton();
            this.btnUnderline = new DevExpress.XtraEditors.SimpleButton();
            this.btnIncFont = new DevExpress.XtraEditors.SimpleButton();
            this.btnDecFont = new DevExpress.XtraEditors.SimpleButton();
            this.fntTextfont = new DevExpress.XtraEditors.FontEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalutation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTemplates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClosing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSignatories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAbsence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fntTextfont.Properties)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1164, 24);
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
            this.lblHeader.Size = new System.Drawing.Size(209, 27);
            this.lblHeader.TabIndex = 9999;
            this.lblHeader.Text = "Add Edit Document";
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(97, 60);
            this.cboType.Name = "cboType";
            this.cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboType.Properties.Items.AddRange(new object[] {
            "Letter",
            "Endorsement",
            "Certification",
            "Plain"});
            this.cboType.Size = new System.Drawing.Size(319, 20);
            this.cboType.TabIndex = 35;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(97, 81);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(319, 20);
            this.txtTitle.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Inside Address";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(422, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Date/Time";
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(491, 60);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Size = new System.Drawing.Size(236, 20);
            this.dtDate.TabIndex = 38;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(422, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Office";
            // 
            // cboOffice
            // 
            this.cboOffice.Location = new System.Drawing.Point(491, 81);
            this.cboOffice.Name = "cboOffice";
            this.cboOffice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOffice.Properties.DataSource = this.officesBindingSource;
            this.cboOffice.Properties.DisplayMember = "OfficeName";
            this.cboOffice.Properties.NullText = "";
            this.cboOffice.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboOffice.Properties.ValueMember = "Id";
            this.cboOffice.Size = new System.Drawing.Size(236, 20);
            this.cboOffice.TabIndex = 39;
            this.cboOffice.EditValueChanged += new System.EventHandler(this.cboOffice_EditValueChanged);
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataSource = typeof(Models.Offices);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOffcAcr,
            this.colChief});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colOffcAcr
            // 
            this.colOffcAcr.FieldName = "OffcAcr";
            this.colOffcAcr.Name = "colOffcAcr";
            this.colOffcAcr.Visible = true;
            this.colOffcAcr.VisibleIndex = 0;
            // 
            // colChief
            // 
            this.colChief.FieldName = "Chief";
            this.colChief.Name = "colChief";
            this.colChief.Visible = true;
            this.colChief.VisibleIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 84);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Title";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 206);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 13);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Salutation";
            // 
            // dtSalutation
            // 
            this.dtSalutation.EditValue = "Sir:";
            this.dtSalutation.Location = new System.Drawing.Point(97, 203);
            this.dtSalutation.Name = "dtSalutation";
            this.dtSalutation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSalutation.Properties.Items.AddRange(new object[] {
            "Sir:",
            "Madam:"});
            this.dtSalutation.Size = new System.Drawing.Size(319, 20);
            this.dtSalutation.TabIndex = 41;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 227);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Template";
            // 
            // cboTemplates
            // 
            this.cboTemplates.Location = new System.Drawing.Point(97, 224);
            this.cboTemplates.Name = "cboTemplates";
            this.cboTemplates.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTemplates.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 39, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Type", "Type", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboTemplates.Properties.DataSource = this.templatesBindingSource;
            this.cboTemplates.Properties.DisplayMember = "Name";
            this.cboTemplates.Properties.NullText = "";
            this.cboTemplates.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboTemplates.Properties.ValueMember = "Name";
            this.cboTemplates.Size = new System.Drawing.Size(319, 20);
            this.cboTemplates.TabIndex = 42;
            this.cboTemplates.EditValueChanged += new System.EventHandler(this.cboTemplates_EditValueChanged);
            // 
            // templatesBindingSource
            // 
            this.templatesBindingSource.DataSource = typeof(Models.Templates);
            // 
            // txtBody
            // 
            this.txtBody.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtBody.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtBody.Location = new System.Drawing.Point(97, 270);
            this.txtBody.Name = "txtBody";
            this.txtBody.Options.AutoCorrect.UseSpellCheckerSuggestions = true;
            this.txtBody.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtBody.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.txtBody.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtBody.Size = new System.Drawing.Size(1055, 267);
            this.txtBody.TabIndex = 43;
            this.txtBody.Views.DraftView.Padding = new System.Windows.Forms.Padding(0);
            this.txtBody.Views.SimpleView.Padding = new System.Windows.Forms.Padding(0);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 540);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 13);
            this.labelControl8.TabIndex = 31;
            this.labelControl8.Text = "Closing";
            // 
            // cboClosing
            // 
            this.cboClosing.Location = new System.Drawing.Point(97, 538);
            this.cboClosing.Name = "cboClosing";
            this.cboClosing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboClosing.Properties.Items.AddRange(new object[] {
            "Respectfully yours,",
            "Sincerely yours,",
            "Truly yours,",
            "Very Truly yours,"});
            this.cboClosing.Size = new System.Drawing.Size(319, 20);
            this.cboClosing.TabIndex = 44;
            this.cboClosing.SelectedIndexChanged += new System.EventHandler(this.cboClosing_SelectedIndexChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(454, 562);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(14, 13);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "CC";
            // 
            // txtSignatories
            // 
            this.txtSignatories.Location = new System.Drawing.Point(97, 559);
            this.txtSignatories.Name = "txtSignatories";
            this.txtSignatories.Size = new System.Drawing.Size(319, 20);
            this.txtSignatories.TabIndex = 45;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 583);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(42, 13);
            this.labelControl10.TabIndex = 31;
            this.labelControl10.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(97, 580);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(319, 20);
            this.txtPosition.TabIndex = 46;
            // 
            // chkAbsence
            // 
            this.chkAbsence.Location = new System.Drawing.Point(452, 540);
            this.chkAbsence.Name = "chkAbsence";
            this.chkAbsence.Properties.Caption = "Show For and In the absence of the";
            this.chkAbsence.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkAbsence.Size = new System.Drawing.Size(257, 18);
            this.chkAbsence.TabIndex = 47;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(479, 560);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(673, 38);
            this.txtCC.TabIndex = 48;
            // 
            // btnClose
            // 
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(1077, 607);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(996, 607);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(12, 562);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(58, 13);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Signatories";
            // 
            // txtInsideAddress
            // 
            this.txtInsideAddress.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.txtInsideAddress.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.txtInsideAddress.Location = new System.Drawing.Point(97, 103);
            this.txtInsideAddress.Name = "txtInsideAddress";
            this.txtInsideAddress.Options.AutoCorrect.UseSpellCheckerSuggestions = true;
            this.txtInsideAddress.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtInsideAddress.Options.HorizontalScrollbar.Visibility = DevExpress.XtraRichEdit.RichEditScrollbarVisibility.Hidden;
            this.txtInsideAddress.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtInsideAddress.Size = new System.Drawing.Size(1055, 99);
            this.txtInsideAddress.TabIndex = 43;
            this.txtInsideAddress.Views.DraftView.Padding = new System.Windows.Forms.Padding(0);
            this.txtInsideAddress.Views.SimpleView.Padding = new System.Windows.Forms.Padding(0);
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(12, 270);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(25, 13);
            this.labelControl12.TabIndex = 31;
            this.labelControl12.Text = "Body";
            // 
            // btnAddTable
            // 
            this.btnAddTable.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTable.ImageOptions.Image")));
            this.btnAddTable.Location = new System.Drawing.Point(97, 246);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(27, 23);
            this.btnAddTable.TabIndex = 51;
            this.btnAddTable.ToolTip = "Add Tables";
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnBold
            // 
            this.btnBold.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.ImageOptions.Image")));
            this.btnBold.Location = new System.Drawing.Point(125, 246);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(27, 23);
            this.btnBold.TabIndex = 51;
            this.btnBold.ToolTip = "Add Tables";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.ImageOptions.Image")));
            this.btnItalic.Location = new System.Drawing.Point(153, 246);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(27, 23);
            this.btnItalic.TabIndex = 51;
            this.btnItalic.ToolTip = "Add Tables";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.ImageOptions.Image")));
            this.btnUnderline.Location = new System.Drawing.Point(181, 246);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(27, 23);
            this.btnUnderline.TabIndex = 51;
            this.btnUnderline.ToolTip = "Add Tables";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnIncFont
            // 
            this.btnIncFont.Location = new System.Drawing.Point(214, 246);
            this.btnIncFont.Name = "btnIncFont";
            this.btnIncFont.Size = new System.Drawing.Size(107, 23);
            this.btnIncFont.TabIndex = 51;
            this.btnIncFont.Text = "Increase Font";
            this.btnIncFont.ToolTip = "Add Tables";
            this.btnIncFont.Click += new System.EventHandler(this.btnIncFont_Click);
            // 
            // btnDecFont
            // 
            this.btnDecFont.Location = new System.Drawing.Point(327, 246);
            this.btnDecFont.Name = "btnDecFont";
            this.btnDecFont.Size = new System.Drawing.Size(107, 23);
            this.btnDecFont.TabIndex = 51;
            this.btnDecFont.Text = "Decrease Font";
            this.btnDecFont.ToolTip = "Add Tables";
            this.btnDecFont.Click += new System.EventHandler(this.btnDecFont_Click);
            // 
            // fntTextfont
            // 
            this.fntTextfont.Location = new System.Drawing.Point(440, 246);
            this.fntTextfont.Name = "fntTextfont";
            this.fntTextfont.Properties.AutoHeight = false;
            this.fntTextfont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fntTextfont.Properties.NullText = "Calibri";
            this.fntTextfont.Size = new System.Drawing.Size(107, 23);
            this.fntTextfont.TabIndex = 52;
            this.fntTextfont.SelectedIndexChanged += new System.EventHandler(this.fntTextfont_SelectedIndexChanged);
            // 
            // frmAddEditLetterV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 644);
            this.Controls.Add(this.fntTextfont);
            this.Controls.Add(this.btnDecFont);
            this.Controls.Add(this.btnIncFont);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.chkAbsence);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtSignatories);
            this.Controls.Add(this.cboClosing);
            this.Controls.Add(this.txtInsideAddress);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.cboTemplates);
            this.Controls.Add(this.dtSalutation);
            this.Controls.Add(this.cboOffice);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditLetterV2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit Letters";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditLettersV2_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalutation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTemplates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboClosing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSignatories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPosition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAbsence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fntTextfont.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit cboOffice;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit dtSalutation;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cboTemplates;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private System.Windows.Forms.BindingSource templatesBindingSource;
        private DevExpress.XtraRichEdit.RichEditControl txtBody;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ComboBoxEdit cboClosing;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSignatories;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtPosition;
        private DevExpress.XtraEditors.CheckEdit chkAbsence;
        private DevExpress.XtraEditors.MemoEdit txtCC;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraRichEdit.RichEditControl txtInsideAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colOffcAcr;
        private DevExpress.XtraGrid.Columns.GridColumn colChief;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btnAddTable;
        private DevExpress.XtraEditors.SimpleButton btnBold;
        private DevExpress.XtraEditors.SimpleButton btnItalic;
        private DevExpress.XtraEditors.SimpleButton btnUnderline;
        private DevExpress.XtraEditors.SimpleButton btnIncFont;
        private DevExpress.XtraEditors.SimpleButton btnDecFont;
        private DevExpress.XtraEditors.FontEdit fntTextfont;
    }
}