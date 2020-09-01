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
using Models;
using Models.Repository;

namespace DMS.DocTypes
{
    public partial class UCDocumentTypes : DevExpress.XtraEditors.XtraUserControl
    {
        public UCDocumentTypes()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                this.documentTypesBindingSource.DataSource = unitOfWork.DocumentTypesRepo.Get();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DocumentTypeGridView.GetFocusedRow() is DocumentTypes item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                try
                {
                    UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                    unitOfWork.DocumentTypesRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DocumentTypeGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is DocumentTypes item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork(new DTSDb());
                if (item.Id == 0)
                {
                    unitOfWork.DocumentTypesRepo.Insert(item);
                }
                else
                {
                    var res = unitOfWork.DocumentTypesRepo.Find(x => x.Id == item.Id);
                    res.DocumentType = item.DocumentType;
                    unitOfWork.Save();
                }
                unitOfWork.Save();
            }
        }
    }
}
