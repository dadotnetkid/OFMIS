using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Export;
using DevExpress.XtraRichEdit.Export.Html;
using Helpers;
using Models;
using Models.Repository;

namespace Win.Ltr
{
    public partial class frmAddEditLetterV2 : DevExpress.XtraEditors.XtraForm
    {
        private Letters letters;
        private MethodType methodType;
        private bool isClosed;

        public frmAddEditLetterV2(Letters letters, MethodType methodType)
        {
            InitializeComponent();
            this.letters = letters;
            this.methodType = methodType;
            Init();
        }

        void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Details();
                    return;
                }

                StaticSettings staticSettings = new StaticSettings();
                letters = new Letters()
                {
                    RefId = letters.RefId,
                    TableName = letters.TableName,
                    ControlNo = letters.ControlNo,
                    Date = DateTime.Now,
                    Signatories = staticSettings.Head,
                    SignatoriesPosition = staticSettings.HeadPos,
                    CreatedBy = User.UserId,
                    DateCreated = DateTime.Now};
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.LettersRepo.Insert(letters);
                unitOfWork.Save();
                Details();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Details()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.officesBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
                this.txtBody.HtmlText = letters.Body;
                this.cboType.EditValue = letters.Type;
                this.cboTemplates.EditValue = letters.Template;
                this.txtTitle.Text = letters.Title;
                this.dtDate.EditValue = letters.Date;
                this.txtInsideAddress.HtmlText = letters.InsideAddress;
                this.dtSalutation.Text = letters.Salutation;
                this.cboOffice.EditValue = letters.OfficeId;
                this.txtBody.HtmlText = letters.Body;
                this.cboClosing.Text = letters.Closing;
                this.txtSignatories.Text = letters.Signatories;
                this.txtPosition.Text = letters.SignatoriesPosition;
                this.chkAbsence.EditValue = letters.InTheAbsence;
                this.txtCC.Text = letters.CC;
                this.chkAbsence.Text += " " + new StaticSettings().Offices.OffcAcr;

                DisableEditors(letters.Type);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DisableEditors(string type)
        {

            if (cboType.Text != "Letters")
            {
                txtTitle.Enabled = true;
                txtTitle.Text = cboType.Text;
                txtInsideAddress.Enabled = true;
            }
            if (type == "Plain")
            {
                txtTitle.Enabled = false;
                //cboOffice.Enabled = false;
                txtInsideAddress.Enabled = false;
                cboClosing.Enabled = false;
                dtDate.Enabled = false;
                txtSignatories.Enabled = false;
                txtPosition.Enabled = false;
                txtCC.Enabled = false;
                chkAbsence.Enabled = false;
                dtSalutation.Enabled = false;
            }

        }

        void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                letters = unitOfWork.LettersRepo.Find(x => x.Id == letters.Id);
                letters.Type = cboType.EditValue.ToString();
                letters.Title = txtTitle.Text;
                letters.Date = dtDate.DateTime;
                letters.OfficeId = cboOffice.EditValue.ToInt();
                letters.InsideAddress = txtInsideAddress.ToHtml();
                letters.Salutation = dtSalutation.Text;
                letters.Template = cboTemplates.Text;
                letters.Body = txtBody.ToHtml();
                letters.Closing = cboClosing.Text;
                letters.Signatories = txtSignatories.Text;
                letters.SignatoriesPosition = txtPosition.Text;
                letters.InTheAbsence = chkAbsence.Checked;
                letters.CC = txtCC.Text;
                unitOfWork.Save();
                isClosed = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAddEditLettersV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (methodType == MethodType.Edit || this.isClosed)
                return;
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.LettersRepo.Delete(x => x.Id == letters.Id);
                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.templatesBindingSource.DataSource = unitOfWork.TemplatesRepo.Get(x => x.Type == cboType.Text);
            DisableEditors(cboType.Text);


            cboTemplates.EditValue = letters.Template;
        }

        private void cboTemplates_EditValueChanged(object sender, EventArgs e)
        {
            if (cboTemplates.GetSelectedDataRow() is Templates item)
            {
                txtBody.HtmlText = item.TemplateContent;
            }
        }



        private void cboOffice_EditValueChanged(object sender, EventArgs e)
        {
            if (cboOffice.GetSelectedDataRow() is Offices item)
            {
                if (cboType.Text != "Plain")
                {
                    txtInsideAddress.HtmlText = item.InsideAddress;
                    txtInsideAddress.Document.DefaultCharacterProperties.FontName = "Calibri";
                }


            }
        }

        private void cboClosing_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtBody.Document.AppendHtmlText(cboClosing.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            InsertTableCommand cmd = new InsertTableCommand(this.txtBody);

            cmd.Execute();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            this.txtBody.ToBold();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            this.txtBody.ToItalic();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            this.txtBody.ToUnderline();
        }

        private void btnIncFont_Click(object sender, EventArgs e)
        {
            this.txtBody.IncreaseFont();
        }

        private void btnDecFont_Click(object sender, EventArgs e)
        {
            this.txtBody.DecreaseFont();
        }

        private void fntTextfont_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBody.ChangeFont(fntTextfont.Text);
        }
    }
}