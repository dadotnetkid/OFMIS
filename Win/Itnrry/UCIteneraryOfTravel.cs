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
using Win.Rprts;
using Win.Xcanner;
using DevExpress.XtraReports.UI;

namespace Win.Itnrry
{
    public partial class UCIteneraryOfTravel : DevExpress.XtraEditors.XtraUserControl
    {
        private int obrId;

        public UCIteneraryOfTravel(int obrId)
        {
            InitializeComponent();
            this.obrId = obrId;
            Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.itenaryofTravelsBindingSource.DataSource =
                    unitOfWork.ItenaryofTravelsRepo.Get(x => x.OBRId == obrId, includeProperties: "Employees");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UCItenaryOfTravel_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditIOT frm = new frmAddEditIOT(Models.MethodType.Add, new Models.ItenaryofTravels()
            {
                OBRId = this.obrId,
                DateCreated = DateTime.Now
            });
            frm.ShowDialog();
            Init();
        }

        private void btnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.IOTGridView.GetFocusedRow() is ItenaryofTravels item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                try
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ItenaryofTravelsRepo.Delete(x => x.Id == item.Id);
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
            if (this.IOTGridView.GetFocusedRow() is ItenaryofTravels item)
            {

                frmAddEditIOT frm = new frmAddEditIOT(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }
        rptItenerary rpt;
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (this.IOTGridView.GetFocusedRow() is ItenaryofTravels item)
            {
                var list = new UnitOfWork().ItenaryofTravelsRepo.Get(x => x.Id == item.Id);
                rpt = new rptItenerary()
                {
                    DataSource = list
                };
                rpt.CreateDocument();
                rpt.AfterPrint += (se, ev) =>
                {

                    CreateDocument(list);
                };


                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }

        }

        void CreateDocument(List<ItenaryofTravels> itenaryofTravelses)
        {
            
           
        }
    }
}
