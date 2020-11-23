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

namespace Win.ReqIsSlp
{
    public partial class UCRIS : DevExpress.XtraEditors.XtraUserControl
    {
        private int? PRId;

        public UCRIS(int? PRId)
        {
            InitializeComponent();
            this.PRId = PRId;
            btnEditPQRepo.ButtonClick += BtnEditPQRepo_ButtonClick;
            btnDeletePQRepo.ButtonClick += BtnDeletePQRepo_ButtonClick;
            Init();
        }

        private void BtnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (this.RISGridView.GetFocusedRow() is RISHeader item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.RISHeaderRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (this.RISGridView.GetFocusedRow() is RISHeader item)
                {
                    frmAddEditRIS frm = new frmAddEditRIS(MethodType.Edit, item);
                    frm.ShowDialog();
                    Init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Init()
        {
            try
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                this.RISGridControl.DataSource = unitOfWork.RISHeaderRepo.Get(x => x.PRId == this.PRId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            try
            {

                frmAddEditRIS frm = new frmAddEditRIS(Models.MethodType.Add, new RISHeader() { PRId = PRId });
                frm.ShowDialog();
                Init();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.RISGridView.GetFocusedRow() is RISHeader item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();

                    var res = unitOfWork.RISHeaderRepo.Get(x => x.Id == item.Id);
                    frmReportViewer frm = new frmReportViewer(new rptRIS()
                    {
                        DataSource = res
                    });
                    frm.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
