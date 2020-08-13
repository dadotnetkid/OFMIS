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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDashboard));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.colOBR_PR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionTakenGridControl = new DevExpress.XtraGrid.GridControl();
            this.ActionTakenGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActionTaken = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoutedTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.dtTo = new DevExpress.XtraEditors.DateEdit();
            this.dtFrom = new DevExpress.XtraEditors.DateEdit();
            this.cboUsers = new DevExpress.XtraEditors.LookUpEdit();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblControlNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTaskDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridView)).BeginInit();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DashboardGridControl
            // 
            this.DashboardGridControl.DataSource = this.documentActionsBindingSource;
            this.DashboardGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardGridControl.Location = new System.Drawing.Point(0, 53);
            this.DashboardGridControl.MainView = this.DashboardGridView;
            this.DashboardGridControl.Name = "DashboardGridControl";
            this.DashboardGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lblControlNo,
            this.btnAddAction,
            this.btnTaskDone});
            this.DashboardGridControl.Size = new System.Drawing.Size(1179, 244);
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
            this.colDone,
            this.colOBR_PR,
            this.colYear,
            this.colTotalAmount});
            this.DashboardGridView.GridControl = this.DashboardGridControl;
            this.DashboardGridView.Name = "DashboardGridView";
            this.DashboardGridView.OptionsView.ShowGroupPanel = false;
            this.DashboardGridView.RowHeight = 40;
            this.DashboardGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.DashboardGridView_FocusedRowChanged);
            // 
            // colTalbleName
            // 
            this.colTalbleName.Caption = "Type of Document";
            this.colTalbleName.FieldName = "TableName";
            this.colTalbleName.Name = "colTalbleName";
            this.colTalbleName.Visible = true;
            this.colTalbleName.VisibleIndex = 2;
            this.colTalbleName.Width = 102;
            // 
            // colControlNo
            // 
            this.colControlNo.Caption = "ControlNo";
            this.colControlNo.ColumnEdit = this.lblControlNo;
            this.colControlNo.FieldName = "ControlNo";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 1;
            this.colControlNo.Width = 137;
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
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 211;
            // 
            // colFrom
            // 
            this.colFrom.Caption = "From";
            this.colFrom.FieldName = "CreatedByUsers.FullName";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 6;
            this.colFrom.Width = 154;
            // 
            // colAssignedTo
            // 
            this.colAssignedTo.Caption = "Assigned To";
            this.colAssignedTo.FieldName = "RoutedToUsers";
            this.colAssignedTo.Name = "colAssignedTo";
            this.colAssignedTo.Visible = true;
            this.colAssignedTo.VisibleIndex = 8;
            this.colAssignedTo.Width = 99;
            // 
            // colTask
            // 
            this.colTask.Caption = "Task";
            this.colTask.FieldName = "Remarks";
            this.colTask.Name = "colTask";
            this.colTask.Visible = true;
            this.colTask.VisibleIndex = 7;
            this.colTask.Width = 155;
            // 
            // colAddAction
            // 
            this.colAddAction.ColumnEdit = this.btnAddAction;
            this.colAddAction.Name = "colAddAction";
            this.colAddAction.Visible = true;
            this.colAddAction.VisibleIndex = 9;
            this.colAddAction.Width = 46;
            // 
            // btnAddAction
            // 
            this.btnAddAction.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.btnAddAction.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
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
            this.colDone.VisibleIndex = 10;
            this.colDone.Width = 48;
            // 
            // btnTaskDone
            // 
            this.btnTaskDone.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.btnTaskDone.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnTaskDone.Name = "btnTaskDone";
            this.btnTaskDone.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnTaskDone.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnTaskDone_ButtonClick);
            // 
            // colOBR_PR
            // 
            this.colOBR_PR.Caption = "ObR/PR No";
            this.colOBR_PR.FieldName = "ObR_PR_No";
            this.colOBR_PR.Name = "colOBR_PR";
            this.colOBR_PR.Visible = true;
            this.colOBR_PR.VisibleIndex = 3;
            this.colOBR_PR.Width = 81;
            // 
            // colYear
            // 
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Year";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 0;
            this.colYear.Width = 62;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Caption = "Amount";
            this.colTotalAmount.DisplayFormat.FormatString = "#,#.00##";
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 5;
            this.colTotalAmount.Width = 59;
            // 
            // ActionTakenGridControl
            // 
            this.ActionTakenGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionTakenGridControl.Location = new System.Drawing.Point(0, 297);
            this.ActionTakenGridControl.MainView = this.ActionTakenGridView;
            this.ActionTakenGridControl.Name = "ActionTakenGridControl";
            this.ActionTakenGridControl.Size = new System.Drawing.Size(1179, 249);
            this.ActionTakenGridControl.TabIndex = 1;
            this.ActionTakenGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ActionTakenGridView});
            // 
            // ActionTakenGridView
            // 
            this.ActionTakenGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateCreated,
            this.colActionDate,
            this.colCreatedBy,
            this.colActionTaken,
            this.colRoutedTo,
            this.colRemarks});
            this.ActionTakenGridView.GridControl = this.ActionTakenGridControl;
            this.ActionTakenGridView.Name = "ActionTakenGridView";
            this.ActionTakenGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colDateCreated
            // 
            this.colDateCreated.Caption = "Date Created";
            this.colDateCreated.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss tt";
            this.colDateCreated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDateCreated.FieldName = "DateCreated";
            this.colDateCreated.Name = "colDateCreated";
            this.colDateCreated.Visible = true;
            this.colDateCreated.VisibleIndex = 0;
            // 
            // colActionDate
            // 
            this.colActionDate.Caption = "Action Date";
            this.colActionDate.FieldName = "ActionDate";
            this.colActionDate.Name = "colActionDate";
            this.colActionDate.Visible = true;
            this.colActionDate.VisibleIndex = 1;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.Caption = "By";
            this.colCreatedBy.FieldName = "CreatedByUser.FullName";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.Visible = true;
            this.colCreatedBy.VisibleIndex = 2;
            // 
            // colActionTaken
            // 
            this.colActionTaken.Caption = "Action";
            this.colActionTaken.FieldName = "ActionTaken";
            this.colActionTaken.Name = "colActionTaken";
            this.colActionTaken.Visible = true;
            this.colActionTaken.VisibleIndex = 3;
            // 
            // colRoutedTo
            // 
            this.colRoutedTo.Caption = "Routed To";
            this.colRoutedTo.FieldName = "RoutedUsers";
            this.colRoutedTo.Name = "colRoutedTo";
            this.colRoutedTo.Visible = true;
            this.colRoutedTo.VisibleIndex = 4;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "Remarks";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 5;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.dtTo);
            this.pnlSearch.Controls.Add(this.dtFrom);
            this.pnlSearch.Controls.Add(this.cboUsers);
            this.pnlSearch.Controls.Add(this.labelControl3);
            this.pnlSearch.Controls.Add(this.labelControl2);
            this.pnlSearch.Controls.Add(this.labelControl1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1179, 53);
            this.pnlSearch.TabIndex = 2;
            // 
            // dtTo
            // 
            this.dtTo.EditValue = null;
            this.dtTo.Location = new System.Drawing.Point(214, 25);
            this.dtTo.Name = "dtTo";
            this.dtTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo.Size = new System.Drawing.Size(100, 20);
            this.dtTo.TabIndex = 2;
            this.dtTo.EditValueChanged += new System.EventHandler(this.dtTo_EditValueChanged);
            // 
            // dtFrom
            // 
            this.dtFrom.EditValue = null;
            this.dtFrom.Location = new System.Drawing.Point(86, 25);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom.Size = new System.Drawing.Size(100, 20);
            this.dtFrom.TabIndex = 2;
            this.dtFrom.EditValueChanged += new System.EventHandler(this.dtTo_EditValueChanged);
            // 
            // cboUsers
            // 
            this.cboUsers.Location = new System.Drawing.Point(86, 4);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUsers.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "")});
            this.cboUsers.Properties.DataSource = this.usersBindingSource;
            this.cboUsers.Properties.DisplayMember = "FullName";
            this.cboUsers.Properties.NullText = "";
            this.cboUsers.Properties.ValueMember = "Id";
            this.cboUsers.Size = new System.Drawing.Size(228, 20);
            this.cboUsers.TabIndex = 1;
            this.cboUsers.EditValueChanged += new System.EventHandler(this.cboUsers_EditValueChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(192, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(16, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "To:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "From:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Show tasks of:";
            // 
            // UCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DashboardGridControl);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.ActionTakenGridControl);
            this.Name = "UCDashboard";
            this.Size = new System.Drawing.Size(1179, 546);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblControlNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTaskDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionTakenGridView)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
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
        private DevExpress.XtraGrid.GridControl ActionTakenGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ActionTakenGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDateCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colActionTaken;
        private DevExpress.XtraGrid.Columns.GridColumn colRoutedTo;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colOBR_PR;
        private System.Windows.Forms.Panel pnlSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit cboUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraEditors.DateEdit dtFrom;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraEditors.DateEdit dtTo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
    }
}
