﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptAccomplishementReports : DevExpress.XtraReports.UI.XtraReport
    {
        public rptAccomplishementReports()
        {
            InitializeComponent();
        }

        private void lblSystemName_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (sender is XRLabel lbl)
            {
                lbl.Text = $@"Office Fund Management Information System ({User.UserName})" ;
            }
        }
    }
}

