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
using Models.ViewModels;
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
            this.Init();
        }

        private void Init()
        {
            StaticSettings staticSettings = new StaticSettings();
            UnitOfWork unitOfWork = new UnitOfWork();
           /* var letter = new Letters()
            {
                CreatedByOffice = staticSettings.OfficeId,

            };
            var source = new List<LetterViewModel>() { new LetterViewModel()
            {
                CreatedOffice=letter.CreatedOffice,
                CreatedByOffice=letter.CreatedByOffice,
                CreatedOfficeName=letter.CreatedOfficeName.ToUpper()
            } };

            this.lettersBindingSource.DataSource = new BindingList<Letters>(source);
            richEditControl1.Options.MailMerge.DataSource = this.lettersBindingSource;*/
        }

        private void btnSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            var document = this.richEditControl1.Document;
          
            frm.template = this.template;

            frm.isClosed = true;
            this.Close();
        }

        private void frmAddEditTemplates_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmAddEditTemplates_Load(object sender, EventArgs e)
        {

        }
    }
}