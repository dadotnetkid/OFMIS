using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;

namespace Win.Tmplts
{
    public partial class frmAddEditTemplatesV2 : DevExpress.XtraEditors.XtraForm
    {
        private Templates templates;
        private MethodType methodType;
        private StaticSettings staticSettings = new StaticSettings();
        private bool isClosed;

        public frmAddEditTemplatesV2(Templates templates, MethodType methodType)
        {
            InitializeComponent();
            this.templates = templates;
            this.methodType = methodType;
            Init();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                templates = unitOfWork.TemplatesRepo.Find(x => x.Id == templates.Id);
                this.txtTemplateName.Text = templates.Name;
                this.cboType.Text = templates.Type;
                this.txtbody.HtmlText = templates.TemplateContent;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.TemplatesRepo.Find(x => x.Id == templates.Id);
                item.Name = txtTemplateName.Text;
                item.Type = cboType.Text;
                item.TemplateContent = txtbody.ToHtml();
                unitOfWork.Save();
                isClosed = true;
                Close();
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
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                templates = new Templates()
                {
                    OfficeId = staticSettings.OfficeId,

                };
                unitOfWork.TemplatesRepo.Insert(templates);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAddEditTemplatesV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (methodType == MethodType.Edit || this.isClosed)
            {
                return;
            }

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.TemplatesRepo.Delete(x => x.Id == templates.Id);
                unitOfWork.Save();
            }
            catch (Exception exception)
            {
            }
        }
    }
}