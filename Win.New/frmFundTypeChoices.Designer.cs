namespace Win
{
    partial class frmFundTypeChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFundTypeChoices));
            this.btnGF = new DevExpress.XtraEditors.SimpleButton();
            this.btnSEF = new DevExpress.XtraEditors.SimpleButton();
            this.btnTF = new DevExpress.XtraEditors.SimpleButton();
            this.btnDf = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnGF
            // 
            this.btnGF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnGF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGF.ImageOptions.SvgImage")));
            this.btnGF.Location = new System.Drawing.Point(13, 12);
            this.btnGF.Name = "btnGF";
            this.btnGF.Size = new System.Drawing.Size(77, 69);
            this.btnGF.TabIndex = 0;
            this.btnGF.Tag = "GF";
            this.btnGF.Text = "RF";
            this.btnGF.ToolTip = "Regular Fund";
            // 
            // btnSEF
            // 
            this.btnSEF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSEF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSEF.ImageOptions.SvgImage")));
            this.btnSEF.Location = new System.Drawing.Point(96, 12);
            this.btnSEF.Name = "btnSEF";
            this.btnSEF.Size = new System.Drawing.Size(77, 69);
            this.btnSEF.TabIndex = 1;
            this.btnSEF.Tag = "SEF";
            this.btnSEF.Text = "SEF";
            this.btnSEF.ToolTip = "Special Education Fund";
            // 
            // btnTF
            // 
            this.btnTF.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTF.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTF.ImageOptions.SvgImage")));
            this.btnTF.Location = new System.Drawing.Point(179, 12);
            this.btnTF.Name = "btnTF";
            this.btnTF.Size = new System.Drawing.Size(77, 69);
            this.btnTF.TabIndex = 2;
            this.btnTF.Tag = "TF";
            this.btnTF.Text = "TF";
            this.btnTF.ToolTip = "Trust Fund";
            // 
            // btnDf
            // 
            this.btnDf.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnDf.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDf.ImageOptions.SvgImage")));
            this.btnDf.Location = new System.Drawing.Point(262, 12);
            this.btnDf.Name = "btnDf";
            this.btnDf.Size = new System.Drawing.Size(93, 69);
            this.btnDf.TabIndex = 3;
            this.btnDf.Tag = "DF_20%";
            this.btnDf.Text = "DF 20%";
            this.btnDf.ToolTip = "Development Fund(20%)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(361, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(93, 69);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Tag = "DF_5%";
            this.simpleButton1.Text = "DF 5%";
            this.simpleButton1.ToolTip = "Development Fund(5%)";
            // 
            // frmFundTypeChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 102);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnDf);
            this.Controls.Add(this.btnTF);
            this.Controls.Add(this.btnSEF);
            this.Controls.Add(this.btnGF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(471, 134);
            this.MinimumSize = new System.Drawing.Size(471, 134);
            this.Name = "frmFundTypeChoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fund Type";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGF;
        private DevExpress.XtraEditors.SimpleButton btnSEF;
        private DevExpress.XtraEditors.SimpleButton btnTF;
        private DevExpress.XtraEditors.SimpleButton btnDf;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}