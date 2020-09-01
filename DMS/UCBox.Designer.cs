namespace DMS
{
    partial class UCBox
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FolderGridControl = new DevExpress.XtraGrid.GridControl();
            this.FolderEntityServerModeSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.FolderGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BoxGridControl = new DevExpress.XtraGrid.GridControl();
            this.BoxEntityServerModeSource = new DevExpress.Data.Linq.EntityServerModeSource();
            this.BoxGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderEntityServerModeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxEntityServerModeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.07692F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.92308F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 715);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.FolderGridControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(341, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.95672F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04329F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 709);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FolderGridControl
            // 
            this.FolderGridControl.DataSource = this.FolderEntityServerModeSource;
            this.FolderGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderGridControl.Location = new System.Drawing.Point(4, 47);
            this.FolderGridControl.MainView = this.FolderGridView;
            this.FolderGridControl.Name = "FolderGridControl";
            this.FolderGridControl.Size = new System.Drawing.Size(948, 530);
            this.FolderGridControl.TabIndex = 2;
            this.FolderGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FolderGridView});
            // 
            // FolderEntityServerModeSource
            // 
            this.FolderEntityServerModeSource.ElementType = typeof(Models.Folders);
            this.FolderEntityServerModeSource.KeyExpression = "Id";
            // 
            // FolderGridView
            // 
            this.FolderGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolderName,
            this.colFolderCode});
            this.FolderGridView.DetailHeight = 377;
            this.FolderGridView.GridControl = this.FolderGridControl;
            this.FolderGridView.Name = "FolderGridView";
            this.FolderGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colFolderName
            // 
            this.colFolderName.FieldName = "FolderName";
            this.colFolderName.Name = "colFolderName";
            this.colFolderName.Visible = true;
            this.colFolderName.VisibleIndex = 1;
            // 
            // colFolderCode
            // 
            this.colFolderCode.FieldName = "FolderCode";
            this.colFolderCode.Name = "colFolderCode";
            this.colFolderCode.Visible = true;
            this.colFolderCode.VisibleIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 36);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BoxGridControl, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(332, 709);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // BoxGridControl
            // 
            this.BoxGridControl.DataSource = this.BoxEntityServerModeSource;
            this.BoxGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoxGridControl.Location = new System.Drawing.Point(4, 48);
            this.BoxGridControl.MainView = this.BoxGridView;
            this.BoxGridControl.Name = "BoxGridControl";
            this.BoxGridControl.Size = new System.Drawing.Size(324, 657);
            this.BoxGridControl.TabIndex = 0;
            this.BoxGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.BoxGridView});
            // 
            // BoxEntityServerModeSource
            // 
            this.BoxEntityServerModeSource.ElementType = typeof(Models.Boxes);
            this.BoxEntityServerModeSource.KeyExpression = "Id";
            // 
            // BoxGridView
            // 
            this.BoxGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colBoxName,
            this.colRemarks,
            this.colBoxCode,
            this.colFolders});
            this.BoxGridView.DetailHeight = 377;
            this.BoxGridView.GridControl = this.BoxGridControl;
            this.BoxGridView.Name = "BoxGridView";
            this.BoxGridView.OptionsView.ShowGroupPanel = false;
            this.BoxGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.BoxGridView_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colBoxName
            // 
            this.colBoxName.FieldName = "BoxName";
            this.colBoxName.Name = "colBoxName";
            this.colBoxName.Visible = true;
            this.colBoxName.VisibleIndex = 1;
            this.colBoxName.Width = 226;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // colBoxCode
            // 
            this.colBoxCode.FieldName = "BoxCode";
            this.colBoxCode.Name = "colBoxCode";
            this.colBoxCode.Visible = true;
            this.colBoxCode.VisibleIndex = 0;
            this.colBoxCode.Width = 73;
            // 
            // colFolders
            // 
            this.colFolders.FieldName = "Folders";
            this.colFolders.Name = "colFolders";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 37);
            this.panel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(64, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(193, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // UCBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "UCBox";
            this.Size = new System.Drawing.Size(1300, 715);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderEntityServerModeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoxGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxEntityServerModeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraGrid.GridControl BoxGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView BoxGridView;
        private DevExpress.Data.Linq.EntityServerModeSource BoxEntityServerModeSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colBoxCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFolders;
        private DevExpress.XtraGrid.GridControl FolderGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView FolderGridView;
        private DevExpress.Data.Linq.EntityServerModeSource FolderEntityServerModeSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFolderName;
        private DevExpress.XtraGrid.Columns.GridColumn colFolderCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
