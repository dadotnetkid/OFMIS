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
using Models;
using Win.BL;

namespace Win.Pyrll
{
    public partial class frmAddEditPayroll : DevExpress.XtraEditors.XtraForm
    {
        private AddEditPayroll addEditPayroll;

        public frmAddEditPayroll(MethodType methodType, Payrolls payrolls)
        {
            InitializeComponent();
            this.addEditPayroll = new AddEditPayroll(payrolls) {methodType = methodType};
        }
    }
}