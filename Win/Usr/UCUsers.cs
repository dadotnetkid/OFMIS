﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Usr
{
    public partial class UCUsers : DevExpress.XtraEditors.XtraUserControl, ILoad<Users>
    {
        public UCUsers()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            Init();
        }

        private void btnEditUserRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UserGridView.GetFocusedRow() is Users item)
            {
                frmAddEditUser frm = new frmAddEditUser(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }
        }

        public void Init()
        {
            UserGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().UsersRepo.Fetch()
            };
        }

        public void Detail(Users item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnDeleteUserRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                var res = UserGridView.GetFocusedRow();
                if (UserGridView.GetFocusedRow() is Users item)
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.UsersRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(MethodType.Add, new Users());
            frm.ShowDialog();
            Init();

        }
    }
}