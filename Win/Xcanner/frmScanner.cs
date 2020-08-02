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
using Models.ViewModels;

namespace Win.Xcanner
{
    public partial class frmScanner : DevExpress.XtraEditors.XtraForm
    {
        private Scanners scanner;

        public frmScanner(Action<Scanners> scanner)
        {
            InitializeComponent();
            scanner(this.scanner);
        }
    }
}