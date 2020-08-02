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
using Models.Repository;
using Models;

namespace Win.Actns
{
    public partial class frmActionTaken : DevExpress.XtraEditors.XtraForm
    {
        public frmActionTaken()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.actionTakensBindingSource.DataSource = unitOfWork.ActionTakensRepo.Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionTakenGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                if (e.Row is ActionTakens item)
                {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            try
            {
                if (!User.UserInAction("Delete Action Taken"))
                    return;

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (ActionTakenGridView.GetFocusedRow() is ActionTakens item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ActionTakensRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}