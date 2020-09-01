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
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;

namespace Win.Ltr
{
    public partial class UcLetters : DevExpress.XtraEditors.XtraUserControl, ILoad<Letters>
    {
        private string tableName;
        private int refId;
        private string itemControlNo;
        private string footer;

        public UcLetters(int refId, string itemControlNo, string tableName)
        {
            InitializeComponent();
            this.refId = refId;
            this.tableName = tableName;
            this.itemControlNo = itemControlNo;
            btnEditRepo.ButtonClick += BtnEditRepo_ButtonClick;
            btnDeleteRepo.ButtonClick += BtnDeleteRepo_ButtonClick;
            Init();
        }
        public UcLetters(int refId, string itemControlNo, string tableName, string footer)
        {
            InitializeComponent();
            this.refId = refId;
            this.tableName = tableName;
            this.itemControlNo = itemControlNo;
            this.footer = footer;
            btnEditRepo.ButtonClick += BtnEditRepo_ButtonClick;
            btnDeleteRepo.ButtonClick += BtnDeleteRepo_ButtonClick;

            Init();
        }
        private void BtnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LetterGridView.GetFocusedRow() is Letters item)
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.LettersRepo.Delete(x => x.Id == item.Id);
                unitOfWork.Save();
                Init();
            }
        }

        private void BtnEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LetterGridView.GetFocusedRow() is Letters item)
            {
                frmAddEditLetterV2 frm = new frmAddEditLetterV2(item, MethodType.Edit);
                frm.ShowDialog();
                Init();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //frmAddEditLetters frm = new frmAddEditLetters(MethodType.Add, new Letters()
            //{
            //    RefId = this.refId,
            //    TableName = tableName,
            //    ControlNo = this.itemControlNo
            //});
            //frm.ShowDialog();
            //Init();
            frmAddEditLetterV2 frm = new frmAddEditLetterV2(new Letters() { TableName = tableName, ControlNo = itemControlNo, RefId = refId }, MethodType.Add);
            frm.ShowDialog();
            Init();
        }

        public async void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            StaticSettings staticSettings = new StaticSettings();
            this.LetterGridControl.DataSource = await Task.Run(() => new BindingList<Letters>(
                unitOfWork.LettersRepo.Get(x => (x.RefId == refId && x.TableName == this.tableName)
                )));}

        public void Detail(Letters item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {


            if (LetterGridView.GetFocusedRow() is Letters item)
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var lett = unitOfWork.LettersRepo.Find(x => x.Id == item.Id);
                RichEditControl rich = new RichEditControl()
                {

                };
                //rich.Document.DefaultParagraphProperties.Alignment = DevExpress.XtraRichEdit.API.Native.ParagraphAlignment.Justify;
                if (item.Type != "Plain")
                {
                    if (!string.IsNullOrEmpty(lett.Closing))
                    {
                        var rtf0 = new RichEditControl();
                        rtf0.Document.DefaultParagraphProperties.Alignment =
                            DevExpress.XtraRichEdit.API.Native.ParagraphAlignment.Left;
                        rtf0.Document.DefaultCharacterProperties.FontName = "Calibri";
                        rtf0.Document.DefaultCharacterProperties.FontSize = 12f;
                        rtf0.Document.HtmlText = $"<br/><b>{item.Salutation}</b><br/><br/>";
                        rich.Document.AppendRtfText(rtf0.RtfText, DevExpress.XtraRichEdit.API.Native.InsertOptions.UseDestinationStyles);
                    }

                }
                var rtf1 = new RichEditControl();
                rtf1.Document.DefaultParagraphProperties.Alignment =
                    DevExpress.XtraRichEdit.API.Native.ParagraphAlignment.Justify;
                rtf1.Document.DefaultCharacterProperties.FontName = "Calibri";
                rtf1.Document.DefaultCharacterProperties.FontSize = 12f;
                rtf1.HtmlText = item.Body;
                //.Document.HtmlText = $"<br/><b>{item.Salutation}</b><br/><br/>";
                //rtf1.Document.AppendHtmlText(item.Body, DevExpress.XtraRichEdit.API.Native.InsertOptions.UseDestinationStyles);
                rich.Document.AppendRtfText(rtf1.RtfText, DevExpress.XtraRichEdit.API.Native.InsertOptions.UseDestinationStyles);

                if (item.Type != "Plain")
                {
                    if (!string.IsNullOrEmpty(lett.Closing))
                    {
                        var rtf = new RichEditControl();
                        rtf.Document.DefaultParagraphProperties.Alignment =
                            DevExpress.XtraRichEdit.API.Native.ParagraphAlignment.Left;
                        rich.Document.DefaultCharacterProperties.FontName = "Calibri";
                        rich.Document.DefaultCharacterProperties.FontSize = 12f;
                        rtf.Document.HtmlText = "<br/><br/><br/>" + lett.Closing + "<br/><br/><br/>";
                        rich.Document.AppendRtfText(rtf.RtfText, DevExpress.XtraRichEdit.API.Native.InsertOptions.UseDestinationStyles);
                    }

                }

                rich.Document.DefaultCharacterProperties.FontName = "Calibri";
                rich.Document.DefaultCharacterProperties.FontSize = 12f;
                lett.Body = rich.ToHtml();
                var rpt = new rptLetters(footer)
                {

                };
                if (item.Type == "Letter")
                {
                    rpt.grpTitle.Visible = false;
                }

                if (item.Type != "Letter")
                {
                    rpt.grpAddressing.Visible = false;
                }


                item.CreatedBy = User.UserId;
                int officeId = User.OfficeId() ?? 0;
                var office = new UnitOfWork().OfficesRepo.Find(x => x.Id == officeId);
                if (office.IsDivision == true)
                {
                    rpt.lblOfficeName.Text = "Office of the Governor".ToUpper() + Environment.NewLine + office?.OfficeName?.ToUpper();
                }
                else
                {
                    rpt.lblOfficeName.Text = office?.OfficeName;
                }

                if (string.IsNullOrEmpty(item.CC))
                {
                    rpt.lblCC.Visible = false;
                }
                foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => ReferenceEquals(x.Tag, "signatories")))
                {
                    control.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
                }

                if (item.Type == "Letter")
                {
                    foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => ReferenceEquals(x.Tag, "signatories")))
                    {
                        control.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                    }
                    rpt.lblTitle.Visible = false;
                }

                if (item.Type == "Plain")
                {
                    foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => ReferenceEquals(x.Tag, "signatories")))
                    {
                        control.Visible = false;
                    }
                    rpt.lblTitle.Visible = false;
                }

                rich = new RichEditControl();
                rich.HtmlText = item.InsideAddress;
                rich.DefaultFont();
                item.InsideAddress = rich.HtmlText;

                rpt.lblCC.Text = "CC: " + item.CC;
                rpt.lblTelno.Text = "Tel No: " + office.TelNo;
                rpt.lblAddress.Text = "Address: " + office.Address;
                rpt.DataSource = new List<Letters>() { lett };
                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }
        }

        private void btnPreviewRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnPreview.PerformClick();


        }

        private void btnDuplicate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.LetterGridView.GetFocusedRow() is Letters item)
            {

                if (MessageBox.Show("Do you want to duplicate this?", "Duplicate", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                try
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item = new Letters()
                    {
                        Body = item.Body,
                        CC = item.CC,
                        Closing = item.Closing,
                        ControlNo = item.ControlNo,
                        CreatedBy = User.UserId,
                        Date = item.Date,
                        DateCreated = DateTime.Now,
                        InsideAddress = item.InsideAddress,
                        InTheAbsence = item.InTheAbsence,
                        OfficeId = item.OfficeId,
                        RefId = item.RefId,
                        Salutation = item.Salutation,
                        SignatoriesPosition = item.SignatoriesPosition,
                        TableName = item.TableName,
                        Template = item.Template,
                        Title = item.Title,
                        Type = item.Type,
                    };
                    unitOfWork.LettersRepo.Insert(item);
                    unitOfWork.Save();

                    frmAddEditLetterV2 frm = new frmAddEditLetterV2(item, MethodType.Edit);
                    frm.ShowDialog();
                    Init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
