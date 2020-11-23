using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models.Repository;
using Models.ViewModels;

namespace Win.Rprts
{
    public partial class frmSummaryOfStatusFinancialDocuments : XtraForm
    {
        public frmSummaryOfStatusFinancialDocuments()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            frmReportViewer frm;
            if (comboBoxEdit1.Text == "Obligations")
            {
                frm = new frmReportViewer(new rptStatusSummaryofFD()
                {
                    DataSource = Obligations(),
                });
            }
            else
            {
                frm = new frmReportViewer(new rptStatusSummaryofFD()
                {
                    DataSource = PurchaseRequests(),
                });
            }

            frm.ShowDialog();

        }

        List<StatusSummaryOfFinancialDocumentsVM> Obligations()
        {
            List<StatusSummaryOfFinancialDocumentsVM> rpt = new List<StatusSummaryOfFinancialDocumentsVM>();
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();

                foreach (var i in unitOfWork.ObligationsRepo.Get(x => x.OfficeId == staticSettings.OfficeId && x.Year == staticSettings.Year && x.FT == staticSettings.FT))
                {
                    var action = unitOfWork.DocumentActionsRepo
                        .Fetch(x => x.RefId == i.Id && x.TableName == "Obligations").OrderByDescending(x => x.Id)
                        .FirstOrDefault();
                    rpt.Add(new StatusSummaryOfFinancialDocumentsVM()
                    {
                        FinancialDocumentId = i.Id,
                        ControlNo = i.ControlNo,
                        Amount = i.Amount,
                        Description = i.Description,
                        LastActionDate = action?.ActionDate,
                        LastActionTaken = action?.ActionTaken,
                        Remarks = action?.Remarks,
                        DocumentType="Obligation Request"
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rpt;
        }
        List<StatusSummaryOfFinancialDocumentsVM> PurchaseRequests()
        {
            List<StatusSummaryOfFinancialDocumentsVM> rpt = new List<StatusSummaryOfFinancialDocumentsVM>();

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                StaticSettings staticSettings = new StaticSettings();
                foreach (var i in unitOfWork.PurchaseRequestsRepo.Get(x => x.OfficeId == staticSettings.OfficeId && x.Year == staticSettings.Year && x.FT == staticSettings.FT))
                {
                    var action = unitOfWork.DocumentActionsRepo
                        .Fetch(x => x.RefId == i.Id && x.TableName == "PurchaseRequests").OrderByDescending(x => x.Id)
                        .FirstOrDefault();
                    rpt.Add(new StatusSummaryOfFinancialDocumentsVM()
                    {
                        FinancialDocumentId = i.Id,
                        ControlNo = i.ControlNo,
                        Amount = i.TotalAmount,
                        Description = i.Description,
                        LastActionDate = action?.ActionDate,
                        LastActionTaken = action?.ActionTaken,
                        Remarks = action?.Remarks,
                        DocumentType = "Purchase Request"
                    });

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rpt;
        }
    }
}
