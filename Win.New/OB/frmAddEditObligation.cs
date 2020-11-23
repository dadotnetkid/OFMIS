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
        public AddEditObligations addEditObligations;

        private ucObligations ucObligations;
        public Obligations obligations;

        //private List<ORDetails> oRDetails = new List<ORDetails>();
        public frmAddEditObligation(MethodType methodType, Obligations obligations)
        {
            InitializeComponent();
            this.addEditObligations = new AddEditObligations(this, obligations) { methodType = methodType };


        }
        public frmAddEditObligation(ucObligations ucObligations, MethodType methodType, Obligations obligations)
        {
            InitializeComponent();
            this.addEditObligations = new AddEditObligations(this, obligations) { methodType = methodType };
            this.ucObligations = ucObligations;
            this.obligations = obligations;
        }

        private void frmAddEditObligation_Load(object sender, EventArgs e)
        {
            tmrSaving.Start();
            addEditObligations.Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (((XtraForm)this).ValidateForm())
            {
                addEditObligations.isPrompt = true;
                addEditObligations.Save();
                this.Close();
                //       ucObligations.obligations = obligations;

            }


            //    this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditObligation_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.addEditObligations.Close(e);
        }

        private void btnAddPayee_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditPayee(MethodType.Add, null);
            frm.ShowDialog();
            addEditObligations.LoadPayees();
        }

        private void tmrSaving_Tick(object sender, EventArgs e)
        {
            addEditObligations.SaveWithoutPromp();
        }
    }
}