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
using Win.OB;
using Helpers;

namespace Win.PR
{
    public partial class UCPurchaseRequest : DevExpress.XtraEditors.XtraUserControl, IUserControl

    {
        public LoadAddEditPurchaseRequest loadAddEditPurchaseRequest;

        public override void Refresh()
        {
            var frm = Application.OpenForms["Main"] as Main;
            frm.pnlMain.Controls.Clear();
            frm.pnlMain.Controls.Add(new UCPurchaseRequest() { Dock = DockStyle.Fill });
            base.Refresh();
        }
        public UCPurchaseRequest(string controlNo)
        {
            InitializeComponent();
            this.loadAddEditPurchaseRequest = new LoadAddEditPurchaseRequest(this);
            ((ILoad<PurchaseRequests>)loadAddEditPurchaseRequest).Init();
            loadAddEditPurchaseRequest.Search(txtSearch.Text, true);

        }

        public UCPurchaseRequest()
        {
            InitializeComponent();
            this.loadAddEditPurchaseRequest = new LoadAddEditPurchaseRequest(this);
            ((ILoad<PurchaseRequests>)loadAddEditPurchaseRequest).Init();
        }

        private void lnkOBR_Click(object sender, EventArgs e)
        {
            if (this.PRGrid.GetFocusedRow() is PurchaseRequests item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                if (!unitOfWork.ObligationsRepo.Fetch(x => x.PRNo == item.Id).Any())
                {
                    MessageBox.Show("No OBR created", "OBR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Application.OpenForms["Main"] is Main frm)
                {
                    frm.pnlMain.Controls.Clear();
                    var uc = new ucObligations()
                    {
                        Dock = DockStyle.Fill
                    };
                    var obr = unitOfWork.ObligationsRepo.Find(x => x.PRNo == item.Id);
                    uc.txtSearch.Text = obr.ControlNo;
                    uc.loadObligations.Search(uc.txtSearch.Text); frm.pnlMain.Controls.Add(uc);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadAddEditPurchaseRequest.Search(txtSearch.Text);
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //UnitOfWork unitOfWork = new UnitOfWork();
                //this.PRGridControl.DataSource = new BindingList<PurchaseRequests>(unitOfWork.PurchaseRequestsRepo.Get(x => x.r.Contains(txtSearch.Text)));
            }
            catch (Exception exception)
            {

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnDuplicate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.PRGrid.GetFocusedRow() is PurchaseRequests item)
            {

                try
                {

                    if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var pr = unitOfWork.PurchaseRequestsRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault();
                    StaticSettings staticSettings = new StaticSettings();
                    var res = new PurchaseRequests()
                    {
                        ControlNo = IdHelper.OfficeControlNo(pr.ControlNo, staticSettings.OfficeId, "PR",
                            "PurchaseRequests"),
                        AppropriationId = item.AppropriationId,
                        CreatedBy = User.UserId,
                        Date = DateTime.Now,
                        OfficeId = item.OfficeId,
                        DeptHead = item.DeptHead,
                        Description = item.Description,
                        Year = item.Year,
                        TotalAmount = item.TotalAmount,
                        TableName = item.TableName,
                        Purpose = item.Purpose,
                        DeptHeadPos = item.DeptHeadPos,
                        PAPos = item.PAPos,
                        PA = item.PA,
                        DivisionHead = item.DivisionHead,
                        DivisionHeadPos = item.DivisionHeadPos,
                        IsEarmark = item.IsEarmark,



                    };
                    var pRDetails = new List<PRDetails>();
                    foreach (var i in item.PRDetails)
                    {
                        pRDetails.Add(new PRDetails()
                        {
                            Category = i.Category,
                            Cost = i.Cost,
                            Item = i.Item,
                            ItemNo = i.ItemNo,
                            ItemId = i.ItemId,
                            Quantity = i.Quantity,
                            TableName = i.TableName,
                            TotalAmount = i.TotalAmount,
                            UOM = i.UOM,
                        });
                    }

                    res.PRDetails = pRDetails;
                    unitOfWork.PurchaseRequestsRepo.Insert(res);
                    unitOfWork.Save();
                    ((ILoad<PurchaseRequests>) this.loadAddEditPurchaseRequest).Init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.ItemsGridView.GetFocusedRow() is PRDetails item)
            {
                frmAddEditPurchaseRequest frm= new frmAddEditPurchaseRequest(MethodType.Edit, item.PurchaseRequests);
                frm.ShowDialog();
            }
        }
    }
}
