namespace Win.Pyrll
{
    partial class UCPayrollDifferentials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayrollDifferentials));
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
            this.PayrollDiffGridControl = new DevExpress.XtraGrid.GridControl();
            this.PayrollDiffGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPayrollRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePayrollRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colControlNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinTotalRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.spinItemNumberRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.lookUpEditEmployees = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollDiffGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollDiffGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPayrollRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePayrollRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinItemNumberRepo)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1126, 32);
            this.panelControl1.TabIndex = 5;
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
            // PayrollDiffGridControl
            // 
            this.PayrollDiffGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayrollDiffGridControl.Location = new System.Drawing.Point(0, 32);
            this.PayrollDiffGridControl.MainView = this.PayrollDiffGridView;
            this.PayrollDiffGridControl.Name = "PayrollDiffGridControl";
            this.PayrollDiffGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPayrollRepo,
            this.btnDeletePayrollRepo,
            this.spinTotalRepo,
            this.spinItemNumberRepo,
            this.lookUpEditEmployees});
            this.PayrollDiffGridControl.Size = new System.Drawing.Size(1126, 678);
            this.PayrollDiffGridControl.TabIndex = 77;
            this.PayrollDiffGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PayrollDiffGridView});
            // 
            // PayrollDiffGridView
            // 
            this.PayrollDiffGridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.PayrollDiffGridView.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.PayrollDiffGridView.ColumnPanelRowHeight = 50;
            this.PayrollDiffGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEdit,
            this.colDelete,
            this.colControlNo,
            this.colDescription,
            this.colTotalAmount,
            this.colPayTitle});
            this.PayrollDiffGridView.GridControl = this.PayrollDiffGridControl;
            this.PayrollDiffGridView.Name = "PayrollDiffGridView";
            this.PayrollDiffGridView.OptionsCustomization.AllowRowSizing = true;
            this.PayrollDiffGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.PayrollDiffGridView.OptionsNavigation.EnterMoveNextColumn = true;
            this.PayrollDiffGridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.False;
            this.PayrollDiffGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.PayrollDiffGridView.OptionsView.ShowGroupPanel = false;
            this.PayrollDiffGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.btnEditPayrollRepo;
            this.colEdit.MaxWidth = 20;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 0;
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
            this.colDelete.MaxWidth = 20;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 1;
            this.colDelete.Width = 20;
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
            // colControlNo
            // 
            this.colControlNo.Caption = "Control No";
            this.colControlNo.FieldName = "ControlNo";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 2;
            this.colControlNo.Width = 88;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 761;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Total Amount";
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 5;
            this.colTotalAmount.Width = 104;
            // 
            // colPayTitle
            // 
            this.colPayTitle.Caption = "Title";
            this.colPayTitle.FieldName = "Title";
            this.colPayTitle.Name = "colPayTitle";
            this.colPayTitle.Visible = true;
            this.colPayTitle.VisibleIndex = 3;
            this.colPayTitle.Width = 91;
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
            // spinItemNumberRepo
            // 
            this.spinItemNumberRepo.AutoHeight = false;
            this.spinItemNumberRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinItemNumberRepo.Name = "spinItemNumberRepo";
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
            // UCPayrollDifferentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayrollDiffGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCPayrollDifferentials";
            this.Size = new System.Drawing.Size(1126, 710);
            this.Load += new System.EventHandler(this.UCPayrollDifferentials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PayrollDiffGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollDiffGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPayrollRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePayrollRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinItemNumberRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnPreview;
        public DevExpress.XtraEditors.SimpleButton btnEditNew;
        public DevExpress.XtraGrid.GridControl PayrollDiffGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView PayrollDiffGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPayrollRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePayrollRepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinItemNumberRepo;
        public DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinTotalRepo;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lookUpEditEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTitle;
    }
}
