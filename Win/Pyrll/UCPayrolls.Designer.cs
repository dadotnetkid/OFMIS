namespace Win.Pyrll
{
    partial class UCPayrolls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayrolls));
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
            this.colTItle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinTotalRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colTitle2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPayrollRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePayrollRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinItemNumberRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEditNew);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(912, 32);
            this.panelControl1.TabIndex = 3;
            // 
            // btnEditNew
            // 
            this.btnEditNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEditNew.Appearance.Options.UseFont = true;
            this.btnEditNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnEditNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnEditNew.Location = new System.Drawing.Point(5, 5);
            this.btnEditNew.Name = "btnEditNew";
            this.btnEditNew.Size = new System.Drawing.Size(102, 23);
            this.btnEditNew.TabIndex = 13;
            this.btnEditNew.Text = "Add New";
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
            this.spinItemNumberRepo});
            this.PayrollGridControl.Size = new System.Drawing.Size(912, 327);
            this.PayrollGridControl.TabIndex = 4;
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
            this.colTItle1,
            this.colTitle2,
            this.colTotal});
            this.PayrollGridView.GridControl = this.PayrollGridControl;
            this.PayrollGridView.Name = "PayrollGridView";
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
            // colNo
            // 
            this.colNo.Caption = "No.";
            this.colNo.ColumnEdit = this.spinItemNumberRepo;
            this.colNo.FieldName = "ItemNumber";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
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
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDesignation
            // 
            this.colDesignation.Caption = "Designation";
            this.colDesignation.FieldName = "Designation";
            this.colDesignation.Name = "colDesignation";
            this.colDesignation.Visible = true;
            this.colDesignation.VisibleIndex = 2;
            // 
            // colTItle1
            // 
            this.colTItle1.Caption = "Column Title1";
            this.colTItle1.ColumnEdit = this.spinTotalRepo;
            this.colTItle1.FieldName = "Title1";
            this.colTItle1.Name = "colTItle1";
            this.colTItle1.Visible = true;
            this.colTItle1.VisibleIndex = 3;
            // 
            // spinTotalRepo
            // 
            this.spinTotalRepo.AutoHeight = false;
            this.spinTotalRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinTotalRepo.Name = "spinTotalRepo";
            // 
            // colTitle2
            // 
            this.colTitle2.Caption = "Column Title 2";
            this.colTitle2.FieldName = "Title2";
            this.colTitle2.Name = "colTitle2";
            this.colTitle2.Visible = true;
            this.colTitle2.VisibleIndex = 4;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            // 
            // UCPayrolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PayrollGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCPayrolls";
            this.Size = new System.Drawing.Size(912, 359);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPayrollRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePayrollRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinItemNumberRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDesignation;
        private DevExpress.XtraGrid.Columns.GridColumn colTItle1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinTotalRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle2;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
    }
}
