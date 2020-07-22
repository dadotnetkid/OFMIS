namespace Win.Actns
{
    partial class UCDashboard
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashboard));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.DashboardGridControl = new DevExpress.XtraGrid.GridControl();
            this.documentActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DashboardGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTalbleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblControlNo = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssignedTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTask = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAddAction = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnTaskDone = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblControlNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTaskDone)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardGridControl
            // 
            this.DashboardGridControl.DataSource = this.documentActionsBindingSource;
            this.DashboardGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardGridControl.Location = new System.Drawing.Point(0, 0);
            this.DashboardGridControl.MainView = this.DashboardGridView;
            this.DashboardGridControl.Name = "DashboardGridControl";
            this.DashboardGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lblControlNo,
            this.btnAddAction,
            this.btnTaskDone});
            this.DashboardGridControl.Size = new System.Drawing.Size(1179, 546);
            this.DashboardGridControl.TabIndex = 0;
            this.DashboardGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DashboardGridView});
            // 
            // documentActionsBindingSource
            // 
            this.documentActionsBindingSource.DataSource = typeof(Models.DocumentActions);
            // 
            // DashboardGridView
            // 
            this.DashboardGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTalbleName,
            this.colControlNo,
            this.colDescription,
            this.colFrom,
            this.colAssignedTo,
            this.colTask,
            this.colAddAction,
            this.colDone});
            this.DashboardGridView.GridControl = this.DashboardGridControl;
            this.DashboardGridView.Name = "DashboardGridView";
            this.DashboardGridView.OptionsView.ShowGroupPanel = false;
            this.DashboardGridView.RowHeight = 40;
            // 
            // colTalbleName
            // 
            this.colTalbleName.Caption = "Transactions";
            this.colTalbleName.FieldName = "TableName";
            this.colTalbleName.Name = "colTalbleName";
            this.colTalbleName.Visible = true;
            this.colTalbleName.VisibleIndex = 0;
            this.colTalbleName.Width = 109;
            // 
            // colControlNo
            // 
            this.colControlNo.Caption = "ControlNo";
            this.colControlNo.ColumnEdit = this.lblControlNo;
            this.colControlNo.FieldName = "ControlNo";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 1;
            this.colControlNo.Width = 164;
            // 
            // lblControlNo
            // 
            this.lblControlNo.AutoHeight = false;
            this.lblControlNo.Name = "lblControlNo";
            this.lblControlNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.lblControlNumber_ButtonClick);
            this.lblControlNo.Click += new System.EventHandler(this.lblControlNo_Click);
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 263;
            // 
            // colFrom
            // 
            this.colFrom.Caption = "From";
            this.colFrom.FieldName = "CreatedByUsers.FullName";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 3;
            this.colFrom.Width = 195;
            // 
            // colAssignedTo
            // 
            this.colAssignedTo.Caption = "Assigned To";
            this.colAssignedTo.FieldName = "RoutedToUsers";
            this.colAssignedTo.Name = "colAssignedTo";
            this.colAssignedTo.Visible = true;
            this.colAssignedTo.VisibleIndex = 4;
            this.colAssignedTo.Width = 126;
            // 
            // colTask
            // 
            this.colTask.Caption = "Task";
            this.colTask.FieldName = "Remarks";
            this.colTask.Name = "colTask";
            this.colTask.Visible = true;
            this.colTask.VisibleIndex = 5;
            this.colTask.Width = 197;
            // 
            // colAddAction
            // 
            this.colAddAction.ColumnEdit = this.btnAddAction;
            this.colAddAction.Name = "colAddAction";
            this.colAddAction.Visible = true;
            this.colAddAction.VisibleIndex = 6;
            this.colAddAction.Width = 59;
            // 
            // btnAddAction
            // 
            this.btnAddAction.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnAddAction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnAddAction.Name = "btnAddAction";
            this.btnAddAction.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnAddAction.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnAddAction_ButtonClick);
            // 
            // colDone
            // 
            this.colDone.Caption = " ";
            this.colDone.ColumnEdit = this.btnTaskDone;
            this.colDone.Name = "colDone";
            this.colDone.Visible = true;
            this.colDone.VisibleIndex = 7;
            this.colDone.Width = 41;
            // 
            // btnTaskDone
            // 
            this.btnTaskDone.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.btnTaskDone.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnTaskDone.Name = "btnTaskDone";
            this.btnTaskDone.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnTaskDone.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnTaskDone_ButtonClick);
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DashboardGridControl);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(1179, 546);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblControlNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTaskDone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl DashboardGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView DashboardGridView;
        private System.Windows.Forms.BindingSource documentActionsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTalbleName;
        private DevExpress.XtraGrid.Columns.GridColumn colControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignedTo;
        private DevExpress.XtraGrid.Columns.GridColumn colTask;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit lblControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAddAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnAddAction;
        private DevExpress.XtraGrid.Columns.GridColumn colDone;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnTaskDone;
    }
}
