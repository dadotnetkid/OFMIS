namespace Win.Pyrll
{
    partial class UCPayrollWages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayrollWages));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditNew = new DevExpress.XtraEditors.SimpleButton();
            this.PayrollGridControl = new DevExpress.XtraGrid.GridControl();
            this.PayrollGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPayrollRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePayrollRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinItemNumberRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinTotalRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colNoOfdays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRatePerDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPERA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPIPS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPIGS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEditEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPayrollRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePayrollRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinItemNumberRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.btnEditNew);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(916, 32);
            this.panelControl1.TabIndex = 4;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnPreview.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(113, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(102, 23);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "Preview";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnEditNew
            // 
            this.btnEditNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditNew.Appearance.Options.UseFont = true;
            this.btnEditNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnEditNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditNew.ImageOptions.Image")));
            this.btnEditNew.Location = new System.Drawing.Point(5, 5);
            this.btnEditNew.Name = "btnEditNew";
            this.btnEditNew.Size = new System.Drawing.Size(102, 23);
            this.btnEditNew.TabIndex = 13;
            this.btnEditNew.Text = "Add New";
            this.btnEditNew.Click += new System.EventHandler(this.btnEditNew_Click);
            // 
            // PayrollGridControl
            // 
            this.PayrollGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollGridControl.Location = new System.Drawing.Point(0, 32);
            this.PayrollGridControl.MainView = this.PayrollGridView;
            this.PayrollGridControl.Name = "PayrollGridControl";
            this.PayrollGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPayrollRepo,
            this.btnDeletePayrollRepo,
            this.spinTotalRepo,
            this.spinItemNumberRepo,
            this.lookUpEditEmployees});
            this.PayrollGridControl.Size = new System.Drawing.Size(916, 486);
            this.PayrollGridControl.TabIndex = 76;
            this.PayrollGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PayrollGridView});
            // 
            // PayrollGridView
            // 
            this.PayrollGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEdit,
            this.colDelete,
            this.colNo,
            this.colName,
            this.colDesignation,
            this.colTotal,
            this.colNoOfdays,
            this.colRatePerDay,
            this.colPERA,
            this.colPHPS,
            this.colPHGS,
            this.colPIPS,
            this.colPIGS});
            this.PayrollGridView.GridControl = this.PayrollGridControl;
            this.PayrollGridView.Name = "PayrollGridView";
            this.PayrollGridView.OptionsBehavior.ReadOnly = true;
            this.PayrollGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.PayrollGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.btnEditPayrollRepo;
            this.colEdit.Name = "colEdit";
            this.colEdit.Width = 20;
            // 
            // btnEditPayrollRepo
            // 
            this.btnEditPayrollRepo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditPayrollRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditPayrollRepo.Name = "btnEditPayrollRepo";
            this.btnEditPayrollRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeletePayrollRepo;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 66;
            // 
            // btnDeletePayrollRepo
            // 
            this.btnDeletePayrollRepo.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDeletePayrollRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeletePayrollRepo.Name = "btnDeletePayrollRepo";
            this.btnDeletePayrollRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colNo
            // 
            this.colNo.Caption = "No.";
            this.colNo.ColumnEdit = this.spinItemNumberRepo;
            this.colNo.FieldName = "ItemNumber";
            this.colNo.Name = "colNo";
            this.colNo.Width = 53;
            // 
            // spinItemNumberRepo
            // 
            this.spinItemNumberRepo.AutoHeight = false;
            this.spinItemNumberRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinItemNumberRepo.Name = "spinItemNumberRepo";
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Employees.EmployeeName";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 196;
            // 
            // colDesignation
            // 
            this.colDesignation.Caption = "Designation";
            this.colDesignation.FieldName = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.ColumnEdit = this.spinTotalRepo;
            this.colTotal.DisplayFormat.FormatString = "n2";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 9;
            this.colTotal.Width = 196;
            // 
            // spinTotalRepo
            // 
            this.spinTotalRepo.AutoHeight = false;
            this.spinTotalRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTotalRepo.DisplayFormat.FormatString = "n2";
            this.spinTotalRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinTotalRepo.EditFormat.FormatString = "n2";
            this.spinTotalRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinTotalRepo.Name = "spinTotalRepo";
            // 
            // colNoOfdays
            // 
            this.colNoOfdays.Caption = "No of Days";
            this.colNoOfdays.ColumnEdit = this.spinItemNumberRepo;
            this.colNoOfdays.FieldName = "NoOfdays";
            this.colNoOfdays.Name = "colNoOfdays";
            this.colNoOfdays.Visible = true;
            this.colNoOfdays.VisibleIndex = 2;
            this.colNoOfdays.Width = 80;
            // 
            // colRatePerDay
            // 
            this.colRatePerDay.Caption = "Rate Per Day";
            this.colRatePerDay.ColumnEdit = this.spinTotalRepo;
            this.colRatePerDay.FieldName = "RatePerDay";
            this.colRatePerDay.Name = "colRatePerDay";
            this.colRatePerDay.Visible = true;
            this.colRatePerDay.VisibleIndex = 3;
            this.colRatePerDay.Width = 132;
            // 
            // colPERA
            // 
            this.colPERA.Caption = "PERA";
            this.colPERA.ColumnEdit = this.spinTotalRepo;
            this.colPERA.FieldName = "PERA";
            this.colPERA.Name = "colPERA";
            this.colPERA.Visible = true;
            this.colPERA.VisibleIndex = 4;
            this.colPERA.Width = 132;
            // 
            // colPHPS
            // 
            this.colPHPS.Caption = "Phil Health PS";
            this.colPHPS.ColumnEdit = this.spinTotalRepo;
            this.colPHPS.FieldName = "PHPS";
            this.colPHPS.Name = "colPHPS";
            this.colPHPS.Visible = true;
            this.colPHPS.VisibleIndex = 5;
            this.colPHPS.Width = 132;
            // 
            // colPHGS
            // 
            this.colPHGS.Caption = "Phil Health GS";
            this.colPHGS.ColumnEdit = this.spinTotalRepo;
            this.colPHGS.FieldName = "PHGS";
            this.colPHGS.Name = "colPHGS";
            this.colPHGS.Visible = true;
            this.colPHGS.VisibleIndex = 6;
            this.colPHGS.Width = 132;
            // 
            // colPIPS
            // 
            this.colPIPS.Caption = "Pag Ibig PS";
            this.colPIPS.ColumnEdit = this.spinTotalRepo;
            this.colPIPS.FieldName = "PIPS";
            this.colPIPS.Name = "colPIPS";
            this.colPIPS.Visible = true;
            this.colPIPS.VisibleIndex = 7;
            this.colPIPS.Width = 132;
            // 
            // colPIGS
            // 
            this.colPIGS.Caption = "Pag Ibig GS";
            this.colPIGS.ColumnEdit = this.spinTotalRepo;
            this.colPIGS.FieldName = "PIGS";
            this.colPIGS.Name = "colPIGS";
            this.colPIGS.Visible = true;
            this.colPIGS.VisibleIndex = 8;
            this.colPIGS.Width = 132;
            // 
            // lookUpEditEmployees
            // 
            this.lookUpEditEmployees.AutoHeight = false;
            this.lookUpEditEmployees.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditEmployees.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "FullName"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Position", "Position")});
            this.lookUpEditEmployees.DisplayMember = "EmployeeName";
            this.lookUpEditEmployees.Name = "lookUpEditEmployees";
            this.lookUpEditEmployees.NullText = "";
            this.lookUpEditEmployees.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEditEmployees.ValueMember = "Id";
            // 
            // UCPayrollWages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayrollGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCPayrollWages";
            this.Size = new System.Drawing.Size(916, 518);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPayrollRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePayrollRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinItemNumberRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnPreview;
        public DevExpress.XtraEditors.SimpleButton btnEditNew;
        public DevExpress.XtraGrid.GridControl PayrollGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView PayrollGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPayrollRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePayrollRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinItemNumberRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        public DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinTotalRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colNoOfdays;
        private DevExpress.XtraGrid.Columns.GridColumn colRatePerDay;
        private DevExpress.XtraGrid.Columns.GridColumn colPERA;
        private DevExpress.XtraGrid.Columns.GridColumn colPHPS;
        private DevExpress.XtraGrid.Columns.GridColumn colPHGS;
        private DevExpress.XtraGrid.Columns.GridColumn colPIPS;
        private DevExpress.XtraGrid.Columns.GridColumn colPIGS;
    }
}
