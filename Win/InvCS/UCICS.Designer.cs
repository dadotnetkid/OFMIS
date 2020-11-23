namespace Win.InvCS
{
    partial class UCICS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCICS));
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
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.ICSGridControl = new DevExpress.XtraGrid.GridControl();
            this.ICSGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssuer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colReceiver = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICSGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICSGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPQRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePQRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1097, 32);
            this.panelControl1.TabIndex = 3;
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
            this.btnPreview.TabIndex = 14;
            this.btnPreview.Text = "Preview";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "Add New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ICSGridControl
            // 
            this.ICSGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ICSGridControl.Location = new System.Drawing.Point(0, 32);
            this.ICSGridControl.MainView = this.ICSGridView;
            this.ICSGridControl.Name = "ICSGridControl";
            this.ICSGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPQRepo,
            this.btnDeletePQRepo});
            this.ICSGridControl.Size = new System.Drawing.Size(1097, 491);
            this.ICSGridControl.TabIndex = 4;
            this.ICSGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ICSGridView});
            // 
            // ICSGridView
            // 
            this.ICSGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colIssuer,
            this.colEdit,
            this.colDelete,
            this.colReceiver});
            this.ICSGridView.GridControl = this.ICSGridControl;
            this.ICSGridView.Name = "ICSGridView";
            this.ICSGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 222;
            // 
            // colIssuer
            // 
            this.colIssuer.FieldName = "Issuer";
            this.colIssuer.Name = "colIssuer";
            this.colIssuer.Visible = true;
            this.colIssuer.VisibleIndex = 3;
            this.colIssuer.Width = 311;
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.btnEditPQRepo;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 1;
            this.colEdit.Width = 39;
            // 
            // btnEditPQRepo
            // 
            this.btnEditPQRepo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditPQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditPQRepo.Name = "btnEditPQRepo";
            this.btnEditPQRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditPQRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditPQRepo_ButtonClick);
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeletePQRepo;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 39;
            // 
            // btnDeletePQRepo
            // 
            this.btnDeletePQRepo.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnDeletePQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeletePQRepo.Name = "btnDeletePQRepo";
            this.btnDeletePQRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeletePQRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeletePQRepo_ButtonClick);
            // 
            // colReceiver
            // 
            this.colReceiver.Caption = "Receiver";
            this.colReceiver.FieldName = "Receiver";
            this.colReceiver.Name = "colReceiver";
            this.colReceiver.Visible = true;
            this.colReceiver.VisibleIndex = 4;
            this.colReceiver.Width = 461;
            // 
            // UCICS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ICSGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCICS";
            this.Size = new System.Drawing.Size(1097, 523);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ICSGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICSGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPQRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePQRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnPreview;
        public DevExpress.XtraEditors.SimpleButton btnNew;
        public DevExpress.XtraGrid.GridControl ICSGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView ICSGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIssuer;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPQRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePQRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiver;
    }
}
