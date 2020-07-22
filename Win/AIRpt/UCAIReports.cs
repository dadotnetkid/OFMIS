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
using DevExpress.XtraReports.UI;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;

namespace Win.AIRpt
{
    public partial class UCAIReports : DevExpress.XtraEditors.XtraUserControl, ILoad<AIReports>
    {
        private PurchaseRequests purchaseRequests;

        public UCAIReports(PurchaseRequests purchaseRequests)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            Init();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditAcceptance frm = new frmAddEditAcceptance(MethodType.Add, new AIReports() { PRId = purchaseRequests.Id });
            frm.ShowDialog();
            Init();
        }

        public void Init()
        {
            try
            {
                this.AIGridControl.DataSource = new UnitOfWork().AIReportsRepo.Get(x => x.PRId == purchaseRequests.Id);
            }
            catch (Exception e)
            {

            }
        }

        public void Detail(AIReports item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (AIGridView.GetFocusedRow() is AIReports item)
                {
                    item = new UnitOfWork().AIReportsRepo.Find(x => x.Id == item.Id);
                    frmAddEditAcceptance frm = new frmAddEditAcceptance(MethodType.Edit, item);
                    frm.ShowDialog();
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
                if (!User.UserInAction("can delete"))
                    return;
                if (AIGridView.GetFocusedRow() is AIReports item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    var unitOfWork = new UnitOfWork();
                    unitOfWork.AIReportsRepo.Delete(x => x.Id == item.Id);
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
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (AIGridView.GetFocusedRow() is AIReports item)
                {
                    item = unitOfWork.AIReportsRepo.Find(x => x.Id == item.Id);
                    item.AIRDetails = item.AIRDetails.OrderBy(x => x.ItemNo).ToList();
                    //if (item.AIRDetails.Count < 25)
                    //{
                    //    var counter = 25 - item.AIRDetails.Count;
                    //    for (var i = 1; i <= counter; i++)
                    //    {
                    //        item.AIRDetails.Add(new AIRDetails());
                    //    }
                    //}
                    var rpt = new rptAcceptanceAndInspections()
                    {
                        DataSource = new List<AIReports>() { item }
                    };
                    StaticSettings staticSettings = new StaticSettings();
                    if (staticSettings.Offices.ResponsibilityCenterCode == "1032" )
                    {
                        rpt.grpStandard.Visible = false;
                        rpt.grpHR.Visible = true;

                    }

                    if (string.IsNullOrEmpty(item.PropertyOfficer2))
                    {
                        foreach (var ctrl in rpt.AllControls<XRControl>().Where(x => x.Tag == "hide_isnull"))
                        {
                            ctrl.Visible = false;
                        }
                    }
                    frmReportViewer frm = new frmReportViewer(rpt);

                    frm.ShowDialog();
                }

            }
            catch (Exception exception)
            {

            }
        }
    }
}
