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

        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            StaticSettings staticSettings = new StaticSettings();
            this.LetterGridControl.DataSource = new BindingList<Letters>(unitOfWork.LettersRepo.Get(x => (x.RefId == refId && x.TableName == this.tableName)
                                                                                                         ));
        }

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
                RichEditControl rich = new RichEditControl();

                rich.Document.AppendHtmlText($"<br/><b>{item.Salutation}</b><br/><br/>");
                rich.Document.AppendHtmlText(item.Body);
                rich.Document.AppendHtmlText("<br/><br/><br/>" + lett.Closing + "<br/><br/><br/>");
                rich.Document.DefaultCharacterProperties.FontName = "Calibri";
                rich.Document.DefaultCharacterProperties.FontSize= 12f;
                lett.Body = rich.ToHtml();
                var rpt = new rptLetters()
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
                rpt.lblTelno.Text ="Tel No: "+ office.TelNo;
                rpt.lblAddress.Text ="Address: "+ office.Address;
                rpt.DataSource = new List<Letters>() { unitOfWork.LettersRepo.Find(x => x.Id == item.Id) };
                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }
        }

        private void btnPreviewRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnPreview.PerformClick();


        }
    }
}
