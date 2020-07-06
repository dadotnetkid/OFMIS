using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptObligationRequestPreview : DevExpress.XtraReports.UI.XtraReport
    {
        public rptObligationRequestPreview()
        {
            InitializeComponent();
            this.BeforePrint += RptObligationRequestPreview_BeforePrint;
        }

        private void RptObligationRequestPreview_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
   
        }

        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                var user = User.GetUserName();
                lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({user})";
            }
        }
    }
}
