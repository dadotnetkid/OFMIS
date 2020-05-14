namespace Win.PR
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.cboSearch = new DevExpress.XtraEditors.LookUpEdit();
            this.cboCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.ItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteItemRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditItemRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSelectItemRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteItemRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditItemRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectItemRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.cboSearch);
            this.panel1.Controls.Add(this.cboCategory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 65);
            this.panel1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Search";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Category";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(303, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New Item";
            // 
            // cboSearch
            // 
            this.cboSearch.Location = new System.Drawing.Point(79, 28);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Properties.AutoHeight = false;
            this.cboSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSearch.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Item", "Item")});
            this.cboSearch.Properties.DisplayMember = "Item";
            this.cboSearch.Properties.ImmediatePopup = true;
            this.cboSearch.Properties.NullText = "";
            this.cboSearch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSearch.Properties.ValueMember = "Item";
            this.cboSearch.Size = new System.Drawing.Size(218, 20);
            this.cboSearch.TabIndex = 0;
            this.cboSearch.EditValueChanged += new System.EventHandler(this.cboSearch_EditValueChanged);
            this.cboSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.cboSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cboCategory
            // 
            this.cboCategory.Location = new System.Drawing.Point(79, 7);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Properties.AutoHeight = false;
            this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category")});
            this.cboCategory.Properties.DisplayMember = "Category";
            this.cboCategory.Properties.ImmediatePopup = true;
            this.cboCategory.Properties.NullText = "";
            this.cboCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboCategory.Properties.ValueMember = "Category";
            this.cboCategory.Size = new System.Drawing.Size(218, 20);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.EditValueChanged += new System.EventHandler(this.txtSearch_EditValueChanged);
            this.cboCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.cboCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataSource = typeof(Models.Items);
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Id ASC";
            this.entityServerModeSource1.ElementType = typeof(Models.Items);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSubmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubmit.Appearance.Options.UseFont = true;
            this.btnSubmit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSubmit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSubmit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.ImageOptions.Image")));
            this.btnSubmit.Location = new System.Drawing.Point(878, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            // 
            // ItemsGridControl
            // 
            this.ItemsGridControl.DataSource = this.entityServerModeSource1;
            this.ItemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGridControl.Location = new System.Drawing.Point(0, 65);
            this.ItemsGridControl.MainView = this.ItemsGridView;
            this.ItemsGridControl.Name = "ItemsGridControl";
            this.ItemsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteItemRepo,
            this.btnEditItemRepo,
            this.btnSelectItemRepo});
            this.ItemsGridControl.Size = new System.Drawing.Size(992, 454);
            this.ItemsGridControl.TabIndex = 2;
            this.ItemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ItemsGridView});
            // 
            // ItemsGridView
            // 
            this.ItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCategory,
            this.colItem,
            this.colUOM,
            this.colCost,
            this.colDateCreated,
            this.colDelete,
            this.colEdit,
            this.colSelect});
            this.ItemsGridView.GridControl = this.ItemsGridControl;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.ItemsGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.ItemsGridView.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.ItemsGridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.ItemsGridView.OptionsView.ShowGroupPanel = false;
            this.ItemsGridView.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.ItemsGridView_SelectionChanged);
            this.ItemsGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ItemsGridView_RowUpdated);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 2;
            this.colCategory.Width = 187;
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 3;
            this.colItem.Width = 424;
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 4;
            this.colUOM.Width = 181;
            // 
            // colCost
            // 
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 5;
            this.colCost.Width = 115;
            // 
            // colDateCreated
            // 
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeleteItemRepo;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 20;
            // 
            // btnDeleteItemRepo
            // 
            this.btnDeleteItemRepo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDeleteItemRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteItemRepo.Name = "btnDeleteItemRepo";
            this.btnDeleteItemRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.btnEditItemRepo;
            this.colEdit.Name = "colEdit";
            this.colEdit.Width = 20;
            // 
            // btnEditItemRepo
            // 
            this.btnEditItemRepo.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnEditItemRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditItemRepo.Name = "btnEditItemRepo";
            this.btnEditItemRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colSelect
            // 
            this.colSelect.ColumnEdit = this.btnSelectItemRepo;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 1;
            this.colSelect.Width = 20;
            // 
            // btnSelectItemRepo
            // 
            this.btnSelectItemRepo.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnSelectItemRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnSelectItemRepo.Name = "btnSelectItemRepo";
            this.btnSelectItemRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 566);
            this.Controls.Add(this.ItemsGridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteItemRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditItemRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelectItemRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        public DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.Panel panel2;
        public DevExpress.XtraEditors.SimpleButton btnSubmit;
        public DevExpress.XtraGrid.GridControl ItemsGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView ItemsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteItemRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditItemRepo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LookUpEdit cboCategory;
        public DevExpress.XtraEditors.LookUpEdit cboSearch;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnSelectItemRepo;
    }
}