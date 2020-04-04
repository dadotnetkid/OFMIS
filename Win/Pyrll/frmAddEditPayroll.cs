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

        public frmAddEditPayroll(MethodType methodType, int obId)
        {
            InitializeComponent();
            this.addEditPayroll = new AddEditPayroll(this, obId) { methodType = methodType };
            addEditPayroll.Init();
        }
    }
}