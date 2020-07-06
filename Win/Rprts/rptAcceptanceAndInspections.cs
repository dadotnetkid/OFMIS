using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Helpers;

namespace Win.Rprts
{
    public partial class rptAcceptanceAndInspections : DevExpress.XtraReports.UI.XtraReport
    {
        public rptAcceptanceAndInspections()
        {
            InitializeComponent();
        }

        private void xrTableCell1_AfterPrint(object sender, EventArgs e)
        {
        
        }

        private void xrTableCell1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRTableCell item)
            {
                if (item.Text.ToDecimal() <= 0)
                {
                    item.Text = "";
                }
            }
        }

        private void xrLabel26_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({User.UserName}))";
            }
        }
    }
}
