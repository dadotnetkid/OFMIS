namespace Win.PO
{
    partial class frmAddEditPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditPO));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtControlNumber = new DevExpress.XtraEditors.TextEdit();
            this.chkIsClosed = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.cboSuppliers = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.btnAddItems = new DevExpress.XtraEditors.SimpleButton();
            this.ItemsGridControl = new DevExpress.XtraGrid.GridControl();
            this.ItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboCategoryRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRichTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit();
            this.colUOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinAmountRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteItemRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinQuantityRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colItemNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinNumberRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddPayee = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectItemFromAbstract = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControlNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsClosed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuppliers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmountRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteItemRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantityRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumberRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(982, 54);
            this.panel1.MinimumSize = new System.Drawing.Size(982, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 54);
            this.panel1.TabIndex = 74;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Location = new System.Drawing.Point(97, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(237, 27);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "New Purchase Orders";
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
            // txtControlNumber
            // 
            this.txtControlNumber.Location = new System.Drawing.Point(97, 82);
            this.txtControlNumber.Name = "txtControlNumber";
            this.txtControlNumber.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControlNumber.Properties.Appearance.Options.UseFont = true;
            this.txtControlNumber.Properties.UseReadOnlyAppearance = false;
            this.txtControlNumber.Size = new System.Drawing.Size(278, 20);
            this.txtControlNumber.TabIndex = 76;
            // 
            // chkIsClosed
            // 
            this.chkIsClosed.Location = new System.Drawing.Point(13, 190);
            this.chkIsClosed.Name = "chkIsClosed";
            this.chkIsClosed.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsClosed.Properties.Appearance.Options.UseFont = true;
            this.chkIsClosed.Properties.Caption = "is Closed";
            this.chkIsClosed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkIsClosed.Size = new System.Drawing.Size(100, 18);
            this.chkIsClosed.TabIndex = 85;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(80, 14);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "PO Description";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 14);
            this.labelControl3.TabIndex = 79;
            this.labelControl3.Text = "Address";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(12, 107);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 14);
            this.labelControl10.TabIndex = 81;
            this.labelControl10.Text = "Supplier";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 82;
            this.labelControl2.Text = "Control No.";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 14);
            this.labelControl1.TabIndex = 78;
            this.labelControl1.Text = "Date*";
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(97, 60);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.DisplayFormat.FormatString = "";
            this.dtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.EditFormat.FormatString = "";
            this.dtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.Mask.EditMask = "";
            this.dtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtDate.Properties.UseReadOnlyAppearance = false;
            this.dtDate.Size = new System.Drawing.Size(277, 20);
            this.dtDate.TabIndex = 75;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(97, 126);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Properties.Appearance.Options.UseFont = true;
            this.txtAddress.Size = new System.Drawing.Size(352, 20);
            this.txtAddress.TabIndex = 83;
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.Location = new System.Drawing.Point(97, 104);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuppliers.Properties.Appearance.Options.UseFont = true;
            this.cboSuppliers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSuppliers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Office", "Office"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Address", "Address")});
            this.cboSuppliers.Properties.DisplayMember = "Name";
            this.cboSuppliers.Properties.NullText = "";
            this.cboSuppliers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboSuppliers.Properties.UseReadOnlyAppearance = false;
            this.cboSuppliers.Properties.ValueMember = "Name";
            this.cboSuppliers.Size = new System.Drawing.Size(352, 20);
            this.cboSuppliers.TabIndex = 77;
            // 
            // txtDescription
            // 
            this.txtDescription.EditValue = "";
            this.txtDescription.Location = new System.Drawing.Point(97, 148);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(352, 40);
            this.txtDescription.TabIndex = 84;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Appearance.Options.UseFont = true;
            this.btnAddItems.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAddItems.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnAddItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItems.ImageOptions.Image")));
            this.btnAddItems.Location = new System.Drawing.Point(12, 214);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(150, 23);
            this.btnAddItems.TabIndex = 86;
            this.btnAddItems.Text = "Add Item from Abstract";
            // 
            // ItemsGridControl
            // 
            this.ItemsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsGridControl.Location = new System.Drawing.Point(12, 243);
            this.ItemsGridControl.MainView = this.ItemsGridView;
            this.ItemsGridControl.Name = "ItemsGridControl";
            this.ItemsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteItemRepo,
            this.spinNumberRepo,
            this.spinAmountRepo,
            this.cboCategoryRepo,
            this.spinQuantityRepo,
            this.repositoryItemRichTextEdit1});
            this.ItemsGridControl.Size = new System.Drawing.Size(957, 281);
            this.ItemsGridControl.TabIndex = 87;
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
            this.colQuantity,
            this.colItemNo,
            this.Total});
            this.ItemsGridView.GridControl = this.ItemsGridControl;
            this.ItemsGridView.Name = "ItemsGridView";
            this.ItemsGridView.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.ItemsGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.ItemsGridView.OptionsSelection.CheckBoxSelectorColumnWidth = 20;
            this.ItemsGridView.OptionsSelection.CheckBoxSelectorField = "Id";
            this.ItemsGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.ItemsGridView.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.ItemsGridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.ItemsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.ItemsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCategory
            // 
            this.colCategory.ColumnEdit = this.cboCategoryRepo;
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Visible = true;
            this.colCategory.VisibleIndex = 5;
            this.colCategory.Width = 167;
            // 
            // cboCategoryRepo
            // 
            this.cboCategoryRepo.AutoHeight = false;
            this.cboCategoryRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCategoryRepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category")});
            this.cboCategoryRepo.DisplayMember = "Category";
            this.cboCategoryRepo.Name = "cboCategoryRepo";
            this.cboCategoryRepo.NullText = "";
            this.cboCategoryRepo.ValueMember = "Category";
            // 
            // colItem
            // 
            this.colItem.ColumnEdit = this.repositoryItemRichTextEdit1;
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 4;
            this.colItem.Width = 377;
            // 
            // repositoryItemRichTextEdit1
            // 
            this.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1";
            this.repositoryItemRichTextEdit1.ShowCaretInReadOnly = false;
            // 
            // colUOM
            // 
            this.colUOM.FieldName = "UOM";
            this.colUOM.Name = "colUOM";
            this.colUOM.Visible = true;
            this.colUOM.VisibleIndex = 3;
            this.colUOM.Width = 70;
            // 
            // colCost
            // 
            this.colCost.ColumnEdit = this.spinAmountRepo;
            this.colCost.FieldName = "Cost";
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 6;
            this.colCost.Width = 65;
            // 
            // spinAmountRepo
            // 
            this.spinAmountRepo.AutoHeight = false;
            this.spinAmountRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmountRepo.DisplayFormat.FormatString = "#,#.#0";
            this.spinAmountRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmountRepo.EditFormat.FormatString = "#,#.#0";
            this.spinAmountRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmountRepo.Name = "spinAmountRepo";
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
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.spinQuantityRepo;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 56;
            // 
            // spinQuantityRepo
            // 
            this.spinQuantityRepo.AutoHeight = false;
            this.spinQuantityRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinQuantityRepo.Name = "spinQuantityRepo";
            // 
            // colItemNo
            // 
            this.colItemNo.Caption = "Item No.";
            this.colItemNo.ColumnEdit = this.spinNumberRepo;
            this.colItemNo.FieldName = "ItemNo";
            this.colItemNo.Name = "colItemNo";
            this.colItemNo.Visible = true;
            this.colItemNo.VisibleIndex = 1;
            this.colItemNo.Width = 60;
            // 
            // spinNumberRepo
            // 
            this.spinNumberRepo.AutoHeight = false;
            this.spinNumberRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumberRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNumberRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNumberRepo.Name = "spinNumberRepo";
            // 
            // Total
            // 
            this.Total.Caption = "Total";
            this.Total.ColumnEdit = this.spinAmountRepo;
            this.Total.FieldName = "TotalAmount";
            this.Total.Name = "Total";
            this.Total.OptionsColumn.ReadOnly = true;
            this.Total.Visible = true;
            this.Total.VisibleIndex = 7;
            this.Total.Width = 77;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(863, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 89;
            this.btnClose.Text = "&Close";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(756, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Save ";
            // 
            // btnAddPayee
            // 
            this.btnAddPayee.AutoSize = true;
            this.btnAddPayee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPayee.ImageOptions.Image")));
            this.btnAddPayee.Location = new System.Drawing.Point(449, 103);
            this.btnAddPayee.Name = "btnAddPayee";
            this.btnAddPayee.Size = new System.Drawing.Size(22, 22);
            this.btnAddPayee.TabIndex = 90;
            this.btnAddPayee.Click += new System.EventHandler(this.btnAddPayee_Click);
            // 
            // btnSelectItemFromAbstract
            // 
            this.btnSelectItemFromAbstract.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItemFromAbstract.Appearance.Options.UseFont = true;
            this.btnSelectItemFromAbstract.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSelectItemFromAbstract.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnSelectItemFromAbstract.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectItemFromAbstract.ImageOptions.Image")));
            this.btnSelectItemFromAbstract.Location = new System.Drawing.Point(167, 214);
            this.btnSelectItemFromAbstract.Name = "btnSelectItemFromAbstract";
            this.btnSelectItemFromAbstract.Size = new System.Drawing.Size(161, 23);
            this.btnSelectItemFromAbstract.TabIndex = 86;
            this.btnSelectItemFromAbstract.Text = "Select item from Abstract";
            // 
            // frmAddEditPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 535);
            this.Controls.Add(this.btnAddPayee);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ItemsGridControl);
            this.Controls.Add(this.btnSelectItemFromAbstract);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.txtControlNumber);
            this.Controls.Add(this.chkIsClosed);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboSuppliers);
            this.Controls.Add(this.txtDescription);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1145, 876);
            this.Name = "frmAddEditPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Purchase Order";
            this.Load += new System.EventHandler(this.frmAddEditPO_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtControlNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsClosed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSuppliers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCategoryRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmountRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteItemRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantityRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumberRepo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public DevExpress.XtraEditors.TextEdit txtControlNumber;
        public DevExpress.XtraEditors.CheckEdit chkIsClosed;
        public DevExpress.XtraEditors.DateEdit dtDate;
        public DevExpress.XtraEditors.TextEdit txtAddress;
        public DevExpress.XtraEditors.SimpleButton btnAddItems;
        public DevExpress.XtraGrid.GridControl ItemsGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView ItemsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUOM;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinAmountRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteItemRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinNumberRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colItemNo;
        private DevExpress.XtraGrid.Columns.GridColumn Total;
        public DevExpress.XtraEditors.SimpleButton btnSave;
        public DevExpress.XtraEditors.SimpleButton btnClose;
        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LookUpEdit cboSuppliers;
        public DevExpress.XtraEditors.MemoEdit txtDescription;
        public DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategoryRepo;
        private DevExpress.XtraEditors.SimpleButton btnAddPayee;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinQuantityRepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit repositoryItemRichTextEdit1;
        public DevExpress.XtraEditors.SimpleButton btnSelectItemFromAbstract;
    }
}