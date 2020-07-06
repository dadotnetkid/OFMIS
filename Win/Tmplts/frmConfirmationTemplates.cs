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
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Tmplts
{
    public partial class frmConfirmationTemplates : DevExpress.XtraEditors.XtraForm, ITransactions<Templates>
    {
        public bool isClosed;
        public Templates template;

        public frmConfirmationTemplates(Templates template, MethodType methodType)
        {
            this.template = template;
            this.methodType = methodType;
            InitializeComponent();
            Init();
        }

        private void frmConfirmationTemplates_Load(object sender, EventArgs e)
        {

        }
        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = unitOfWork.TemplatesRepo.Find(x => x.Id == template.Id);
                res.Name = textBox1.Text;
                res.Type = comboBoxEdit1.Text;
                res.TemplateContent = template.TemplateContent;
                unitOfWork.Save();
                this.Close();
                this.isClosed = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            frmAddEditTemplates frm = new frmAddEditTemplates(this, template);
            frm.ShowDialog();
            this.comboBoxEdit1.Properties.DataSource =
                new UnitOfWork().TemplatesRepo.Get().GroupBy(x => x.Type).Select(x => new { Type = x.Key });
            this.textBox1.Text = template.Name;
            this.comboBoxEdit1.EditValue = template.Type;
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }

                UnitOfWork unitOfWork = new UnitOfWork();
                template = new Templates();
                unitOfWork.TemplatesRepo.Insert(template);
                unitOfWork.Save();
                Detail();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            if (methodType == MethodType.Edit)
            {
                eventArgs.Cancel = true;
                return;
            }

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.TemplatesRepo.Delete(x => x.Id == template.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}