using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptObligationRequests : DevExpress.XtraReports.UI.XtraReport
    {
        public rptObligationRequests()
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

        private void xrLabel8_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            txtPreparedBy.Text = User.GetFullName();
            txtPos.Text = User.GetUserPosition();
        }

        private void xrLabel8_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                lbl.Text = User.GetOffice();
            }
        }
    }
}
