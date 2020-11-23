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
using Helpers;
namespace Win.Accnts
{
    public partial class frmAddEditAllotment : DevExpress.XtraEditors.XtraForm
    {
        private AddEditAllotment addEditAllotment;

        public frmAddEditAllotment(MethodType methodType, Allotments allotments)
        {
            InitializeComponent();
            this.addEditAllotment = new AddEditAllotment(this, allotments) { methodType = methodType };
            addEditAllotment.Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (((XtraForm) this).ValidateForm())
            {
                addEditAllotment.Save();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditAllotment_FormClosing(object sender, FormClosingEventArgs e)
        {
            addEditAllotment.Close(e);
        }
    }
}