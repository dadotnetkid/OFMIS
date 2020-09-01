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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.BL;
using Win.Rprts;
using Helpers;

namespace Win.OB
{
    public partial class ucObligations : DevExpress.XtraEditors.XtraUserControl, IUserControl
    {
        public LoadObligations loadObligations;
        public Obligations obligations;

        public override void Refresh()
        {
            loadObligations.Init();

        }

        public ucObligations()
        {
            InitializeComponent();
            this.loadObligations = new LoadObligations(this);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Add Obligations"))
                return;
            var item = new Obligations();
            frmAddEditObligation frm = new frmAddEditObligation(MethodType.Add, item);
            frm.ShowDialog();
            loadObligations.Init();
            loadObligations.Detail(obligations);
        }

        private async void ucObligations_Load(object sender, EventArgs e)
        {
            loadObligations.Init();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadObligations.Search(txtSearch.Text);
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            loadObligations.Init();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (OBGridView.GetFocusedRow() is Obligations item)
            {
                item = new UnitOfWork().ObligationsRepo.Find(m => m.Id == item.Id);
                var rpt = new rptObligationRequestPreview()
                {
                    DataSource = new List<Obligations>() { item }
                };
                if (item.Offices.IsDivision == true)
                {
                    rpt.lblDivisionChief.Visible = true;
                    rpt.lblDivisionChiefPos.Visible = true;
                    rpt.lblDivisionChief.ExpressionBindings.Clear();
                    rpt.lblDivisionChiefPos.ExpressionBindings.Clear();
                    rpt.lblDepartmentChief.ExpressionBindings.Clear();
                    rpt.lblDepartmentChiefPosition.ExpressionBindings.Clear();
                    rpt.lblDivisionChief.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[Chief]"));
                    rpt.lblDivisionChiefPos.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[ChiefPosition]"));
                    if (string.IsNullOrEmpty(item.OBRApprovedBy))
                    {
                        rpt.lblDepartmentChief.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[UnderOfOffice].[Chief]"));
                        rpt.lblDepartmentChiefPosition.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[UnderOfOffice].[ChiefPosition]"));
                    }
                    else
                    {
                        rpt.lblDepartmentChief.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OBRApprovedBy]"));
                        rpt.lblDepartmentChiefPosition.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[OBRApprovedByPos]"));
                    }


                }
                else
                {
                    foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => x.Tag == "division"))
                    {
                        control.Visible = false;
                    }
                    rpt.lblDepartmentChief.ExpressionBindings.Clear();
                    rpt.lblDepartmentChiefPosition.ExpressionBindings.Clear();
                    rpt.lblDepartmentChief.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[Chief]"));
                    rpt.lblDepartmentChiefPosition.ExpressionBindings.Add(new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Offices].[ChiefPosition]"));
                }
                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }

        }

        private void btnDVPreview_Click(object sender, EventArgs e)
        {
            if (OBGridView.GetFocusedRow() is Obligations item)
            {
                var rpt = new rptDV()
                {
                    DataSource = new List<DvReportViewModel>() { new DvReportViewModel(item.Id) }
                };
                //if (new StaticSettings().Offices.IsDivision != true)
                //{
                //    foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => x.Tag == "Division"))
                //    {
                //        control.Visible = false;
                //    }
                //}
                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }
        }

        private void OBGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        private void OBGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;


            if (e.Column.Name == "colDescription")
            {
                if (view.GetRow(e.RowHandle) is Obligations mark)
                {
                    if (mark.Earmarked == true)
                        e.Appearance.ForeColor = Color.Red;
                }

                //                e.Appearance.TextOptions.HAlignment = _mark ? HorzAlignment.Far : HorzAlignment.Near;
            }

        }

        private void btnEditORDetails_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ORDetailsGridView.GetFocusedRow() is ORDetails item)
                {
                    frmAddEditObligation frm = new frmAddEditObligation(MethodType.Edit, item.Obligations);
                    frm.ShowDialog();
                    loadObligations.Detail(item.Obligations);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelORDetailRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void ucObligations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                loadObligations.Init();
        }

        private void ucObligations_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == Keys.F5.ToString())
                loadObligations.Init();

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadObligations.Search(txtSearch.Text);
        }

        private void btnDuplicate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.OBGridView.GetFocusedRow() is Obligations item)
            {


                try
                {

                    if (MessageBox.Show("Do you want to duplicate this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var obr = unitOfWork.ObligationsRepo.Fetch(x => x.OfficeId == item.OfficeId && x.Year == item.Year)
                        .OrderByDescending(x => x.Id)?.FirstOrDefault();
                    var dtls = new List<ORDetails>();
                    foreach (var i in item.ORDetails)
                    {
                        dtls.Add(new ORDetails()
                        {
                            Amount = i.Amount,
                            AppropriationId = i.AppropriationId,
                            Particulars = i.Particulars,
                            AdjustedAmount = i.AdjustedAmount
                        });
                    }
                    var obrs = new Obligations()
                    {
                        Accountant = item.Accountant,
                        AccountantPos = item.AccountantPos,
                        Amount = item.Amount,
                        BudgetControlNo = item.BudgetControlNo,
                        Chief = item.Chief,
                        ChiefPosition = item.ChiefPosition,
                        Closed = item.Closed,
                        ControlNo = IdHelper.OfficeControlNo(obr.ControlNo, item.Id, "ObR", "Obligations"),
                        CreatedBy = User.UserId,
                        Date = item.Date,
                        DateClosed = item.DateClosed,
                        DateCreated = DateTime.Now,
                        Description = item.Description,
                        DVAmount = item.DVAmount ?? item.Amount,
                        DVApprovedBy = item.DVApprovedBy,
                        DVApprovedByPosition = item.DVApprovedByPosition,
                        DVNote = item.DVNote,
                        DVParticular = item.DVParticular,
                        OBRApprovedBy = item.OBRApprovedBy,
                        OBRApprovedByPos = item.OBRApprovedByPos,
                        OfficeId = item.OfficeId,
                        PayeeAddress = item.PayeeAddress,
                        PayeeId = item.PayeeId,
                        PayeeOffice = item.PayeeOffice,
                        PBO = item.PBO,
                        PBOPos = item.PBOPos,
                        ResponsibilityCenter = item.ResponsibilityCenter,
                        ResponsibilityCenterCode = item.ResponsibilityCenterCode,
                        Year = new StaticSettings().Year,
                        TreasurerPos = item.TreasurerPos,
                        Treasurer = item.Treasurer,
                        TotalAdjustedAmount = item.TotalAdjustedAmount,

                        Status = item.Status,
                        ORDetails = dtls

                    };
                    unitOfWork.ObligationsRepo.Insert(obrs);
                    unitOfWork.Save();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
