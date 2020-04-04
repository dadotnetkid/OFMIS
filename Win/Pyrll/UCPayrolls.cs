using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Win.BL;

namespace Win.Pyrll
{
    public partial class UCPayrolls : DevExpress.XtraEditors.XtraUserControl
    {
        private LoadPayroll loadPayroll;

        public UCPayrolls(Payrolls item)
        {
            InitializeComponent();
            this.loadPayroll = new LoadPayroll(this, item);
            loadPayroll.Init();

        }
    }
}
