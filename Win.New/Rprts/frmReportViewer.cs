using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class frmReportViewer : DevExpress.XtraEditors.XtraForm
    {
        public frmReportViewer(XtraReport xtraReport)
        {
            InitializeComponent();
            this.documentViewer1.DocumentSource = xtraReport;
            xtraReport.CreateDocument();
        }
    }
}