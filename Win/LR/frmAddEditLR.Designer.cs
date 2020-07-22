namespace Win.LR
{
    partial class frmAddEditLR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditLR));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtParticulars = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboPayee = new DevExpress.XtraEditors.LookUpEdit();
            this.cboDepthead = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboAccountant = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtAmount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPeriodCovered = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.signatoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticulars.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPayee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepthead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodCovered.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signatoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(8, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 14);
            this.labelControl4.TabIndex = 87;
            this.labelControl4.Text = "Particulars";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 14);
            this.labelControl1.TabIndex = 86;
            this.labelControl1.Text = "Date*";
            // 
            // dtDate
            // 
            this.dtDate.EditValue = null;
            this.dtDate.Location = new System.Drawing.Point(93, 12);
            this.dtDate.Name = "dtDate";
            this.dtDate.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Properties.Appearance.Options.UseFont = true;
            this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDate.Properties.DisplayFormat.FormatString = "";
            this.dtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.EditFormat.FormatString = "";
            this.dtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDate.Properties.Mask.EditMask = "";
            this.dtDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtDate.Properties.UseReadOnlyAppearance = false;
            this.dtDate.Size = new System.Drawing.Size(355, 20);
            this.dtDate.TabIndex = 0;
            this.dtDate.Tag = "0";
            // 
            // txtParticulars
            // 
            this.txtParticulars.EditValue = "Liquidation of cash advance for the payment of ";
            this.txtParticulars.Location = new System.Drawing.Point(93, 78);
            this.txtParticulars.Name = "txtParticulars";
            this.txtParticulars.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticulars.Properties.Appearance.Options.UseFont = true;
            this.txtParticulars.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtParticulars.Size = new System.Drawing.Size(355, 98);
            this.txtParticulars.TabIndex = 3;
            this.txtParticulars.Tag = "2";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 90;
            this.labelControl3.Text = "Payee";
            // 
            // cboPayee
            // 
            this.cboPayee.EnterMoveNextControl = true;
            this.cboPayee.Location = new System.Drawing.Point(93, 34);
            this.cboPayee.Name = "cboPayee";
            this.cboPayee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPayee.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Employee Name", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Position", "Position", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboPayee.Properties.DataSource = this.employeesBindingSource;
            this.cboPayee.Properties.DisplayMember = "EmployeeName";
            this.cboPayee.Properties.NullText = "";
            this.cboPayee.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboPayee.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboPayee.Properties.UseReadOnlyAppearance = false;
            this.cboPayee.Properties.ValueMember = "Id";
            this.cboPayee.Size = new System.Drawing.Size(355, 20);
            this.cboPayee.TabIndex = 1;
            this.cboPayee.Tag = "1";
            // 
            // cboDepthead
            // 
            this.cboDepthead.EnterMoveNextControl = true;
            this.cboDepthead.Location = new System.Drawing.Point(93, 200);
            this.cboDepthead.Name = "cboDepthead";
            this.cboDepthead.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboDepthead.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Person", "Person", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Position", "Position", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboDepthead.Properties.DataSource = this.signatoriesBindingSource;
            this.cboDepthead.Properties.DisplayMember = "Person";
            this.cboDepthead.Properties.NullText = "";
            this.cboDepthead.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboDepthead.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboDepthead.Properties.UseReadOnlyAppearance = false;
            this.cboDepthead.Properties.ValueMember = "Id";
            this.cboDepthead.Size = new System.Drawing.Size(355, 20);
            this.cboDepthead.TabIndex = 5;
            this.cboDepthead.Tag = "4";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 203);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 90;
            this.labelControl5.Text = "Dept Head";
            // 
            // cboAccountant
            // 
            this.cboAccountant.EnterMoveNextControl = true;
            this.cboAccountant.Location = new System.Drawing.Point(93, 222);
            this.cboAccountant.Name = "cboAccountant";
            this.cboAccountant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboAccountant.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Person", "Person", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Position", "Position", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboAccountant.Properties.DataSource = this.signatoriesBindingSource;
            this.cboAccountant.Properties.DisplayMember = "Person";
            this.cboAccountant.Properties.NullText = "";
            this.cboAccountant.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cboAccountant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboAccountant.Properties.UseReadOnlyAppearance = false;
            this.cboAccountant.Properties.ValueMember = "Id";
            this.cboAccountant.Size = new System.Drawing.Size(355, 20);
            this.cboAccountant.TabIndex = 6;
            this.cboAccountant.Tag = "5";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 225);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 90;
            this.labelControl6.Text = "Accountant";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(236, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Tag = "6";
            this.btnSave.Text = "Submit";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(343, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 31);
            this.btnClose.TabIndex = 8;
            this.btnClose.Tag = "7";
            this.btnClose.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtAmount.Location = new System.Drawing.Point(93, 178);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtAmount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtAmount.Size = new System.Drawing.Size(355, 20);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.Tag = "2";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 181);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 90;
            this.labelControl2.Text = "Amount";
            // 
            // txtPeriodCovered
            // 
            this.txtPeriodCovered.Location = new System.Drawing.Point(93, 56);
            this.txtPeriodCovered.Name = "txtPeriodCovered";
            this.txtPeriodCovered.Properties.UseReadOnlyAppearance = false;
            this.txtPeriodCovered.Size = new System.Drawing.Size(355, 20);
            this.txtPeriodCovered.TabIndex = 2;
            this.txtPeriodCovered.Tag = "1";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(8, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(78, 13);
            this.labelControl7.TabIndex = 90;
            this.labelControl7.Text = "Period Covered";
            // 
            // signatoriesBindingSource
            // 
            this.signatoriesBindingSource.DataSource = typeof(Models.Signatories);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataSource = typeof(Models.Employees);
            // 
            // frmAddEditLR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 287);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cboAccountant);
            this.Controls.Add(this.cboDepthead);
            this.Controls.Add(this.cboPayee);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtParticulars);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtPeriodCovered);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddEditLR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Edit LR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditLR_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditLR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParticulars.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPayee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboDepthead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodCovered.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signatoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit dtDate;
        public DevExpress.XtraEditors.MemoEdit txtParticulars;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LookUpEdit cboPayee;
        public DevExpress.XtraEditors.LookUpEdit cboDepthead;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        public DevExpress.XtraEditors.LookUpEdit cboAccountant;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.BindingSource signatoriesBindingSource;
        private DevExpress.XtraEditors.SpinEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DevExpress.XtraEditors.TextEdit txtPeriodCovered;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}