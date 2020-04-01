﻿namespace Win.PO
{
    partial class UCPO
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPO));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.POGridControl = new DevExpress.XtraGrid.GridControl();
            this.entityServerModeSource2 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.POGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurpose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.POGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPQRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePQRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "Id ASC";
            this.entityServerModeSource1.ElementType = typeof(Models.PODetails);
            this.entityServerModeSource1.KeyExpression = "Id";
            // 
            // POGridControl
            // 
            this.POGridControl.DataSource = this.entityServerModeSource2;
            this.POGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.POGridControl.Location = new System.Drawing.Point(0, 32);
            this.POGridControl.MainView = this.POGridView;
            this.POGridControl.Name = "POGridControl";
            this.POGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPQRepo,
            this.btnDeletePQRepo});
            this.POGridControl.Size = new System.Drawing.Size(931, 346);
            this.POGridControl.TabIndex = 3;
            this.POGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.POGridView});
            // 
            // entityServerModeSource2
            // 
            this.entityServerModeSource2.DefaultSorting = "Id ASC";
            this.entityServerModeSource2.ElementType = typeof(Models.PriceQuotations);
            this.entityServerModeSource2.KeyExpression = "Id";
            // 
            // POGridView
            // 
            this.POGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colControlNo,
            this.colDescription,
            this.colPurpose,
            this.colEdit,
            this.colDelete});
            this.POGridView.GridControl = this.POGridControl;
            this.POGridView.Name = "POGridView";
            this.POGridView.OptionsView.ShowGroupPanel = false;
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
            this.colControlNo.FieldName = "ControlNo";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 3;
            this.colControlNo.Width = 142;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
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
            this.colEdit.Width = 20;
            // 
            // btnEditPQRepo
            // 
            this.btnEditPQRepo.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnEditPQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditPQRepo.Name = "btnEditPQRepo";
            this.btnEditPQRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeletePQRepo;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 20;
            // 
            // btnDeletePQRepo
            // 
            this.btnDeletePQRepo.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnDeletePQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeletePQRepo.Name = "btnDeletePQRepo";
            this.btnDeletePQRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNew);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(931, 32);
            this.panelControl1.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNew.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 23);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "Add New";
            // 
            // UCPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.POGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCPO";
            this.Size = new System.Drawing.Size(931, 378);
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.POGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPQRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePQRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        public DevExpress.XtraGrid.GridControl POGridControl;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource2;
        public DevExpress.XtraGrid.Views.Grid.GridView POGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPurpose;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPQRepo;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePQRepo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnNew;
    }
}
