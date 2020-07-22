namespace Win.Rprts
{
    partial class frmAccomplishmentReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccomplishmentReport));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboStaff = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboNotedBy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboReviewedBy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dtDateTo = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.ReviewedByEntitySource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StaffEntityServerSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.colStaff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NotedEntityServerSource = new DevExpress.Data.Linq.EntityServerModeSource();
            ((System.ComponentModel.ISupportInitialize)(this.cboStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNotedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboReviewedBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewedByEntitySource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffEntityServerSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotedEntityServerSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(53, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Staff";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Noted By:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Reviewed By:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(24, 75);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Date From";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(37, 95);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Date To";
            // 
            // cboStaff
            // 
            this.cboStaff.EditValue = "";
            this.cboStaff.Location = new System.Drawing.Point(83, 12);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStaff.Properties.DataSource = this.StaffEntityServerSource;
            this.cboStaff.Properties.DisplayMember = "FullName";
            this.cboStaff.Properties.PopupView = this.searchLookUpEdit1View;
            this.cboStaff.Properties.ValueMember = "Id";
            this.cboStaff.Size = new System.Drawing.Size(398, 20);
            this.cboStaff.TabIndex = 0;
            this.cboStaff.EditValueChanged += new System.EventHandler(this.cboStaff_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStaff});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cboNotedBy
            // 
            this.cboNotedBy.EditValue = "";
            this.cboNotedBy.Location = new System.Drawing.Point(83, 32);
            this.cboNotedBy.Name = "cboNotedBy";
            this.cboNotedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNotedBy.Properties.DisplayMember = "EmployeeName";
            this.cboNotedBy.Properties.NullText = "";
            this.cboNotedBy.Properties.PopupView = this.gridView1;
            this.cboNotedBy.Properties.ValueMember = "Id";
            this.cboNotedBy.Size = new System.Drawing.Size(398, 20);
            this.cboNotedBy.TabIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPerson});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cboReviewedBy
            // 
            this.cboReviewedBy.EditValue = "";
            this.cboReviewedBy.Location = new System.Drawing.Point(83, 52);
            this.cboReviewedBy.Name = "cboReviewedBy";
            this.cboReviewedBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboReviewedBy.Properties.DataSource = this.ReviewedByEntitySource;
            this.cboReviewedBy.Properties.DisplayMember = "EmployeeName";
            this.cboReviewedBy.Properties.PopupView = this.gridView2;
            this.cboReviewedBy.Properties.ValueMember = "Id";
            this.cboReviewedBy.Size = new System.Drawing.Size(398, 20);
            this.cboReviewedBy.TabIndex = 2;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeName});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // dtDateFrom
            // 
            this.dtDateFrom.EditValue = null;
            this.dtDateFrom.Location = new System.Drawing.Point(83, 72);
            this.dtDateFrom.Name = "dtDateFrom";
            this.dtDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateFrom.Size = new System.Drawing.Size(398, 20);
            this.dtDateFrom.TabIndex = 3;
            // 
            // dtDateTo
            // 
            this.dtDateTo.EditValue = null;
            this.dtDateTo.Location = new System.Drawing.Point(83, 92);
            this.dtDateTo.Name = "dtDateTo";
            this.dtDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDateTo.Size = new System.Drawing.Size(398, 20);
            this.dtDateTo.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(376, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(269, 118);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ReviewedByEntitySource
            // 
            this.ReviewedByEntitySource.DefaultSorting = "Id ASC";
            this.ReviewedByEntitySource.ElementType = typeof(Models.Employees);
            this.ReviewedByEntitySource.KeyExpression = "EmployeeName";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "EmployeeName";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            // 
            // colPerson
            // 
            this.colPerson.FieldName = "EmployeeName";
            this.colPerson.Name = "colPerson";
            this.colPerson.Visible = true;
            this.colPerson.VisibleIndex = 0;
            // 
            // StaffEntityServerSource
            // 
            this.StaffEntityServerSource.ElementType = typeof(Models.Users);
            this.StaffEntityServerSource.KeyExpression = "Id";
            // 
            // colStaff
            // 
            this.colStaff.FieldName = "FullName";
            this.colStaff.Name = "colStaff";
            this.colStaff.Visible = true;
            this.colStaff.VisibleIndex = 0;
            // 
            // NotedEntityServerSource
            // 
            this.NotedEntityServerSource.DefaultSorting = "Id ASC";
            this.NotedEntityServerSource.ElementType = typeof(Models.Signatories);
            this.NotedEntityServerSource.KeyExpression = "Id";
            // 
            // frmAccomplishmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 164);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtDateTo);
            this.Controls.Add(this.dtDateFrom);
            this.Controls.Add(this.cboReviewedBy);
            this.Controls.Add(this.cboNotedBy);
            this.Controls.Add(this.cboStaff);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccomplishmentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accomplishment Report";
            this.Load += new System.EventHandler(this.frmAccomplishmentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNotedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboReviewedBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewedByEntitySource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffEntityServerSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotedEntityServerSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SearchLookUpEdit cboStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.Data.Linq.EntityServerModeSource StaffEntityServerSource;
        private DevExpress.XtraEditors.SearchLookUpEdit cboNotedBy;
        private DevExpress.Data.Linq.EntityServerModeSource NotedEntityServerSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cboReviewedBy;
        private DevExpress.Data.Linq.EntityServerModeSource ReviewedByEntitySource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.DateEdit dtDateFrom;
        private DevExpress.XtraEditors.DateEdit dtDateTo;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colStaff;
        private DevExpress.XtraGrid.Columns.GridColumn colPerson;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
    }
}