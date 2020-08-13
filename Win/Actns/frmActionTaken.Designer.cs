namespace Win.Actns
{
    partial class frmActionTaken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionTaken));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.ActionTakenGridControl = new DevExpress.XtraGrid.GridControl();
            this.actionTakensBindingSource = new System.Windows.Forms.BindingSource();
            this.ActionTakenGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActionTaken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteRepo = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionTakensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRepo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 54);
            this.panel1.TabIndex = 31;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Location = new System.Drawing.Point(97, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(139, 27);
            this.lblHeader.TabIndex = 9999;
            this.lblHeader.Text = "Action Taken";
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
            // ActionTakenGridControl
            // 
            this.ActionTakenGridControl.DataSource = this.actionTakensBindingSource;
            this.ActionTakenGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionTakenGridControl.Location = new System.Drawing.Point(0, 54);
            this.ActionTakenGridControl.MainView = this.ActionTakenGridView;
            this.ActionTakenGridControl.Name = "ActionTakenGridControl";
            this.ActionTakenGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteRepo});
            this.ActionTakenGridControl.Size = new System.Drawing.Size(587, 397);
            this.ActionTakenGridControl.TabIndex = 32;
            this.ActionTakenGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ActionTakenGridView});
            // 
            // actionTakensBindingSource
            // 
            this.actionTakensBindingSource.DataSource = typeof(Models.ActionTakens);
            // 
            // ActionTakenGridView
            // 
            this.ActionTakenGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colActionTaken,
            this.colDelete});
            this.ActionTakenGridView.GridControl = this.ActionTakenGridControl;
            this.ActionTakenGridView.Name = "ActionTakenGridView";
            this.ActionTakenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.ActionTakenGridView.OptionsView.ShowGroupPanel = false;
            this.ActionTakenGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.ActionTakenGridView_RowUpdated);
            // 
            // colActionTaken
            // 
            this.colActionTaken.FieldName = "ActionTaken";
            this.colActionTaken.Name = "colActionTaken";
            this.colActionTaken.Visible = true;
            this.colActionTaken.VisibleIndex = 1;
            this.colActionTaken.Width = 542;
            // 
            // colDelete
            // 
            this.colDelete.ColumnEdit = this.btnDeleteRepo;
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 0;
            this.colDelete.Width = 47;
            // 
            // btnDeleteRepo
            // 
            this.btnDeleteRepo.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnDeleteRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnDeleteRepo.Name = "btnDeleteRepo";
            this.btnDeleteRepo.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteRepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteRepo_ButtonClick);
            // 
            // frmActionTaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 451);
            this.Controls.Add(this.ActionTakenGridControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActionTaken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Taken";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionTakensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteRepo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraGrid.GridControl ActionTakenGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ActionTakenGridView;
        private System.Windows.Forms.BindingSource actionTakensBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colActionTaken;
        private DevExpress.XtraGrid.Columns.GridColumn colDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteRepo;
    }
}