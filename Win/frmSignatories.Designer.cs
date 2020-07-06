namespace Win
{
    partial class frmSignatories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignatories));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SignatoriesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteSignatory = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboHead = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEditYearRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colOffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsBacMember = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkIsBACMemberRepo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBACPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cboOfficeRepo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignatoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSignatory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYearRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsBACMemberRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOfficeRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Year ASC";
            this.entityServerModeSource1.ElementType = typeof(Models.Signatories);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 54);
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
            this.lblHeader.Size = new System.Drawing.Size(120, 27);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Signatories";
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 54);
            this.gridControl1.MainView = this.SignatoriesGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteSignatory,
            this.cboPosition,
            this.spinEditYearRepo,
            this.chkIsBACMemberRepo,
            this.cboOfficeRepo,
            this.cboHead});
            this.gridControl1.Size = new System.Drawing.Size(1113, 478);
            this.gridControl1.TabIndex = 31;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SignatoriesGridView});
            // 
            // SignatoriesGridView
            // 
            this.SignatoriesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDelete,
            this.colPerson,
            this.colPosition,
            this.colNote,
            this.colYear,
            this.colOffice,
            this.colIsBacMember,
            this.colBACPosition});
            this.SignatoriesGridView.GridControl = this.gridControl1;
            this.SignatoriesGridView.Name = "SignatoriesGridView";
            this.SignatoriesGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.SignatoriesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.SignatoriesGridView.OptionsView.ShowGroupPanel = false;
            this.SignatoriesGridView.ShownEditor += new System.EventHandler(this.SignatoriesGridView_ShownEditor);
            this.SignatoriesGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.SignatoriesGridView_CellValueChanged);
            this.SignatoriesGridView.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.SignatoriesGridView_CellValueChanging);
            this.SignatoriesGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.SignatoriesGridView_RowUpdated);
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeleteSignatory;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 36;
            // 
            // btnDeleteSignatory
            // 
            this.btnDeleteSignatory.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDeleteSignatory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteSignatory.Name = "btnDeleteSignatory";
            this.btnDeleteSignatory.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colPerson
            // 
            this.colPerson.ColumnEdit = this.cboHead;
            this.colPerson.FieldName = "Person";
            this.colPerson.Name = "colPerson";
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 1;
            this.colPerson.Width = 134;
            // 
            // cboHead
            // 
            this.cboHead.AutoHeight = false;
            this.cboHead.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboHead.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chief", "Head"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChiefPosition", "Position")});
            this.cboHead.DisplayMember = "Chief";
            this.cboHead.Name = "cboHead";
            this.cboHead.NullText = "";
            this.cboHead.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboHead.ValueMember = "Chief";
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            this.colPosition.Width = 235;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 134;
            // 
            // colYear
            // 
            this.colYear.ColumnEdit = this.spinEditYearRepo;
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 5;
            this.colYear.Width = 64;
            // 
            // spinEditYearRepo
            // 
            this.spinEditYearRepo.AutoHeight = false;
            this.spinEditYearRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditYearRepo.Name = "spinEditYearRepo";
            // 
            // colOffice
            // 
            this.colOffice.Caption = "Office";
            this.colOffice.FieldName = "Office";
            this.colOffice.Name = "colOffice";
            this.colOffice.Visible = true;
            this.colOffice.VisibleIndex = 2;
            // 
            // colIsBacMember
            // 
            this.colIsBacMember.Caption = "is BAC Member";
            this.colIsBacMember.ColumnEdit = this.chkIsBACMemberRepo;
            this.colIsBacMember.FieldName = "IsBacMember";
            this.colIsBacMember.Name = "colIsBacMember";
            this.colIsBacMember.Visible = true;
            this.colIsBacMember.VisibleIndex = 6;
            this.colIsBacMember.Width = 100;
            // 
            // chkIsBACMemberRepo
            // 
            this.chkIsBACMemberRepo.AutoHeight = false;
            this.chkIsBACMemberRepo.Name = "chkIsBACMemberRepo";
            // 
            // colBACPosition
            // 
            this.colBACPosition.Caption = "BAC Position";
            this.colBACPosition.FieldName = "BacPosition";
            this.colBACPosition.Name = "colBACPosition";
            this.colBACPosition.Visible = true;
            this.colBACPosition.VisibleIndex = 7;
            // 
            // cboPosition
            // 
            this.cboPosition.AutoHeight = false;
            this.cboPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Position", "Position"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
            this.cboPosition.DisplayMember = "Position";
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.NullText = "";
            this.cboPosition.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPosition.ValueMember = "Position";
            // 
            // cboOfficeRepo
            // 
            this.cboOfficeRepo.AutoHeight = false;
            this.cboOfficeRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboOfficeRepo.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chief", "Chief"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChiefPosition", "Position")});
            this.cboOfficeRepo.DisplayMember = "OfficeName";
            this.cboOfficeRepo.Name = "cboOfficeRepo";
            this.cboOfficeRepo.NullText = "";
            this.cboOfficeRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboOfficeRepo.ValueMember = "Id";
            // 
            // frmSignatories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 532);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSignatories";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signatories";
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignatoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSignatory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYearRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsBACMemberRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboOfficeRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView SignatoriesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteSignatory;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEditYearRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colOffice;
        private DevExpress.XtraGrid.Columns.GridColumn colIsBacMember;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkIsBACMemberRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colBACPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboOfficeRepo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboHead;
    }
}