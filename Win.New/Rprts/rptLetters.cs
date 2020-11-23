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
        private string footer;

        public rptLetters()
        {
            InitializeComponent();
        }
        public rptLetters(string footer)
        {
            InitializeComponent();
            this.footer = footer;
        }
        private void xrLabel44_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (this.DataSource is List<Letters> item)
            {
                var res = item.FirstOrDefault(); if (sender is XRLabel lbl)
                {
                    StaticSettings staticSettings = new StaticSettings();
                    var user = User.GetUserName();
                    if (!string.IsNullOrEmpty(footer))
                    {
                        lbl.Text = footer;
                        return;
                    }

                    lbl.Text = $"[{staticSettings.Offices.OffcAcr}]Office Fund Management Information System({user}) {res.ControlNo}";
                }
            }

        }
    }
}
