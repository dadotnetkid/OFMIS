﻿namespace Win.Accnts
{
    partial class frmAddEditAppropriation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAppropriation));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountCodeText = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountName = new DevExpress.XtraEditors.TextEdit();
            this.txtAppropriationAmount = new DevExpress.XtraEditors.SpinEdit();
            this.cboFundType = new DevExpress.XtraEditors.LookUpEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewAccount = new DevExpress.XtraEditors.SimpleButton();
            this.txtAccountCode = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            this.colAccountCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFundType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountCodeText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppropriationAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFundType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(482, 54);
            this.panel1.TabIndex = 29;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Arial", 18F);
            this.lblHeader.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Appearance.Options.UseForeColor = true;
            this.lblHeader.Location = new System.Drawing.Point(97, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(143, 27);
            this.lblHeader.TabIndex = 12;
            this.lblHeader.Text = "Appropriation";
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 16);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "Account Code *";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(125, 16);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Account Code Text*";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(13, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 16);
            this.labelControl3.TabIndex = 30;
            this.labelControl3.Text = "Fund Type";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 164);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 16);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Account Name";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 190);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(45, 16);
            this.labelControl5.TabIndex = 31;
            this.labelControl5.Text = "Amount";
            // 
            // txtAccountCodeText
            // 
            this.txtAccountCodeText.Location = new System.Drawing.Point(170, 109);
            this.txtAccountCodeText.Name = "txtAccountCodeText";
            this.txtAccountCodeText.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountCodeText.Properties.Appearance.Options.UseFont = true;
            this.txtAccountCodeText.Properties.ReadOnly = true;
            this.txtAccountCodeText.Properties.UseReadOnlyAppearance = false;
            this.txtAccountCodeText.Size = new System.Drawing.Size(300, 24);
            this.txtAccountCodeText.TabIndex = 1;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(170, 161);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountName.Properties.Appearance.Options.UseFont = true;
            this.txtAccountName.Properties.ReadOnly = true;
            this.txtAccountName.Properties.UseReadOnlyAppearance = false;
            this.txtAccountName.Size = new System.Drawing.Size(300, 24);
            this.txtAccountName.TabIndex = 3;
            // 
            // txtAppropriationAmount
            // 
            this.txtAppropriationAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAppropriationAmount.EnterMoveNextControl = true;
            this.txtAppropriationAmount.Location = new System.Drawing.Point(170, 187);
            this.txtAppropriationAmount.Name = "txtAppropriationAmount";
            this.txtAppropriationAmount.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAppropriationAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAppropriationAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtAppropriationAmount.Properties.DisplayFormat.FormatString = "n2";
            this.txtAppropriationAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAppropriationAmount.Properties.EditFormat.FormatString = "n2";
            this.txtAppropriationAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtAppropriationAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtAppropriationAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtAppropriationAmount.Size = new System.Drawing.Size(300, 24);
            this.txtAppropriationAmount.TabIndex = 4;
            this.txtAppropriationAmount.Tag = "Amount is Required";
            // 
            // cboFundType
            // 
            this.cboFundType.Location = new System.Drawing.Point(170, 135);
            this.cboFundType.Name = "cboFundType";
            this.cboFundType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFundType.Properties.Appearance.Options.UseFont = true;
            this.cboFundType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFundType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FundType", "FundType"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description")});
            this.cboFundType.Properties.DisplayMember = "FundType";
            this.cboFundType.Properties.NullText = "";
            this.cboFundType.Properties.ReadOnly = true;
            this.cboFundType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboFundType.Properties.UseReadOnlyAppearance = false;
            this.cboFundType.Properties.ValueMember = "FundType";
            this.cboFundType.Size = new System.Drawing.Size(300, 24);
            this.cboFundType.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(365, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.AutoSize = true;
            this.btnNewAccount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAccount.ImageOptions.Image")));
            this.btnNewAccount.Location = new System.Drawing.Point(450, 84);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new System.Drawing.Size(22, 22);
            this.btnNewAccount.TabIndex = 32;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.EnterMoveNextControl = true;
            this.txtAccountCode.Location = new System.Drawing.Point(170, 83);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAccountCode.Properties.Appearance.Options.UseFont = true;
            this.txtAccountCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAccountCode.Properties.DisplayMember = "AccountCode";
            this.txtAccountCode.Properties.NullText = "";
            this.txtAccountCode.Properties.PopupFormSize = new System.Drawing.Size(500, 0);
            this.txtAccountCode.Properties.PopupView = this.searchLookUpEdit1View;
            this.txtAccountCode.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.UseEditorWidth;
            this.txtAccountCode.Properties.ValueMember = "AccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(280, 24);
            this.txtAccountCode.TabIndex = 0;
            this.txtAccountCode.Tag = "Account Code is Required";
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountCode,
            this.colFundType,
            this.colAccountName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSaveAndClose.Appearance.Options.UseFont = true;
            this.btnSaveAndClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSaveAndClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAndClose.ImageOptions.Image")));
            this.btnSaveAndClose.Location = new System.Drawing.Point(258, 215);
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            this.btnSaveAndClose.Size = new System.Drawing.Size(101, 31);
            this.btnSaveAndClose.TabIndex = 5;
            this.btnSaveAndClose.Text = "Save ";
            this.btnSaveAndClose.Click += new System.EventHandler(this.btnSaveAndClose_Click);
            // 
            // colAccountCode
            // 
            this.colAccountCode.Caption = "Account Code";
            this.colAccountCode.FieldName = "AccountCode";
            this.colAccountCode.MaxWidth = 90;
            this.colAccountCode.MinWidth = 60;
            this.colAccountCode.Name = "colAccountCode";
            this.colAccountCode.Visible = true;
            this.colAccountCode.VisibleIndex = 0;
            this.colAccountCode.Width = 60;
            // 
            // colFundType
            // 
            this.colFundType.Caption = "Type";
            this.colFundType.FieldName = "FundTypes.FundType";
            this.colFundType.MaxWidth = 50;
            this.colFundType.MinWidth = 50;
            this.colFundType.Name = "colFundType";
            this.colFundType.Visible = true;
            this.colFundType.VisibleIndex = 1;
            this.colFundType.Width = 50;
            // 
            // colAccountName
            // 
            this.colAccountName.Caption = "AccountName";
            this.colAccountName.FieldName = "AccountName";
            this.colAccountName.Name = "colAccountName";
            this.colAccountName.Visible = true;
            this.colAccountName.VisibleIndex = 2;
            // 
            // frmAddEditAppropriation
            // 
            this.AcceptButton = this.btnSaveAndClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 255);
            this.Controls.Add(this.btnSaveAndClose);
            this.Controls.Add(this.btnNewAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.txtAccountCodeText);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAppropriationAmount);
            this.Controls.Add(this.cboFundType);
            this.Controls.Add(this.txtAccountCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(484, 287);
            this.Name = "frmAddEditAppropriation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Appropriation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditAppropriation_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountCodeText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAppropriationAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFundType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public DevExpress.XtraEditors.TextEdit txtAccountCodeText;
        public DevExpress.XtraEditors.TextEdit txtAccountName;
        public DevExpress.XtraEditors.SpinEdit txtAppropriationAmount;
        public DevExpress.XtraEditors.LookUpEdit cboFundType;
        public DevExpress.XtraEditors.SimpleButton btnNewAccount;
        public DevExpress.XtraEditors.SearchLookUpEdit txtAccountCode;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn colFundType;
        private DevExpress.XtraEditors.SimpleButton btnSaveAndClose;
    }
}