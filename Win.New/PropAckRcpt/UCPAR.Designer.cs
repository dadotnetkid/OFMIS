﻿namespace Win.PropAckRcpt
{
    partial class UCPAR
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPAR));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.PARGridControl = new DevExpress.XtraGrid.GridControl();
            this.pARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PARGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurpose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PARGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARGridView)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1227, 32);
            this.panelControl1.TabIndex = 2;
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
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
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
            // PARGridControl
            // 
            this.PARGridControl.DataSource = this.pARBindingSource;
            this.PARGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PARGridControl.Location = new System.Drawing.Point(0, 32);
            this.PARGridControl.MainView = this.PARGridView;
            this.PARGridControl.Name = "PARGridControl";
            this.PARGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPQRepo,
            this.btnDeletePQRepo});
            this.PARGridControl.Size = new System.Drawing.Size(1227, 794);
            this.PARGridControl.TabIndex = 3;
            this.PARGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PARGridView});
            // 
            // pARBindingSource
            // 
            this.pARBindingSource.DataSource = typeof(Models.PAR);
            // 
            // PARGridView
            // 
            this.PARGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colControlNo,
            this.colDescription,
            this.colPurpose,
            this.colEdit,
            this.colDelete,
            this.colItem});
            this.PARGridView.GridControl = this.PARGridControl;
            this.PARGridView.Name = "PARGridView";
            this.PARGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 2;
            this.colDate.Width = 112;
            // 
            // colControlNo
            // 
            this.colControlNo.FieldName = "IssuedBy";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 4;
            this.colControlNo.Width = 142;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "ReceivedBy";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            this.colDescription.Width = 313;
            // 
            // colPurpose
            // 
            this.colPurpose.FieldName = "Purpose";
            this.colPurpose.Name = "colPurpose";
            // 
            // colEdit
            // 
            this.colEdit.ColumnEdit = this.btnEditPQRepo;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 1;
            this.colEdit.Width = 35;
            // 
            // btnEditPQRepo
            // 
            this.btnEditPQRepo.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnEditPQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.colDelete.Width = 35;
            // 
            // btnDeletePQRepo
            // 
            this.btnDeletePQRepo.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnDeletePQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeletePQRepo.Name = "btnDeletePQRepo";
            this.btnDeletePQRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeletePQRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeletePQRepo_ButtonClick);
            // 
            // colItem
            // 
            this.colItem.Caption = "Item";
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 3;
            // 
            // UCPAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PARGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCPAR";
            this.Size = new System.Drawing.Size(1227, 826);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PARGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PARGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPQRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePQRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnPreview;
        public DevExpress.XtraEditors.SimpleButton btnNew;
        public DevExpress.XtraGrid.GridControl PARGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView PARGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPurpose;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPQRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePQRepo;
        private System.Windows.Forms.BindingSource pARBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
    }
}
