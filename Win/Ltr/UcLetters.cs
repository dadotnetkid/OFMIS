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
using DevExpress.XtraRichEdit;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Ltr
{
    public partial class UcLetters : DevExpress.XtraEditors.XtraUserControl, ILoad<Letters>
    {
        public UcLetters()
        {
            InitializeComponent();
            btnEditRepo.ButtonClick += BtnEditRepo_ButtonClick;
            btnDeleteRepo.ButtonClick += BtnDeleteRepo_ButtonClick;
            Init();
        }

        private void BtnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (LetterGridView.GetFocusedRow() is Letters item)
            {
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
                frmAddEditLetters frm = new frmAddEditLetters(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditLetters frm = new frmAddEditLetters(MethodType.Add, new Letters());
            frm.ShowDialog();
            Init();
        }

        public void Init()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.LetterGridControl.DataSource = new BindingList<Letters>(unitOfWork.LettersRepo.Get());
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
                RichEditControl richEditControl = new RichEditControl();
                richEditControl.RtfText = item.Body;
                CustomPrintPreviewCommand cmd = new CustomPrintPreviewCommand(richEditControl);
                cmd.Execute();
            }
        }
    }
}
