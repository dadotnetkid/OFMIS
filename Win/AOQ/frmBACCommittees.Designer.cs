namespace Win.AOQ
{
    partial class frmBACCommittees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBACCommittees));
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BACGridControl = new DevExpress.XtraGrid.GridControl();
            this.BACGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spinEditYearRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colOffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colRemove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRemove = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnDeleteSignatory = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.chkIsBACMemberRepo = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BACGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYearRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSignatory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsBACMemberRepo)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(598, 54);
            this.panel1.TabIndex = 10002;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Location = new System.Drawing.Point(97, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(154, 27);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "BAC Members";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 40);
            this.panel2.TabIndex = 10009;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(494, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BACGridControl
            // 
            this.BACGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BACGridControl.Location = new System.Drawing.Point(0, 54);
            this.BACGridControl.MainView = this.BACGridView;
            this.BACGridControl.Name = "BACGridControl";
            this.BACGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteSignatory,
            this.cboPosition,
            this.spinEditYearRepo,
            this.chkIsBACMemberRepo,
            this.btnAddRepo,
            this.btnRemove});
            this.BACGridControl.Size = new System.Drawing.Size(598, 174);
            this.BACGridControl.TabIndex = 10010;
            this.BACGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BACGridView});
            // 
            // BACGridView
            // 
            this.BACGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPerson,
            this.colPosition,
            this.colNote,
            this.colYear,
            this.colOffice,
            this.colAdd,
            this.colRemove});
            this.BACGridView.GridControl = this.BACGridControl;
            this.BACGridView.Name = "BACGridView";
            this.BACGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.BACGridView.OptionsSelection.CheckBoxSelectorField = "isSelected";
            this.BACGridView.OptionsSelection.MultiSelect = true;
            this.BACGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.BACGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colPerson
            // 
            this.colPerson.FieldName = "Person";
            this.colPerson.Name = "colPerson";
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 1;
            this.colPerson.Width = 116;
            // 
            // colPosition
            // 
            this.colPosition.ColumnEdit = this.cboPosition;
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 2;
            this.colPosition.Width = 117;
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
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 4;
            this.colNote.Width = 96;
            // 
            // colYear
            // 
            this.colYear.ColumnEdit = this.spinEditYearRepo;
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 5;
            this.colYear.Width = 59;
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
            this.colOffice.VisibleIndex = 3;
            this.colOffice.Width = 65;
            // 
            // colAdd
            // 
            this.colAdd.ColumnEdit = this.btnAddRepo;
            this.colAdd.Name = "colAdd";
            this.colAdd.Width = 20;
            // 
            // btnAddRepo
            // 
            this.btnAddRepo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnAddRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAddRepo.Name = "btnAddRepo";
            this.btnAddRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colRemove
            // 
            this.colRemove.ColumnEdit = this.btnRemove;
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 20;
            // 
            // btnRemove
            // 
            this.btnRemove.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnRemove.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, false, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnDeleteSignatory
            // 
            this.btnDeleteSignatory.AutoHeight = false;
            this.btnDeleteSignatory.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.btnDeleteSignatory.Name = "btnDeleteSignatory";
            this.btnDeleteSignatory.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // chkIsBACMemberRepo
            // 
            this.chkIsBACMemberRepo.AutoHeight = false;
            this.chkIsBACMemberRepo.Name = "chkIsBACMemberRepo";
            // 
            // frmBACCommittees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 268);
            this.Controls.Add(this.BACGridControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.Name = "frmBACCommittees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAC Commiitees";
            this.Load += new System.EventHandler(this.frmBACCommittees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BACGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BACGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditYearRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSignatory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsBACMemberRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl BACGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BACGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinEditYearRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colOffice;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAddRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnRemove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteSignatory;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkIsBACMemberRepo;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}