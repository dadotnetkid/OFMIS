using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Pyrll
{
    public partial class UCPayrolls : DevExpress.XtraEditors.XtraUserControl
    {
        private LoadPayroll loadPayroll;
        private int obrId;

        public UCPayrolls(int id)
        {
            InitializeComponent();
            this.loadPayroll = new LoadPayroll(this, id);
            loadPayroll.Init();
            this.obrId = id;
        }

        private void btnPrintRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollsRepo.Delete(x => x.Id == obrId);
                unitOfWork.Save();
                this.loadPayroll.Init();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
