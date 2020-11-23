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
using Models.Repository;
using Models;

namespace Win.InvCS
{
    public partial class UCICS : DevExpress.XtraEditors.XtraUserControl
    {
        private int prId;

        public UCICS(int prId)
        {
            InitializeComponent();
            this.prId = prId;
            this.Init();

        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.ICSGridControl.DataSource = unitOfWork.ICSRepo.Get(x => x.PRId == prId);
            }
            catch (Exception e)
            {

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditICS frm = new frmAddEditICS(null, Models.MethodType.Add);
            frm.ShowDialog();
            Init();
        }

        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.ICSGridView.GetFocusedRow() is ICS item)
            {

                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ICSRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.ICSGridView.GetFocusedRow() is ICS item)
            {
                frmAddEditICS frm = new frmAddEditICS(item, MethodType.Edit);
                frm.ShowDialog();
                Init();

            }
        }
    }
}
