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
            lbl.Text = new StaticSettings().OfficeId + "-" + item.ControlNo;
        }
    }
}
