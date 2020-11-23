using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptStatusSummaryofFD : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStatusSummaryofFD()
        {
            InitializeComponent();
        }

        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({User.UserName})";
            }
        }

        private void lblOfficeName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.lblOfficeName.Text = User.GetOffice();
        }
    }
}
