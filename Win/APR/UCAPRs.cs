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
using Helpers;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;

namespace Win.APR
{
    public partial class UCAPRs : DevExpress.XtraEditors.XtraUserControl, ILoad<APRs>
    {
        private PurchaseRequests pr;

        public UCAPRs(PurchaseRequests pr)
        {
            InitializeComponent();
            this.pr = pr;
            Init();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.APRGridControl.DataSource = unitOfWork.APRsRepo.Get(x => x.PRId == pr.Id);

            }
            catch (Exception e)
            {

            }
        }

        public void Detail(APRs item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditAPR frm = new frmAddEditAPR(MethodType.Add, new APRs() { PRId = this.pr.Id });
            frm.ShowDialog();
            Init();
        }

        private void btnEditPORepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (APRGridView.GetFocusedRow() is APRs item)
            {
                frmAddEditAPR frm = new frmAddEditAPR(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }

        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (!User.UserInAction("can delete"))
                return;
            if (APRGridView.GetFocusedRow() is APRs item)
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork(false, false);
                TrashbinHelper trashbinHelper = new TrashbinHelper();
                item = unitOfWork.APRsRepo.Find(x => x.Id == item.Id, false, includeProperties: "APRDetails");
                trashbinHelper.Delete(item, "APRs", "APRs", User.UserId,
                    new StaticSettings().OfficeId);
                unitOfWork.APRsRepo.Delete(x => x.Id == item.Id);
                unitOfWork.Save();
                Init();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (APRGridView.GetFocusedRow() is APRs item)
            {
                var list = new UnitOfWork().APRsRepo.Find(x => x.Id == item.Id);
                //if (list.APRDetails.Count < 32)
                //{
                //    var counter = 32 - list.APRDetails.Count;
                //    for (var i = 1; i <= counter; i++)
                //    {
                //        list.APRDetails.Add(new APRDetails());
                //    }
                //}

                frmReportViewer frm = new frmReportViewer(new rptAPR()
                {
                    DataSource = new List<APRs>() { list }
                });
                frm.ShowDialog();
            }
        }
    }
}
