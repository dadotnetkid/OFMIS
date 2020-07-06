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
using Win.Rprts;

namespace Win.PropIsSlp
{
    public partial class UCPIS : DevExpress.XtraEditors.XtraUserControl, ILoad<PIS>
    {
        private PurchaseRequests purchaseRequests;

        public UCPIS(PurchaseRequests purchaseRequests)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            Init();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.PISGridControl.DataSource = unitOfWork.PISRepo.Get(x => x.PRId == purchaseRequests.Id);
                
            }
            catch (Exception e)
            {
            }
        }

        public void Detail(PIS item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (PISGridView.GetFocusedRow() is PIS item)
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.PISRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void btnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (PISGridView.GetFocusedRow() is PIS item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    frmAddEditPIS frm = new frmAddEditPIS(MethodType.Edit, item);
                    frm.ShowDialog();
                    Init();
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditPIS frm = new frmAddEditPIS(MethodType.Add, new PIS() { PRId = purchaseRequests.Id });
            frm.ShowDialog();
            Init();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (PISGridView.GetFocusedRow() is PIS item)
                {
                    item = new UnitOfWork().PISRepo.Find(x => x.Id == item.Id);
                    item.PISDetails = item.PISDetails.OrderBy(x => x.ItemNo).ToList();
                    if (item.PISDetails.Count < 20)
                    {
                        var counter = 20 - item.PISDetails.Count;
                        for (var i = 0; i <= counter; i++)
                        {
                            item.PISDetails.Add(new PISDetails());
                        }
                    }
                    frmReportViewer frm = new frmReportViewer(new rptPIS()
                    {
                        DataSource = new List<PIS>() { item }
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
