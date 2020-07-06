namespace Win.Actns
{
    partial class frmAddEditDocActionTree
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
            this.lblParent = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblvalue = new DevExpress.XtraEditors.LabelControl();
            this.txtOrder = new DevExpress.XtraEditors.TextEdit();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.txtParent = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParent
            // 
            this.lblParent.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblParent.Appearance.Options.UseFont = true;
            this.lblParent.Location = new System.Drawing.Point(14, 61);
            this.lblParent.Name = "lblParent";
            this.lblParent.Size = new System.Drawing.Size(51, 17);
            this.lblParent.TabIndex = 0;
            this.lblParent.Text = "Program";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Sort Order";
            // 
            // lblvalue
            // 
            this.lblvalue.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblvalue.Appearance.Options.UseFont = true;
            this.lblvalue.Location = new System.Drawing.Point(13, 121);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(40, 17);
            this.lblvalue.TabIndex = 0;
            this.lblvalue.Text = "Project";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(104, 88);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOrder.Properties.Appearance.Options.UseFont = true;
            this.txtOrder.Size = new System.Drawing.Size(377, 24);
            this.txtOrder.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(104, 118);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtValue.Properties.Appearance.Options.UseFont = true;
            this.txtValue.Size = new System.Drawing.Size(377, 24);
            this.txtValue.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblHeader.Appearance.Options.UseFont = true;
            this.lblHeader.Location = new System.Drawing.Point(13, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(44, 32);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "xxxx";
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.Location = new System.Drawing.Point(406, 148);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(75, 26);
            this.btnEditPo.TabIndex = 4;
            this.btnEditPo.TabStop = false;
            this.btnEditPo.Text = "Cancel";
            this.btnEditPo.Click += new System.EventHandler(this.btnEditPo_Click);
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.Location = new System.Drawing.Point(325, 148);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 3;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Submit";
            this.btnNewPO.Click += new System.EventHandler(this.btnNewPO_Click);
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(104, 58);
            this.txtParent.Name = "txtParent";
            this.txtParent.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtParent.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtParent.Properties.Appearance.Options.UseFont = true;
            this.txtParent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtParent.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category", "Category", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 42, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtParent.Properties.DataSource = typeof(Models.Actions);
            this.txtParent.Properties.DisplayMember = "Value";
            this.txtParent.Properties.NullText = "";
            this.txtParent.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtParent.Properties.ValueMember = "Id";
            this.txtParent.Size = new System.Drawing.Size(377, 24);
            this.txtParent.TabIndex = 0;
            // 
            // frmAddEditDocActionTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 186);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnNewPO);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lblParent);
            this.Controls.Add(this.txtParent);
            this.MaximumSize = new System.Drawing.Size(495, 235);
            this.Name = "frmAddEditDocActionTree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit";
            this.Load += new System.EventHandler(this.frmAddEditDocActionTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblParent;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblvalue;
        private DevExpress.XtraEditors.TextEdit txtOrder;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraEditors.LookUpEdit txtParent;
    }
}