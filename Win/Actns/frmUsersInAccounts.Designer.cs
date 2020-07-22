namespace Win.Actns
{
    partial class frmUsersInAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersInAccounts));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtSearch = new DevExpress.XtraEditors.SearchControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.UsersGridControl = new DevExpress.XtraGrid.GridControl();
            this.UsersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(554, 39);
            this.panelControl1.TabIndex = 0;
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(Models.Users);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnNewPO);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 433);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(554, 44);
            this.panelControl2.TabIndex = 1;
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
            // UsersGridControl
            // 
            this.UsersGridControl.DataSource = this.usersBindingSource;
            this.UsersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersGridControl.Location = new System.Drawing.Point(0, 39);
            this.UsersGridControl.MainView = this.UsersGridView;
            this.UsersGridControl.Name = "UsersGridControl";
            this.UsersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.UsersGridControl.Size = new System.Drawing.Size(554, 394);
            this.UsersGridControl.TabIndex = 2;
            this.UsersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.UsersGridView});
            // 
            // UsersGridView
            // 
            this.UsersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colOffices,
            this.colIsSelected});
            this.UsersGridView.GridControl = this.UsersGridControl;
            this.UsersGridView.Name = "UsersGridView";
            this.UsersGridView.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.UsersGridView.OptionsSelection.CheckBoxSelectorField = "IsSelectedUserInDocuments";
            this.UsersGridView.OptionsSelection.MultiSelect = true;
            this.UsersGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.UsersGridView.OptionsView.ShowGroupPanel = false;
            this.UsersGridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.UsersGridView_RowCellClick);
            this.UsersGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.UsersGridView_CellValueChanged);
            this.UsersGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.UsersGridView_RowUpdated);
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
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
            // frmUsersInAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 477);
            this.Controls.Add(this.UsersGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsersInAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users in Accounts";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SearchControl txtSearch;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl UsersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView UsersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colOffices;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}