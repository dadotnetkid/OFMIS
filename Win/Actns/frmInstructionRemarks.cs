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

namespace Win.Actns
{
    public partial class frmInstructionRemarks : DevExpress.XtraEditors.XtraForm
    {
        public frmInstructionRemarks()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.actionTakensBindingSource .DataSource=
                     unitOfWork.ActionTakensRepo.Get(x => x.TableName == "Remarks", orderBy: x => x.OrderBy(m => m.ActionTaken));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InstructionRemarksGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is ActionTakens item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                item.TableName = "Remarks";
                if (item.Id == 0)
                {
                    unitOfWork.ActionTakensRepo.Insert(item);
                    unitOfWork.Save();
                }
                else
                {
                    var res = unitOfWork.ActionTakensRepo.Find(x => x.Id == item.Id);
                    res.ActionTaken = item.ActionTaken;
                    unitOfWork.Save();
                }
                Init();
            }
        }

        private void btnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                if (InstructionRemarksGridView.GetFocusedRow() is ActionTakens item)
                {
                    unitOfWork.ActionTakensRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                }

                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}