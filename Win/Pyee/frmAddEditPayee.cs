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

namespace Win.OB
{
    public partial class frmAddEditPayee : DevExpress.XtraEditors.XtraForm
    {
        private AddEditPayees addEditLoadPayees;

        public frmAddEditPayee(MethodType methodType, Payees payees)
        {
            InitializeComponent();
            this.addEditLoadPayees = new AddEditPayees(this, payees) { methodType = methodType };
            addEditLoadPayees.Init();
        }

        private void frmAddEditPayee_Load(object sender, EventArgs e)
        {
            addEditLoadPayees.Detail();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            addEditLoadPayees.Save();
            addEditLoadPayees.isClosed = true;
            this.Close();
        }

        private void frmAddEditPayee_FormClosing(object sender, FormClosingEventArgs e)
        {
            addEditLoadPayees.Close(e);
        }
    }
}