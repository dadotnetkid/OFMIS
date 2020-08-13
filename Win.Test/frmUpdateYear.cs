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
using Models.Repository;

namespace Win.Test
{
    public partial class frmUpdateYear : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateYear()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new ModelDb());

            foreach (var i in unitOfWork.PurchaseRequestsRepo.Get())
            {
                i.Year = 2020;
            }
            unitOfWork.Save();

            MessageBox.Show("Success");

        }
    }
}