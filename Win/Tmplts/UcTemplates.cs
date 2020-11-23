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

namespace Win.Tmplts
{
    public partial class UcTemplates : DevExpress.XtraEditors.XtraUserControl, ILoad<Templates>
    {
        public UcTemplates()
        {
            InitializeComponent();
            Init();
            btnEditRepo.ButtonClick += BtnEditRepo_ButtonClick;
            btnDeleteRepo.ButtonClick += BtnDeleteRepo_ButtonClick;
            btnCopyRepo.ButtonClick += BtnCopyRepo_ButtonClick;
        }

        private void BtnCopyRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to duplicate this?", "Duplicate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (TemplateGridView.GetFocusedRow() is Templates item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.Id = 0;
                    item.Name = item.Name + " - Duplicate";
                    unitOfWork.TemplatesRepo.Insert(item);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (TemplateGridView.GetFocusedRow() is Templates item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.TemplatesRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (TemplateGridView.GetFocusedRow() is Templates item)
                {
                    frmAddEditTemplatesV2 frm = new frmAddEditTemplatesV2(item, MethodType.Edit);
                    frm.ShowDialog();
                    Init();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //frmConfirmationTemplates frm = new frmConfirmationTemplates(new Models.Templates(), Models.MethodType.Add);
            //frm.ShowDialog();
            //Init();
            //    frmAddEditTemplateV2 frm = new frmAddEditTemplateV2();
            //    frm.ShowDialog();
            frmAddEditTemplatesV2 frm = new frmAddEditTemplatesV2(new Templates() { }, MethodType.Add);
            frm.ShowDialog();
            Init();
        }

        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();

            TemplateGridControl.DataSource = new BindingList<Templates>(unitOfWork.TemplatesRepo.Get());
        }

        public void Detail(Templates item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }



        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {

                if (TemplateGridView.GetFocusedRow() is Templates item)
                {
                    var res = new rptTemplatePreview()
                    {
                        DataSource = new UnitOfWork().TemplatesRepo.Get(x => x.Id == item.Id)
                    };

                    frmReportViewer frmReportViewer = new frmReportViewer(res);
                    frmReportViewer.ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TemplateGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (TemplateGridView.GetFocusedRow() is Templates item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.TemplatesRepo.Fetch(x => x.Id == item.Id).Select(x => new { x.TemplateContent })
                    .FirstOrDefault();
                this.rtfPreview.HtmlText = res?.TemplateContent;
            }
        }
    }
}
