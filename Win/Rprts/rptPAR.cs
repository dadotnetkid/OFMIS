using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptPAR : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPAR()
        {
            InitializeComponent();
        }

        private void xrLabel37_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var lbl = sender as XRLabel;
            StaticSettings staticSettings = new StaticSettings();
            lbl.Text = $@"[{staticSettings.Offices?.OffcAcr}] Office Fund Information Management System ({User.UserName})";
        }
    }
}
