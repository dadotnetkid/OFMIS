using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptEmployees : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEmployees()
        {
            InitializeComponent();
        }

        private void lblOffice_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            lblOffice.Text = User.GetOffice();
        }

        private void xrLabel63_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({User.UserName})";
            }
        }
    }
}
