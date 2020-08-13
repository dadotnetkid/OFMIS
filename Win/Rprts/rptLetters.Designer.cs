namespace Win.Rprts
{
    partial class rptLetters
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptLetters));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrRichText2 = new DevExpress.XtraReports.UI.XRRichText();
            this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lblOfficeName = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.lblAddress = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTelno = new DevExpress.XtraReports.UI.XRLabel();
            this.grpTitle = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.lblTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.grpAddressing = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrRichText3 = new DevExpress.XtraReports.UI.XRRichText();
            this.lblDate = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lblPosition = new DevExpress.XtraReports.UI.XRLabel();
            this.lblSignatories = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lblCC = new DevExpress.XtraReports.UI.XRLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 75F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine2,
            this.xrLabel44,
            this.xrLabel43});
            this.BottomMargin.HeightF = 75F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new System.Drawing.Font("Calibri", 8F);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(0F, 1.999982F);
            this.xrLabel44.Multiline = true;
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(575.782F, 14.98716F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel44.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel44_BeforePrint);
            // 
            // xrLabel43
            // 
            this.xrLabel43.Font = new System.Drawing.Font("Calibri", 8F);
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(575.782F, 2F);
            this.xrLabel43.Multiline = true;
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(99.21796F, 14.98716F);
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "GO-PITD";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText2});
            this.Detail.HeightF = 203.0001F;
            this.Detail.Name = "Detail";
            // 
            // xrRichText2
            // 
            this.xrRichText2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "[Body]")});
            this.xrRichText2.Font = new System.Drawing.Font("Calibri", 12F);
            this.xrRichText2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrRichText2.Name = "xrRichText2";
            this.xrRichText2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText2.SerializableRtfString = resources.GetString("xrRichText2.SerializableRtfString");
            this.xrRichText2.SizeF = new System.Drawing.SizeF(674.9998F, 203.0001F);
            // 
            // xrRichText1
            // 
            this.xrRichText1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrRichText1.Name = "xrRichText1";
            this.xrRichText1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
            this.xrRichText1.SizeF = new System.Drawing.SizeF(675F, 82.99999F);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText1});
            this.ReportHeader.HeightF = 82.99999F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblOfficeName});
            this.GroupHeader1.HeightF = 38.95833F;
            this.GroupHeader1.Level = 3;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // lblOfficeName
            // 
            this.lblOfficeName.Font = new System.Drawing.Font("Book Antiqua", 14F, System.Drawing.FontStyle.Bold);
            this.lblOfficeName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblOfficeName.Multiline = true;
            this.lblOfficeName.Name = "lblOfficeName";
            this.lblOfficeName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblOfficeName.SizeF = new System.Drawing.SizeF(674.9999F, 38.95833F);
            this.lblOfficeName.StylePriority.UseFont = false;
            this.lblOfficeName.StylePriority.UseTextAlignment = false;
            this.lblOfficeName.Text = "lblOfficeName";
            this.lblOfficeName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.lblAddress,
            this.lblTelno});
            this.GroupHeader2.Font = new System.Drawing.Font("Calibri", 9F);
            this.GroupHeader2.HeightF = 51.25001F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.StylePriority.UseFont = false;
            // 
            // xrLine1
            // 
            this.xrLine1.BorderWidth = 2F;
            this.xrLine1.LineWidth = 2F;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 13F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(675F, 2F);
            this.xrLine1.StylePriority.UseBorderWidth = false;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblAddress.LocationFloat = new DevExpress.Utils.PointFloat(327.0833F, 0F);
            this.lblAddress.Multiline = true;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblAddress.SizeF = new System.Drawing.SizeF(347.9167F, 13F);
            this.lblAddress.StylePriority.UseFont = false;
            this.lblAddress.StylePriority.UseTextAlignment = false;
            this.lblAddress.Text = "lblAddress";
            this.lblAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblTelno
            // 
            this.lblTelno.LocationFloat = new DevExpress.Utils.PointFloat(1.986821E-05F, 0F);
            this.lblTelno.Multiline = true;
            this.lblTelno.Name = "lblTelno";
            this.lblTelno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTelno.SizeF = new System.Drawing.SizeF(327.0833F, 13F);
            this.lblTelno.StylePriority.UseTextAlignment = false;
            this.lblTelno.Text = "lblTelno";
            this.lblTelno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // grpTitle
            // 
            this.grpTitle.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTitle});
            this.grpTitle.Font = new System.Drawing.Font("Calibri", 18F);
            this.grpTitle.HeightF = 28.20832F;
            this.grpTitle.Level = 1;
            this.grpTitle.Name = "grpTitle";
            this.grpTitle.StylePriority.UseFont = false;
            this.grpTitle.StylePriority.UseTextAlignment = false;
            this.grpTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Title]")});
            this.lblTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblTitle.Multiline = true;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTitle.SizeF = new System.Drawing.SizeF(675F, 28.20832F);
            this.lblTitle.Text = "lblTitle";
            // 
            // grpAddressing
            // 
            this.grpAddressing.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrRichText3,
            this.lblDate});
            this.grpAddressing.HeightF = 131.7085F;
            this.grpAddressing.Name = "grpAddressing";
            // 
            // xrRichText3
            // 
            this.xrRichText3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Html", "[InsideAddress]")});
            this.xrRichText3.Font = new System.Drawing.Font("Calibri", 12F);
            this.xrRichText3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 49.63703F);
            this.xrRichText3.Name = "xrRichText3";
            this.xrRichText3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrRichText3.SerializableRtfString = resources.GetString("xrRichText3.SerializableRtfString");
            this.xrRichText3.SizeF = new System.Drawing.SizeF(674.9998F, 72.07146F);
            // 
            // lblDate
            // 
            this.lblDate.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Date]")});
            this.lblDate.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.lblDate.Multiline = true;
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDate.SizeF = new System.Drawing.SizeF(343.75F, 18.83332F);
            this.lblDate.Text = "Date";
            this.lblDate.TextFormatString = "{0:MMMM d, yyyy}";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPosition,
            this.lblSignatories});
            this.GroupFooter1.HeightF = 46.00002F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // lblPosition
            // 
            this.lblPosition.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SignatoriesPosition]")});
            this.lblPosition.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPosition.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.lblPosition.Multiline = true;
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPosition.SizeF = new System.Drawing.SizeF(674.9998F, 23F);
            this.lblPosition.StylePriority.UseFont = false;
            this.lblPosition.StylePriority.UseTextAlignment = false;
            this.lblPosition.Tag = "signatories";
            this.lblPosition.Text = "lblPosition";
            this.lblPosition.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lblSignatories
            // 
            this.lblSignatories.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Signatories]")});
            this.lblSignatories.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSignatories.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblSignatories.Multiline = true;
            this.lblSignatories.Name = "lblSignatories";
            this.lblSignatories.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblSignatories.SizeF = new System.Drawing.SizeF(674.9998F, 23F);
            this.lblSignatories.StylePriority.UseFont = false;
            this.lblSignatories.StylePriority.UseTextAlignment = false;
            this.lblSignatories.Tag = "signatories";
            this.lblSignatories.Text = "lblSignatories";
            this.lblSignatories.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCC});
            this.GroupFooter2.HeightF = 23F;
            this.GroupFooter2.Level = 1;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // lblCC
            // 
            this.lblCC.Font = new System.Drawing.Font("Calibri", 8F);
            this.lblCC.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 0F);
            this.lblCC.Multiline = true;
            this.lblCC.Name = "lblCC";
            this.lblCC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCC.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.lblCC.StylePriority.UseFont = false;
            this.lblCC.Text = "lblCC";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Models.Letters);
            // 
            // xrLine2
            // 
            this.xrLine2.BorderWidth = 2F;
            this.xrLine2.LineWidth = 2F;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(675F, 2F);
            this.xrLine2.StylePriority.UseBorderWidth = false;
            // 
            // rptLetters
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupHeader2,
            this.grpTitle,
            this.grpAddressing,
            this.GroupFooter1,
            this.GroupFooter2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.bindingSource1});
            this.DataSource = this.bindingSource1;
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Margins = new System.Drawing.Printing.Margins(100, 75, 75, 75);
            this.PageHeight = 1300;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrRichText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRRichText xrRichText1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        public DevExpress.XtraReports.UI.XRLabel lblOfficeName;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        public DevExpress.XtraReports.UI.XRLabel lblAddress;
        public DevExpress.XtraReports.UI.XRLabel lblTelno;
        public DevExpress.XtraReports.UI.GroupHeaderBand grpTitle;
        public DevExpress.XtraReports.UI.XRLabel lblTitle;
        public DevExpress.XtraReports.UI.GroupHeaderBand grpAddressing;
        private DevExpress.XtraReports.UI.XRLabel lblDate;
        private DevExpress.XtraReports.UI.XRRichText xrRichText2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel lblPosition;
        private DevExpress.XtraReports.UI.XRLabel lblSignatories;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRRichText xrRichText3;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        public DevExpress.XtraReports.UI.XRLabel lblCC;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLabel xrLabel43;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
    }
}
