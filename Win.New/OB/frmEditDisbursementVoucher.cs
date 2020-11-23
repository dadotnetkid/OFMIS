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

namespace Win.OB
{
    public partial class frmEditDisbursementVoucher : DevExpress.XtraEditors.XtraForm
    {
        private EditDisbursementVoucher EditDV;

        public frmEditDisbursementVoucher(Obligations item)
        {
            InitializeComponent();
            this.EditDV = new EditDisbursementVoucher(this, item);
            EditDV.Init();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (((XtraForm)this).ValidateForm())
                EditDV.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditDisbursementVoucher_Load(object sender, EventArgs e)
        {

        }

        private void txtAmount_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}