using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraReports.UI;
using Models;

namespace Win.Rprts
{
    public partial class rptObligationRequestPreview : DevExpress.XtraReports.UI.XtraReport
    {
        public rptObligationRequestPreview()
        {
            InitializeComponent();
            this.BeforePrint += RptObligationRequestPreview_BeforePrint;
        }

        private void RptObligationRequestPreview_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
   
        }

        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                StaticSettings staticSettings = new StaticSettings();
                var user = User.GetUserName();
                lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({user})";
            }
        }

        private void lblPayeeName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.DataSource is List<Obligations> item)
            {
                if (item.FirstOrDefault().ORDetails.Any(x => x.Appropriations.AccountCode == "50101020"))
                {
                    this.lblPayeeName.BackColor = Color.Pink;
                }
            }
           
        }
    }
}
