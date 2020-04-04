using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Models;
using Win.BL;

namespace Win.Pyrll
{
    public partial class UCPayrolls : DevExpress.XtraEditors.XtraUserControl
    {
        private LoadPayroll loadPayroll;

        public UCPayrolls(int id)
        {
            InitializeComponent();
            this.loadPayroll = new LoadPayroll(this, id);
            loadPayroll.Init();

        }
    }
}
