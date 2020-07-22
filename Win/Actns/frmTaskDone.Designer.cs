namespace Win.Actns
{
    partial class frmTaskDone
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskDone));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDocuement = new DevExpress.XtraEditors.MemoEdit();
            this.txtTask = new DevExpress.XtraEditors.MemoEdit();
            this.cboAssignedBy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboActionDone = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTaskDone = new DevExpress.XtraEditors.SimpleButton();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.documentActionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocuement.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAssignedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboActionDone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentActionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Document";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Task";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Assigned By:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(64, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Action Done";
            // 
            // txtDocuement
            // 
            this.txtDocuement.Location = new System.Drawing.Point(81, 12);
            this.txtDocuement.Name = "txtDocuement";
            this.txtDocuement.Size = new System.Drawing.Size(496, 33);
            this.txtDocuement.TabIndex = 1;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(81, 47);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(496, 53);
            this.txtTask.TabIndex = 1;
            // 
            // cboAssignedBy
            // 
            this.cboAssignedBy.EditValue = "";
            this.cboAssignedBy.Location = new System.Drawing.Point(81, 101);
            this.cboAssignedBy.Name = "cboAssignedBy";
            this.cboAssignedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAssignedBy.Properties.DataSource = this.usersBindingSource;
            this.cboAssignedBy.Properties.DisplayMember = "FullName";
            this.cboAssignedBy.Properties.NullText = "";
            this.cboAssignedBy.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboAssignedBy.Properties.ValueMember = "Id";
            this.cboAssignedBy.Size = new System.Drawing.Size(496, 20);
            this.cboAssignedBy.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colPosition});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 1;
            // 
            // cboActionDone
            // 
            this.cboActionDone.EditValue = "";
            this.cboActionDone.Location = new System.Drawing.Point(81, 122);
            this.cboActionDone.Name = "cboActionDone";
            this.cboActionDone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboActionDone.Properties.DataSource = this.documentActionsBindingSource;
            this.cboActionDone.Properties.DisplayMember = "Remarks";
            this.cboActionDone.Properties.PopupView = this.gridView1;
            this.cboActionDone.Properties.ValueMember = "Id";
            this.cboActionDone.Size = new System.Drawing.Size(496, 20);
            this.cboActionDone.TabIndex = 2;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRemarks});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnTaskDone
            // 
            this.btnTaskDone.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaskDone.Appearance.Options.UseFont = true;
            this.btnTaskDone.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnTaskDone.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnTaskDone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnTaskDone.Location = new System.Drawing.Point(469, 148);
            this.btnTaskDone.Name = "btnTaskDone";
            this.btnTaskDone.Size = new System.Drawing.Size(108, 23);
            this.btnTaskDone.TabIndex = 13;
            this.btnTaskDone.Text = "Task Done";
            this.btnTaskDone.Click += new System.EventHandler(this.btnTaskDone_Click);
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 0;
            // 
            // documentActionsBindingSource
            // 
            this.documentActionsBindingSource.DataSource = typeof(Models.DocumentActions);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // frmTaskDone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 179);
            this.Controls.Add(this.btnTaskDone);
            this.Controls.Add(this.cboActionDone);
            this.Controls.Add(this.cboAssignedBy);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.txtDocuement);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaskDone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Done";
            this.Load += new System.EventHandler(this.frmTaskDone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocuement.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAssignedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboActionDone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentActionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.MemoEdit txtDocuement;
        private DevExpress.XtraEditors.MemoEdit txtTask;
        private DevExpress.XtraEditors.SearchLookUpEdit cboAssignedBy;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraEditors.SearchLookUpEdit cboActionDone;
        private System.Windows.Forms.BindingSource documentActionsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnTaskDone;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
    }
}