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

namespace Win.PropAckRcpt
{
    public partial class UCPAR : DevExpress.XtraEditors.XtraUserControl
    {
        private PurchaseRequests purchaseRequests;
        private MethodType methodType;

        public UCPAR(PurchaseRequests purchaseRequests)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            this.Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.PARGridControl.DataSource = unitOfWork.PARRepo.Get(x => x.PRId == purchaseRequests.Id);
            }
            catch (Exception e)
            {

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditPAR frmAddEditPAR = new frmAddEditPAR(new PAR() { PRId = purchaseRequests.Id }, MethodType.Add);
                frmAddEditPAR.ShowDialog();
                Init();
            }
            catch (Exception exception)
            {

            }
        }

        private void btnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.PARGridView.GetFocusedRow() is PAR item)
                {
                    frmAddEditPAR frm = new frmAddEditPAR(new UnitOfWork().PARRepo.Find(x => x.Id == item.Id), MethodType.Edit);
                    frm.ShowDialog();
                    Init();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.PARGridView.GetFocusedRow() is PAR item)
                {
                    if (!User.UserInAction("can delete"))
                        return;
                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PARRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.PARGridView.GetFocusedRow() is PAR item)
            {
                frmReportViewer frm = new frmReportViewer(new rptPAR()
                {
                    DataSource = new UnitOfWork().PARRepo.Get(x => x.Id == item.Id)
                });
                frm.ShowDialog();
            }}
    }
}
