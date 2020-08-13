using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptOBRPayrollWages : DevExpress.XtraReports.UI.XtraReport
    {
        private int curRow=0;

        public rptOBRPayrollWages()
        {
            InitializeComponent();
        }

        private void xrLabel63_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({User.UserName})";
            }
        }

        private void xrTableCell4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRTableCell lbl)
            {
                lbl.Text = lbl.Text.Replace("-", "");
            }
        }

        private void xrPageBreak1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
        
        }
    }
}
