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
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.BL;
using Win.Rprts;

namespace Win.OB
{
    public partial class ucObligations : DevExpress.XtraEditors.XtraUserControl, IUserControl
    {
        private LoadObligations loadObligations;

        public override void Refresh()
        {
            loadObligations.Init();
            
        }

        public ucObligations()
        {
            InitializeComponent();
            this.loadObligations = new LoadObligations(this);
            loadObligations.Init();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Add Obligations"))
                return;
            frmAddEditObligation frm = new frmAddEditObligation(MethodType.Add, null);
            frm.ShowDialog();
            loadObligations.Init();
        }

        private void ucObligations_Load(object sender, EventArgs e)
        {

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
                frmReportViewer frm = new frmReportViewer(new rptDV()
                {
                    DataSource = new List<DvReportViewModel>() { new DvReportViewModel(item.Id) }
                });
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
                Obligations mark = view.GetRow(e.RowHandle) as Obligations;
                if (mark.Earmarked == true)
                    e.Appearance.ForeColor = Color.Red;
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
    }
}
