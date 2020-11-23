namespace Win.Itnrry
{
    partial class UCIteneraryOfTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCIteneraryOfTravel));
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
            this.IOTGridControl = new DevExpress.XtraGrid.GridControl();
            this.itenaryofTravelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IOTGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployees = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurpose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditPQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.coldelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeletePQRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IOTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenaryofTravelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IOTGridView)).BeginInit();
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
            this.panelControl1.Size = new System.Drawing.Size(1082, 32);
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
            // IOTGridControl
            // 
            this.IOTGridControl.DataSource = this.itenaryofTravelsBindingSource;
            this.IOTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IOTGridControl.Location = new System.Drawing.Point(0, 32);
            this.IOTGridControl.MainView = this.IOTGridView;
            this.IOTGridControl.Name = "IOTGridControl";
            this.IOTGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditPQRepo,
            this.btnDeletePQRepo});
            this.IOTGridControl.Size = new System.Drawing.Size(1082, 588);
            this.IOTGridControl.TabIndex = 5;
            this.IOTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.IOTGridView});
            // 
            // itenaryofTravelsBindingSource
            // 
            this.itenaryofTravelsBindingSource.DataSource = typeof(Models.ItenaryofTravels);
            // 
            // IOTGridView
            // 
            this.IOTGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployees,
            this.colPurpose,
            this.colDateCreated,
            this.colEdit,
            this.coldelete});
            this.IOTGridView.GridControl = this.IOTGridControl;
            this.IOTGridView.Name = "IOTGridView";
            this.IOTGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployees
            // 
            this.colEmployees.FieldName = "Employees.EmployeeName";
            this.colEmployees.Name = "colEmployees";
            this.colEmployees.Visible = true;
            this.colEmployees.VisibleIndex = 2;
            this.colEmployees.Width = 336;
            // 
            // colPurpose
            // 
            this.colPurpose.FieldName = "Purpose";
            this.colPurpose.Name = "colPurpose";
            this.colPurpose.Visible = true;
            this.colPurpose.VisibleIndex = 3;
            this.colPurpose.Width = 336;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Date Created";
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 4;
            this.colDateCreated.Width = 345;
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
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnEditPQRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnEditPQRepo.Name = "btnEditPQRepo";
            this.btnEditPQRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEditPQRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditPQRepo_ButtonClick);
            // 
            // coldelete
            // 
            this.coldelete.ColumnEdit = this.btnDeletePQRepo;
            this.coldelete.Name = "coldelete";
            this.coldelete.Visible = true;
            this.coldelete.VisibleIndex = 0;
            this.coldelete.Width = 20;
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
            // UCIteneraryOfTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IOTGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "UCIteneraryOfTravel";
            this.Size = new System.Drawing.Size(1082, 620);
            this.Load += new System.EventHandler(this.UCItenaryOfTravel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IOTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itenaryofTravelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IOTGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditPQRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeletePQRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btnPreview;
        public DevExpress.XtraEditors.SimpleButton btnNew;
        public DevExpress.XtraGrid.GridControl IOTGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView IOTGridView;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditPQRepo;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeletePQRepo;
        private System.Windows.Forms.BindingSource itenaryofTravelsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colPurpose;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn coldelete;
    }
}
