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
using Win.Rprts;

namespace Win.LR
{
    public partial class UCLR : DevExpress.XtraEditors.XtraUserControl
    {
        private Obligations obligations;

        public UCLR(Obligations obligations)
        {
            InitializeComponent();
            this.obligations = obligations;
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.LRGridControl.DataSource = unitOfWork.LiquidationsRepo.Get(x => x.ObRId == obligations.Id);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnEditPORepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LRGridView.GetFocusedRow() is Liquidations item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.LiquidationsRepo.Find(x => x.Id == item.Id);
                frmAddEditLR frm = new frmAddEditLR(item, MethodType.Edit);
                frm.ShowDialog();
                Init();
            }
        }

      
        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LRGridView.GetFocusedRow() is Liquidations item)
            {

                if (MessageBox.Show("Do you want to delete this?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.LiquidationsRepo.Delete(x => x.Id == item.Id);
                unitOfWork.Save();
                Init();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditLR frm = new frmAddEditLR(new Liquidations() {ObRId = this.obligations.Id}, MethodType.Add);
            frm.ShowDialog();
            Init();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (LRGridView.GetFocusedRow() is Liquidations item)
                {
                    frmReportViewer frm = new frmReportViewer(new rptLR()
                    {
                        DataSource = new UnitOfWork().LiquidationsRepo.Get(x=>x.Id==item.Id)
                    });
                    frm.ShowDialog();
                }

              
            }
            catch (Exception exception)
            {
                
            }
        }
    }
}
