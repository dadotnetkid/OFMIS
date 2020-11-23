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
using Helpers;
using Models;
using Win.BL;

namespace Win.Accnts
{
    public partial class frmAddEditAppropriation : DevExpress.XtraEditors.XtraForm
    {

        public frmAddEditAppropriation(MethodType methodType, Appropriations item)
        {
            InitializeComponent();
            this.AddEditAppropriation = new AddEditAppropriation(this, item) { methodType = methodType };
            AddEditAppropriation.Init();
        }

        public AddEditAppropriation AddEditAppropriation { get; set; }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditAppropriation_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddEditAppropriation.Close(e);
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            AddEditAppropriation.isClosed = false;
            if (((XtraForm)this).ValidateForm())
            {
                AddEditAppropriation.Save();
                AddEditAppropriation.isClosed = true;
            }
        }
    }
}