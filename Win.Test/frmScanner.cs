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

namespace Win.Test
{
    public partial class frmScanner : DevExpress.XtraEditors.XtraForm
    {
        WiaWrapper wia = new WiaWrapper();
        public frmScanner()
        {
            InitializeComponent();
            wia.SelectScanner();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            wia.Scan(new PageSize() { Height = 11, Width = 8.5 }, true, 300, @"c:\", true, false);
        }
    }
}