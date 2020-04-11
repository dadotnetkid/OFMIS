using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Models;

namespace Win.Rprts
{
    public partial class rptPO : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPO(PurchaseOrders item)
        {
            InitializeComponent();
            lblOfficeId.PrintOnPage += (s, e) =>
                {
                    lblOfficeId.Text = new StaticSettings().OfficeId + " - " + item.ControlNo;
                };
        }


    }
}
