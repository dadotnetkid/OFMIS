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

namespace Win.Accnts
{
    public partial class frmAddEditReAlignment : DevExpress.XtraEditors.XtraForm
    {
        private AddEditRealignment addEditRealignment;


        public frmAddEditReAlignment(MethodType methodType, ReAlignments item)
        {
            InitializeComponent();
            this.addEditRealignment = new AddEditRealignment(this, item) { methodType = methodType };
            addEditRealignment.Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addEditRealignment.Save();
        }

        private void frmAddEditReAlignment_FormClosing(object sender, FormClosingEventArgs e)
        {
            addEditRealignment.Close(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}