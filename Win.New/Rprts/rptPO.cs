using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Models;
using Helpers;

namespace Win.Rprts
{
    public partial class rptPO : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPO(PurchaseOrders item)
        {
            InitializeComponent();
            lblOfficeId.PrintOnPage += (s, e) =>
                {
                    lblOfficeId.Text = new StaticSettings().Offices?.OffcAcr + " - " + item.ControlNo;
                };
        }

        private void xrTableCell5_AfterPrint(object sender, EventArgs e)
        {
            if (sender is XRTableCell cell)
            {
                var res = cell.Text.ToDecimal();
                if (res > 0)
                    cell.Text = res.ToString("0,0.00");
                else
                {
                    cell.Text = "";
                }
            }
        }

        private void xrTableCell6_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRTableCell cell)
            {
                var res = cell.Text.ToDecimal();
                if (res > 0)
                    cell.Text = res.ToString("0,0.00");
                else
                {
                    cell.Text = "";
                }
            }
        }

        private void xrLabel37_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
