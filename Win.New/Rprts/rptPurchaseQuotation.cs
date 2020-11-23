using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Models;

namespace Win.Rprts
{
    public partial class rptPurchaseQuotation : DevExpress.XtraReports.UI.XtraReport
    {
        private PriceQuotations item;

        public rptPurchaseQuotation(PriceQuotations item)
        {
            InitializeComponent();
            this.item = item;
            officeId.PrintOnPage += OfficeId_PrintOnPage;
        }



        private void OfficeId_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var lbl = sender as XRLabel;
            lbl.Text = new StaticSettings().Offices.OffcAcr + "-" + item.ControlNo;
        }

        private void xrLabel63_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                lbl.Text = "[" + staticSettings.Offices.OffcAcr + "]Office Management Information System" +
                           User.UserName;
            }
        }
    }
}
