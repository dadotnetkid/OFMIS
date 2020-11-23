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
using DevExpress.XtraRichEdit.API.Native;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.BL;

namespace Win.Ltr
{
    public partial class frmAddEditLetterV2 : DevExpress.XtraEditors.XtraForm, ITransactions<Letters>
    {
        private Letters letters;
        StaticSettings staticSettings = new StaticSettings();
        public frmAddEditLetterV2(MethodType methodType, Letters letters)
        {
            InitializeComponent();
            this.letters = letters;
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

                letters.Body = this.richEditControl1.RtfText;
                var res = unitOfWork.LettersRepo.Find(x => x.Id == letters.Id);
                res.InsideAddress = letters.InsideAddress;
                res.OfficeHead = letters.OfficeHead;
                res.OfficeHeadPos = letters.OfficeHeadPos;
                res.OfficeId = letters.OfficeId;
                res.OfficeName = letters.OfficeName;
                res.OfficeNameUnderOf = letters.OfficeNameUnderOf;
                res.Position = letters.Position;
                res.Salutation = letters.Salutation;
                res.ShowInTheAbsenceofthePLO = letters.ShowInTheAbsenceofthePLO;
                res.Signatory = letters.Signatory;
                res.TemplateId = letters.TemplateId;
                res.Title = letters.Title;
                res.Type = letters.Type;
                res.DocumentDate = letters.DocumentDate;
                res.Body = letters.Body;
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

                this.cboLetterType.EditValue = letters.Type;
                this.cboTemplate.EditValue = letters.TemplateId;
                this.cboOffice.EditValue = letters.OfficeId;
                this.cboClosing.EditValue = letters.Closing;
                this.memoCC.EditValue = letters.CC;
                this.chkForInTheAbsence.EditValue = letters.ShowInTheAbsenceofthePLO;
                this.cboSalutation.EditValue = letters.Salutation;

            }
            catch (Exception e)
            {

            }
        }

        void LoadDetail()
        {

            letters.TemplateId = this.cboTemplate.EditValue?.ToInt() ?? letters.TemplateId; ;
            letters.Title = string.IsNullOrEmpty(cboTemplate.Text) ? letters.Title : cboTemplate.Text;
            letters.Type = string.IsNullOrEmpty(cboLetterType.Text) ? letters.Type : cboLetterType.Text;
            letters.Signatory = staticSettings.Head;
            letters.Position = staticSettings.HeadPos;
            letters.DocumentDate = dtDate.EditValue == null ? letters.DateCreated : dtDate.DateTime;

            dtDate.DateTime = letters.DocumentDate.ToDate();
            var office = new UnitOfWork().OfficesRepo.Find(x => x.Id == letters.OfficeId);
            var source = new List<LetterViewModel>() { new LetterViewModel()
            {
                LetterHeadOffice=letters.CreatedOfficeName,
                Date=letters.DocumentDate??DateTime.Now ,
                HeadOfOffice=letters.OfficeHead,HeadOfOfficePosition=letters.OfficeHeadPos,
                HeadOfOfficeAddress=office.Address,
                Salutation=letters.Salutation,
                Signaturies=letters.Signatory,
                SignatoriesPosition=letters.Position,
                CC=letters.CC,
                Closing=letters.Closing,
                ShowInTheAbsenceOf=letters.ShowForandInTheAbsenceOf
            } };

            this.letterViewModelBindingSource.DataSource = new BindingList<LetterViewModel>(source);
            richEditControl1.Options.MailMerge.DataSource = this.lettersBindingSource;

            var footer = richEditControl1.Document.Sections[0];
            //    header.BeginUpdateFooter();

            if (!footer.HasFooter(DevExpress.XtraRichEdit.API.Native.HeaderFooterType.Primary))
            {
                SubDocument newFooter = footer.BeginUpdateFooter();
                footer.EndUpdateHeader(newFooter);
                var footerDocument = footer.BeginUpdateFooter();

                footerDocument.InsertText(footerDocument.CreatePosition(0),
                    $"Office Fund Management Information System [{User.UserName}] - [{letters.ControlNo}]");
                footer.EndUpdateFooter(footerDocument);

            }
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
                    this.richEditControl1.RtfText = letters.Body;
                    LoadDetail();
                    Detail();
                    return;
                }

                letters = new Letters()
                {
                    DateCreated = DateTime.Now,
                    CreatedByOffice = staticSettings.OfficeId,
                    RefId = letters.RefId,
                    TableName = letters.TableName,
                    ControlNo = letters.ControlNo
                };
                unitOfWork.LettersRepo.Insert(letters);
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
                letters.Type = item.Type;
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
                letters.TemplateId = item.Id;
                LoadDetail();
            }
        }

        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (cboOffice.GetSelectedDataRow() is Offices item)
            {
                this.letters.OfficeId = item.Id;
                this.letters.OfficeHead = item.Chief;
                this.letters.OfficeHeadPos = item.ChiefPosition;
                this.letters.OfficeName = item.OfficeName;
                this.letters.OfficeNameUnderOf = item.UnderOfOffice?.OfficeName;
                LoadDetail();
            }
        }

        private void dtDate_EditValueChanged(object sender, EventArgs e)
        {
            this.letters.DocumentDate = dtDate.DateTime;
            LoadDetail();
        }

        private void cboSalutation_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.letters.Salutation = cboSalutation.Text;
            LoadDetail();
        }

        private void cboClosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.letters.Closing = cboClosing.Text;
            LoadDetail();
        }

        private void memoCC_EditValueChanged(object sender, EventArgs e)
        {
            letters.CC = "Cc: " + memoCC.Text;
            if (string.IsNullOrEmpty(memoCC.Text))
                letters.CC = "";
            LoadDetail();
        }

        private void chkForInTheAbsence_CheckedChanged(object sender, EventArgs e)
        {
            letters.ShowInTheAbsenceofthePLO = chkForInTheAbsence.Checked;
            LoadDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}