using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Helpers;

namespace Win.Rprts
{
    public partial class rptPIS : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPIS()
        {
            InitializeComponent();
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRTableCell cell)
            {
                if (cell.Text.ToString().ToDecimal() <= 0)
                    cell.Text = "";
            }
        }

        private void xrLabel37_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var lbl = sender as XRLabel;
            StaticSettings staticSettings = new StaticSettings();
            lbl.Text = $@"[{staticSettings.Offices?.OffcAcr}] Office Fund Information Management System ({User.UserName})";
        }
    }
}
