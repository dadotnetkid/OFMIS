using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Models;
using System.Linq;

namespace Win.Rprts
{
    public partial class rptLetters : DevExpress.XtraReports.UI.XtraReport
    {
        public rptLetters()
        {
            InitializeComponent();
        }

        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.DataSource is List<Letters> item)
            {
                var res = item.FirstOrDefault();
                if (sender is XRLabel lbl)
                {
                    StaticSettings staticSettings = new StaticSettings();
                    var user = User.GetUserName();
                    lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Management Information System({user}) {res.ControlNo}";
                }
            }
            
        }
    }
}
