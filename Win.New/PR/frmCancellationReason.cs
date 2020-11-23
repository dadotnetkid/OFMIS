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
using Models.Repository;

namespace Win.PR
{
    public partial class frmCancellationReason : DevExpress.XtraEditors.XtraForm
    {
        private int PRId;

        public frmCancellationReason(int PRId)
        {
            InitializeComponent();
            this.PRId = PRId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var pr = unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == PRId);
                pr.CancellationReason = txtReason.Text;
                unitOfWork.Save();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();}
    }
}