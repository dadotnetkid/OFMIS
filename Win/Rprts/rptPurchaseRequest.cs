using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.PR
{
    public partial class rptPurchaseRequest : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPurchaseRequest()
        {
            InitializeComponent();

        }

        private void GrpFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void RptPurchaseRequest_AfterPrint(object sender, EventArgs e)
        {


        }

        private void RptPurchaseRequest_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {



        }

        private void xrLabel63_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                lbl.Text = "[" + staticSettings.Offices.OffcAcr + "]Office Management Information System(" +
                           User.UserName + ")";
            }
        }

        private void xrTableCell6_AfterPrint(object sender, EventArgs e)
        {
       
        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var s = sender as XRTableCell;
            double value = Math.Truncate(Convert.ToDouble(s.Text) * 100) / 100;
            s.Text = value.ToString("n2");
        }

        private void xrLabel7_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
