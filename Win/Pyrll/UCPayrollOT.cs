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

namespace Win.Pyrll
{
    public partial class UCPayrollOT : DevExpress.XtraEditors.XtraUserControl
    {
        private int obrId;

        public UCPayrollOT(int obrId)
        {
            InitializeComponent();
            this.obrId = obrId;
            Init();
        }

      async  void Init()
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                this.PayrollDiffGridControl.DataSource = await unitOfWork.PayrollOTRepo.GetAsync(x => x.ObRId == this.obrId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditPayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                if (PayrollDiffGridView.GetFocusedRow() is PayrollOT item)
                {
                    frmAddEditPayrollOT frm = new frmAddEditPayrollOT(MethodType.Edit, item);
                    frm.ShowDialog();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Delete();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        void Delete()
        {
            try
            {
                if (this.PayrollDiffGridView.GetFocusedRow() is PayrollOT item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    unitOfWork.PayrollOTRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditNew_Click(object sender, EventArgs e)
        {

            try
            {
                frmAddEditPayrollOT frm = new frmAddEditPayrollOT(MethodType.Add, new PayrollOT()
                {
                    ObRId = this.obrId
                });
                frm.ShowDialog();
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
