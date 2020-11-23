using System;
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
    public partial class UCUserLevels : DevExpress.XtraEditors.XtraUserControl, ILoad<UserRoles>
    {
        public UCUserLevels()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            UserLevelGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().UserRolesRepo.Fetch()
            };
        }

        public void Detail(UserRoles item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

      

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddEditUserLevel frm = new frmAddEditUserLevel(MethodType.Add, new UserRoles());
            frm.ShowDialog();
            Init();

        }

        private void btnEditUserRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UserLevelGridView.GetFocusedRow() is UserRoles item)
            {
                frmAddEditUserLevel frm = new frmAddEditUserLevel(MethodType.Edit, item);
                frm.ShowDialog();
                Init();
            }

        }

        private void btnDeleteUserRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UserLevelGridView.GetFocusedRow() is UserRoles item)
            {
                try
                {
                    if (!User.UserInAction("can delete"))
                        return;
                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.UserRolesRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
