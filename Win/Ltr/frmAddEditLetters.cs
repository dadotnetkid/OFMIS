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
using Win.BL;

namespace Win.Ltr
{
    public partial class frmAddEditLetters : DevExpress.XtraEditors.XtraForm, ITransactions<Letters>
    {
        private Letters Letters;
        StaticSettings staticSettings = new StaticSettings();
        public frmAddEditLetters(MethodType methodType, Letters letters)
        {
            InitializeComponent();
            this.Letters = letters;
            this.methodType = methodType;
    
        }

        private void frmAddEditLetters_Load(object sender, EventArgs e)
        {
        Init();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
  
                Letters.Body = this.richEditControl1.RtfText;
                unitOfWork.LettersRepo.Update(Letters);
                unitOfWork.Save();
                Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Detail()
        {
            try
            {

                this.cboLetterType.EditValue = Letters.Type;
                this.cboTemplate.EditValue = Letters.TemplateId;
                this.cboOffice.EditValue = Letters.OfficeId;
                this.cboClosing.EditValue = Letters.Closing;
                this.memoCC.EditValue = Letters.CC;
                this.chkForInTheAbsence.EditValue = Letters.ShowInTheAbsenceofthePLO;
                this.cboSalutation.EditValue = Letters.Salutation;

            }
            catch (Exception e)
            {

            }
        }

        void LoadDetail()
        {

            Letters.TemplateId = this.cboTemplate.EditValue.ToInt();
            Letters.Title = cboTemplate.Text;
            Letters.Type = cboLetterType.Text;
            Letters.Signatory = staticSettings.Head;
            Letters.Position = staticSettings.HeadPos;
            Letters.DocumentDate = dtDate.DateTime;

            dtDate.DateTime = Letters.DocumentDate.ToDate();
            var source = new List<Letters>() { Letters };

            this.lettersBindingSource.DataSource = new BindingList<Letters>(source);
            richEditControl1.Options.MailMerge.DataSource = this.lettersBindingSource;
        }
        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.cboLetterType.Properties.DataSource = new BindingList<Templates>(unitOfWork.TemplatesRepo.Get().GroupBy(x => x.Type).Select(x => new Templates { Type = x.Key }).ToList());
            this.cboTemplate.Properties.DataSource = new BindingList<Templates>(unitOfWork.TemplatesRepo.Get());
            this.cboOffice.Properties.DataSource = new BindingList<Offices>(unitOfWork.OfficesRepo.Get());


            chkForInTheAbsence.Text = "For and in the absence of the " + staticSettings.Offices.OffcAcr;
            try
            {
                if (methodType == MethodType.Edit)
                {
                    this.richEditControl1.RtfText = Letters.Body;
                    LoadDetail();
                    Detail();
                    return;
                }

                Letters.DateCreated = DateTime.Now;
                unitOfWork.LettersRepo.Insert(Letters);
                unitOfWork.Save();

                Detail();
            }
            catch (Exception e)
            {

            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void cboLetterType_EditValueChanged(object sender, EventArgs e)
        {
            if (cboLetterType.GetSelectedDataRow() is Templates item)
            {
                cboTemplate.Properties.DataSource =
                    new BindingList<Templates>(new UnitOfWork().TemplatesRepo.Get(x => x.Type == item.Type));
                Letters.Type = item.Type;
            }

        }

        private void cboLetterType_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void cboTemplate_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTemplate.GetSelectedDataRow() is Templates item)
            {
                this.richEditControl1.RtfText = item.TemplateContent;
                Letters.TemplateId = item.Id;
                LoadDetail();
            }
        }

        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (cboOffice.GetSelectedDataRow() is Offices item)
            {
                this.Letters.OfficeId = item.Id;
                this.Letters.OfficeHead = item.Chief;
                this.Letters.OfficeHeadPos = item.ChiefPosition;
                this.Letters.OfficeName = item.OfficeName;
                this.Letters.OfficeNameUnderOf = item.UnderOfOffice?.OfficeName;
                LoadDetail();
            }
        }

        private void dtDate_EditValueChanged(object sender, EventArgs e)
        {
            this.Letters.DocumentDate = dtDate.DateTime;
            Detail();
        }

        private void cboSalutation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Letters.Salutation = cboSalutation.Text;
            LoadDetail();
        }

        private void cboClosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Letters.Closing = cboClosing.Text;
            LoadDetail();
        }

        private void memoCC_EditValueChanged(object sender, EventArgs e)
        {
            Letters.CC = "Cc: " + memoCC.Text;
            if (string.IsNullOrEmpty(memoCC.Text))
                Letters.CC = "";
            LoadDetail();
        }

        private void chkForInTheAbsence_CheckedChanged(object sender, EventArgs e)
        {
            Letters.ShowInTheAbsenceofthePLO = chkForInTheAbsence.Checked;
            LoadDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}