namespace Win.Accnts
{
    partial class UCEarmarkPR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEarmarkPR));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.EarmarkGridControl = new DevExpress.XtraGrid.GridControl();
            this.purchaseRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EarmarkGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colControlNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurpose = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnOBREdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.spinAmountRepo = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.spinAmount = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.EarmarkGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EarmarkGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOBREdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmountRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // EarmarkGridControl
            // 
            this.EarmarkGridControl.DataSource = this.purchaseRequestsBindingSource;
            this.EarmarkGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EarmarkGridControl.Location = new System.Drawing.Point(0, 0);
            this.EarmarkGridControl.MainView = this.EarmarkGridView;
            this.EarmarkGridControl.Name = "EarmarkGridControl";
            this.EarmarkGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnOBREdit,
            this.spinAmountRepo,
            this.spinAmount});
            this.EarmarkGridControl.Size = new System.Drawing.Size(944, 456);
            this.EarmarkGridControl.TabIndex = 1;
            this.EarmarkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EarmarkGridView});
            // 
            // purchaseRequestsBindingSource
            // 
            this.purchaseRequestsBindingSource.DataSource = typeof(Models.PurchaseRequests);
            // 
            // EarmarkGridView
            // 
            this.EarmarkGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colControlNo,
            this.colDescription,
            this.colPurpose,
            this.colTotalAmount});
            this.EarmarkGridView.GridControl = this.EarmarkGridControl;
            this.EarmarkGridView.Name = "EarmarkGridView";
            this.EarmarkGridView.OptionsBehavior.ReadOnly = true;
            this.EarmarkGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colControlNo
            // 
            this.colControlNo.FieldName = "ControlNo";
            this.colControlNo.Name = "colControlNo";
            this.colControlNo.Visible = true;
            this.colControlNo.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colPurpose
            // 
            this.colPurpose.FieldName = "Purpose";
            this.colPurpose.Name = "colPurpose";
            this.colPurpose.Visible = true;
            this.colPurpose.VisibleIndex = 3;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.ColumnEdit = this.spinAmount;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 4;
            // 
            // btnOBREdit
            // 
            this.btnOBREdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnOBREdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnOBREdit.Name = "btnOBREdit";
            this.btnOBREdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // spinAmountRepo
            // 
            this.spinAmountRepo.AutoHeight = false;
            this.spinAmountRepo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmountRepo.DisplayFormat.FormatString = "#,#.00##";
            this.spinAmountRepo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmountRepo.EditFormat.FormatString = "#,#.00##";
            this.spinAmountRepo.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmountRepo.Name = "spinAmountRepo";
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.EarmarkGridControl;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.EarmarkGridControl);
            this.gridSplitContainer1.Size = new System.Drawing.Size(944, 456);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // spinAmount
            // 
            this.spinAmount.AutoHeight = false;
            this.spinAmount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAmount.DisplayFormat.FormatString = "#,#.00##";
            this.spinAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmount.EditFormat.FormatString = "#,#.00##";
            this.spinAmount.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.spinAmount.Name = "spinAmount";
            // 
            // UCEarmarkPR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSplitContainer1);
            this.Name = "UCEarmarkPR";
            this.Size = new System.Drawing.Size(944, 456);
            ((System.ComponentModel.ISupportInitialize)(this.EarmarkGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EarmarkGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOBREdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAmountRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraGrid.GridControl EarmarkGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView EarmarkGridView;
        public DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnOBREdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinAmountRepo;
        private System.Windows.Forms.BindingSource purchaseRequestsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colControlNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPurpose;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spinAmount;
    }
}
