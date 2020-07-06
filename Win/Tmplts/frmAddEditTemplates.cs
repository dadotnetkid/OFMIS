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
    public partial class frmAddEditTemplates : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Templates template;
        private frmConfirmationTemplates frm;
        private bool isClosed;

        public frmAddEditTemplates(frmConfirmationTemplates frm, Templates template)
        {
            InitializeComponent();
            this.frm = frm;
            this.template = template;
            this.richEditControl1.RtfText = template?.TemplateContent;
        }

        private void btnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            template.TemplateContent = this.richEditControl1.RtfText;
            frm.template = this.template;

            frm.isClosed = true;
            this.Close();
        }

        private void frmAddEditTemplates_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
    }
}