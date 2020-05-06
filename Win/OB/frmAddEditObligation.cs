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
using System.Data.Entity;
using Helpers;
using Models.Repository;

namespace Win.OB
{
    public partial class frmAddEditObligation : XtraForm
    {
        private AddEditObligations obligations;
        //private List<ORDetails> oRDetails = new List<ORDetails>();
        public frmAddEditObligation(MethodType methodType, Obligations obligations)
        {
            InitializeComponent();
            this.obligations = new AddEditObligations(this, obligations) { methodType = methodType };

        }

        private void frmAddEditObligation_Load(object sender, EventArgs e)
        {
            obligations.Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (((XtraForm)this).ValidateForm())
            {
                obligations.Save();
            }


            //    this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditObligation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.obligations.Close(e);
        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPayee(MethodType.Add, null);
            frm.ShowDialog();
            obligations.LoadPayees();
        }
    }
}