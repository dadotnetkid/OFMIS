namespace Win.Cnfg
{
    partial class frmConfigurations
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
            this.btnEditPo = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPO = new DevExpress.XtraEditors.SimpleButton();
            this.txtServerIp = new DevExpress.XtraEditors.TextEdit();
            this.chkIsUpdateServer = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerIp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsUpdateServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditPo
            // 
            this.btnEditPo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditPo.Appearance.Options.UseFont = true;
            this.btnEditPo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEditPo.Location = new System.Drawing.Point(211, 74);
            this.btnEditPo.Name = "btnEditPo";
            this.btnEditPo.Size = new System.Drawing.Size(75, 26);
            this.btnEditPo.TabIndex = 6;
            this.btnEditPo.TabStop = false;
            this.btnEditPo.Text = "Cancel";
            // 
            // btnNewPO
            // 
            this.btnNewPO.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNewPO.Appearance.Options.UseFont = true;
            this.btnNewPO.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnNewPO.Location = new System.Drawing.Point(130, 74);
            this.btnNewPO.Name = "btnNewPO";
            this.btnNewPO.Size = new System.Drawing.Size(75, 26);
            this.btnNewPO.TabIndex = 5;
            this.btnNewPO.TabStop = false;
            this.btnNewPO.Text = "Submit";
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(13, 23);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(273, 20);
            this.txtServerIp.TabIndex = 7;
            // 
            // chkIsUpdateServer
            // 
            this.chkIsUpdateServer.Location = new System.Drawing.Point(13, 50);
            this.chkIsUpdateServer.Name = "chkIsUpdateServer";
            this.chkIsUpdateServer.Properties.Caption = "is Update Server";
            this.chkIsUpdateServer.Size = new System.Drawing.Size(273, 18);
            this.chkIsUpdateServer.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Server/IP";
            // 
            // frmConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 111);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkIsUpdateServer);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.btnEditPo);
            this.Controls.Add(this.btnNewPO);
            this.MaximumSize = new System.Drawing.Size(300, 204);
            this.Name = "frmConfigurations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurations";
            ((System.ComponentModel.ISupportInitialize)(this.txtServerIp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsUpdateServer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEditPo;
        private DevExpress.XtraEditors.SimpleButton btnNewPO;
        private DevExpress.XtraEditors.TextEdit txtServerIp;
        private DevExpress.XtraEditors.CheckEdit chkIsUpdateServer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}