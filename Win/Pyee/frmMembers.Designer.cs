namespace Win.Pyee
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.EmployeesGridControl = new DevExpress.XtraGrid.GridControl();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(561, 39);
            this.panelControl1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.txtSearch.Size = new System.Drawing.Size(538, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // EmployeesGridControl
            // 
            this.EmployeesGridControl.DataSource = this.employeesBindingSource;
            this.EmployeesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesGridControl.Location = new System.Drawing.Point(0, 39);
            this.EmployeesGridControl.MainView = this.EmployeesGridView;
            this.EmployeesGridControl.Name = "EmployeesGridControl";
            this.EmployeesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.EmployeesGridControl.Size = new System.Drawing.Size(561, 511);
            this.EmployeesGridControl.TabIndex = 3;
            this.EmployeesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmployeesGridView});
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(Models.Employees);
            // 
            // EmployeesGridView
            // 
            this.EmployeesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colOffices,
            this.colIsSelected});
            this.EmployeesGridView.GridControl = this.EmployeesGridControl;
            this.EmployeesGridView.Name = "EmployeesGridView";
            this.EmployeesGridView.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.EmployeesGridView.OptionsSelection.CheckBoxSelectorField = "isSelected";
            this.EmployeesGridView.OptionsSelection.MultiSelect = true;
            this.EmployeesGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.EmployeesGridView.OptionsView.ShowGroupPanel = false;
            this.EmployeesGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.EmployeesGridView_CellValueChanged);
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "EmployeeName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.ReadOnly = true;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 253;
            // 
            // colOffices
            // 
            this.colOffices.FieldName = "Offices.OfficeName";
            this.colOffices.Name = "colOffices";
            this.colOffices.Visible = true;
            this.colOffices.VisibleIndex = 2;
            this.colOffices.Width = 256;
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = " ";
            this.colIsSelected.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsSelected.FieldName = "IsSelectedUserInDocuments";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Width = 20;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnNewPO);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 550);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(561, 44);
            this.panelControl2.TabIndex = 4;
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.Location = new System.Drawing.Point(475, 13);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 8;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Submit";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 594);
            this.Controls.Add(this.EmployeesGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private DevExpress.XtraGrid.GridControl EmployeesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView EmployeesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colOffices;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
    }
}