namespace Win.Actns
{
    partial class frmDocActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocActions));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboPrograms = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboMain = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cboSub = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cboActivity = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.txtActionTaken = new DevExpress.XtraEditors.LookUpEdit();
            this.ActionTakenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.cboUsers = new DevExpress.XtraEditors.TextEdit();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnScanFiles = new DevExpress.XtraEditors.SimpleButton();
            this.btnActionTaken = new DevExpress.XtraEditors.SimpleButton();
            this.btnRouteTo = new DevExpress.XtraEditors.SimpleButton();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.StatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtRemarks = new DevExpress.XtraEditors.LookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewRemarks = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrograms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSub.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboActivity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionTaken.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Date/Time";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 182);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Action Taken";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.EditValue = new System.DateTime(2020, 2, 25, 18, 50, 55, 0);
            this.dtDate.Location = new System.Drawing.Point(87, 60);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.EditFormat.FormatString = "d";
            this.dtDate.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy hh:mm:ss tt";
            this.dtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtDate.Properties.EditFormat.FormatString = "MM/dd/yyyy hh:mm:ss tt";
            this.dtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtDate.Properties.NullDate = new System.DateTime(2020, 2, 25, 18, 51, 15, 217);
            this.dtDate.Properties.NullDateCalendarValue = new System.DateTime(2020, 2, 25, 18, 51, 4, 0);
            this.dtDate.Properties.TodayDate = new System.DateTime(2020, 2, 25, 18, 51, 50, 0);
            this.dtDate.Size = new System.Drawing.Size(231, 24);
            this.dtDate.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(25, 228);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Route To:";
            // 
            // cboPrograms
            // 
            this.cboPrograms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPrograms.Location = new System.Drawing.Point(87, 84);
            this.cboPrograms.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboPrograms.Name = "cboPrograms";
            this.cboPrograms.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboPrograms.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboPrograms.Properties.Appearance.Options.UseFont = true;
            this.cboPrograms.Properties.AutoHeight = false;
            this.cboPrograms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPrograms.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemOrder", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboPrograms.Properties.DisplayMember = "ActionValue";
            this.cboPrograms.Properties.NullText = "";
            this.cboPrograms.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPrograms.Properties.ValueMember = "Id";
            this.cboPrograms.Size = new System.Drawing.Size(504, 24);
            this.cboPrograms.TabIndex = 1;
            this.cboPrograms.EditValueChanged += new System.EventHandler(this.cboPrograms_EditValueChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 87);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 17);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Program:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(27, 111);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Main Act:";
            // 
            // cboMain
            // 
            this.cboMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboMain.Location = new System.Drawing.Point(87, 108);
            this.cboMain.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboMain.Name = "cboMain";
            this.cboMain.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboMain.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboMain.Properties.Appearance.Options.UseFont = true;
            this.cboMain.Properties.AutoHeight = false;
            this.cboMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboMain.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemOrder", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboMain.Properties.DisplayMember = "ActionValue";
            this.cboMain.Properties.NullText = "";
            this.cboMain.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.cboMain.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboMain.Properties.ValueMember = "Id";
            this.cboMain.Size = new System.Drawing.Size(504, 24);
            this.cboMain.TabIndex = 2;
            this.cboMain.EditValueChanged += new System.EventHandler(this.cboMain_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(34, 159);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(47, 17);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Sub Act:";
            // 
            // cboSub
            // 
            this.cboSub.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSub.Location = new System.Drawing.Point(87, 156);
            this.cboSub.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboSub.Name = "cboSub";
            this.cboSub.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboSub.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboSub.Properties.Appearance.Options.UseFont = true;
            this.cboSub.Properties.AutoHeight = false;
            this.cboSub.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSub.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboSub.Properties.DisplayMember = "ActionValue";
            this.cboSub.Properties.NullText = "";
            this.cboSub.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSub.Properties.ValueMember = "Id";
            this.cboSub.Size = new System.Drawing.Size(504, 24);
            this.cboSub.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(41, 135);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(40, 17);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Activity";
            // 
            // cboActivity
            // 
            this.cboActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActivity.Location = new System.Drawing.Point(87, 132);
            this.cboActivity.MinimumSize = new System.Drawing.Size(353, 24);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboActivity.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboActivity.Properties.Appearance.Options.UseFont = true;
            this.cboActivity.Properties.AutoHeight = false;
            this.cboActivity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboActivity.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 34, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionValue", "", 108, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Order", "Order", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.True)});
            this.cboActivity.Properties.DisplayMember = "ActionValue";
            this.cboActivity.Properties.NullText = "";
            this.cboActivity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboActivity.Properties.ValueMember = "Id";
            this.cboActivity.Size = new System.Drawing.Size(504, 24);
            this.cboActivity.TabIndex = 3;
            this.cboActivity.EditValueChanged += new System.EventHandler(this.cboActivity_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(21, 265);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(60, 34);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Remarks/\r\nInstruction";
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.Location = new System.Drawing.Point(516, 309);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(75, 26);
            this.btnEditPo.TabIndex = 8;
            this.btnEditPo.TabStop = false;
            this.btnEditPo.Text = "Close";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActionTaken.Location = new System.Drawing.Point(87, 180);
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.txtActionTaken.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.txtActionTaken.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtActionTaken.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtActionTaken.Properties.Appearance.Options.UseFont = true;
            this.txtActionTaken.Properties.AutoHeight = false;
            this.txtActionTaken.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtActionTaken.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionTaken", "", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtActionTaken.Properties.DataSource = this.ActionTakenBindingSource;
            this.txtActionTaken.Properties.DisplayMember = "ActionTaken";
            this.txtActionTaken.Properties.NullText = "";
            this.txtActionTaken.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtActionTaken.Properties.ValueMember = "ActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(437, 44);
            this.txtActionTaken.TabIndex = 5;
            // 
            // ActionTakenBindingSource
            // 
            this.ActionTakenBindingSource.DataSource = typeof(Models.ActionTakens);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 54);
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
            this.lblHeader.Size = new System.Drawing.Size(78, 27);
            this.lblHeader.TabIndex = 9999;
            this.lblHeader.Text = "Actions";
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
            // cboUsers
            // 
            this.cboUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUsers.EditValue = "";
            this.cboUsers.Enabled = false;
            this.cboUsers.Location = new System.Drawing.Point(87, 226);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboUsers.Properties.Appearance.BackColor = System.Drawing.Color.Red;
            this.cboUsers.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboUsers.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.cboUsers.Properties.Appearance.Options.UseBackColor = true;
            this.cboUsers.Properties.Appearance.Options.UseFont = true;
            this.cboUsers.Properties.Appearance.Options.UseForeColor = true;
            this.cboUsers.Properties.AutoHeight = false;
            this.cboUsers.Size = new System.Drawing.Size(437, 36);
            this.cboUsers.TabIndex = 8;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(359, 428);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(70, 25);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Visible = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(293, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 25);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnScanFiles
            // 
            this.btnScanFiles.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanFiles.Appearance.Options.UseFont = true;
            this.btnScanFiles.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnScanFiles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnScanFiles.ImageOptions.Image")));
            this.btnScanFiles.Location = new System.Drawing.Point(227, 428);
            this.btnScanFiles.Name = "btnScanFiles";
            this.btnScanFiles.Size = new System.Drawing.Size(60, 25);
            this.btnScanFiles.TabIndex = 15;
            this.btnScanFiles.Text = "Scan";
            this.btnScanFiles.Visible = false;
            this.btnScanFiles.Click += new System.EventHandler(this.btnScanFiles_Click);
            // 
            // btnActionTaken
            // 
            this.btnActionTaken.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionTaken.Appearance.Options.UseFont = true;
            this.btnActionTaken.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnActionTaken.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActionTaken.ImageOptions.Image")));
            this.btnActionTaken.Location = new System.Drawing.Point(528, 184);
            this.btnActionTaken.MinimumSize = new System.Drawing.Size(63, 38);
            this.btnActionTaken.Name = "btnActionTaken";
            this.btnActionTaken.Size = new System.Drawing.Size(63, 38);
            this.btnActionTaken.TabIndex = 15;
            this.btnActionTaken.Text = "New";
            this.btnActionTaken.Click += new System.EventHandler(this.btnActionTaken_Click);
            // 
            // btnRouteTo
            // 
            this.btnRouteTo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRouteTo.Appearance.Options.UseFont = true;
            this.btnRouteTo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnRouteTo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRouteTo.ImageOptions.Image")));
            this.btnRouteTo.Location = new System.Drawing.Point(528, 224);
            this.btnRouteTo.MinimumSize = new System.Drawing.Size(63, 38);
            this.btnRouteTo.Name = "btnRouteTo";
            this.btnRouteTo.Size = new System.Drawing.Size(63, 38);
            this.btnRouteTo.TabIndex = 15;
            this.btnRouteTo.Text = "Staff";
            this.btnRouteTo.Click += new System.EventHandler(this.btnRouteTo_Click);
            // 
            // btnSend
            // 
            this.btnSend.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Appearance.Options.UseFont = true;
            this.btnSend.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSend.Enabled = false;
            this.btnSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.ImageOptions.Image")));
            this.btnSend.Location = new System.Drawing.Point(303, 309);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(126, 26);
            this.btnSend.TabIndex = 7;
            this.btnSend.TabStop = false;
            this.btnSend.Text = "Send && Close";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPO.ImageOptions.Image")));
            this.btnNewPO.Location = new System.Drawing.Point(435, 309);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 7;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Save";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(87, 264);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtRemarks.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemarks.Properties.Appearance.Options.UseFont = true;
            this.txtRemarks.Properties.AutoHeight = false;
            this.txtRemarks.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRemarks.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ActionTaken", "", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtRemarks.Properties.DataSource = this.ActionTakenBindingSource;
            this.txtRemarks.Properties.DisplayMember = "ActionTaken";
            this.txtRemarks.Properties.NullText = "";
            this.txtRemarks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtRemarks.Properties.ValueMember = "ActionTaken";
            this.txtRemarks.Size = new System.Drawing.Size(437, 39);
            this.txtRemarks.TabIndex = 6;
            this.txtRemarks.EditValueChanged += new System.EventHandler(this.cboStatus_EditValueChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // btnNewRemarks
            // 
            this.btnNewRemarks.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRemarks.Appearance.Options.UseFont = true;
            this.btnNewRemarks.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNewRemarks.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnNewRemarks.Location = new System.Drawing.Point(528, 265);
            this.btnNewRemarks.MinimumSize = new System.Drawing.Size(63, 38);
            this.btnNewRemarks.Name = "btnNewRemarks";
            this.btnNewRemarks.Size = new System.Drawing.Size(63, 38);
            this.btnNewRemarks.TabIndex = 15;
            this.btnNewRemarks.Text = "New";
            this.btnNewRemarks.Click += new System.EventHandler(this.btnNewRemarks_Click);
            // 
            // frmDocActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnScanFiles);
            this.Controls.Add(this.btnNewRemarks);
            this.Controls.Add(this.btnActionTaken);
            this.Controls.Add(this.btnRouteTo);
            this.Controls.Add(this.cboActivity);
            this.Controls.Add(this.cboSub);
            this.Controls.Add(this.cboMain);
            this.Controls.Add(this.cboPrograms);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtActionTaken);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.txtRemarks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(605, 373);
            this.Name = "frmDocActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocActions_FormClosing);
            this.Load += new System.EventHandler(this.frmDocActions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrograms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSub.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboActivity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtActionTaken.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtDate;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private System.Windows.Forms.BindingSource StatusBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cboPrograms;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cboMain;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit cboSub;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit cboActivity;
        private System.Windows.Forms.BindingSource ActionTakenBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit txtActionTaken;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraEditors.SimpleButton btnRouteTo;
        private DevExpress.XtraEditors.TextEdit cboUsers;
        private DevExpress.XtraEditors.SimpleButton btnActionTaken;
        private DevExpress.XtraEditors.SimpleButton btnScanFiles;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.LookUpEdit txtRemarks;
        private DevExpress.XtraEditors.SimpleButton btnNewRemarks;
    }
}