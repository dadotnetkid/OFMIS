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
using Win.BL;

namespace Win.Usr
{
    public partial class frmAddEditUserLevel : DevExpress.XtraEditors.XtraForm, ITransactions<UserRoles>
    {
        private UserRoles userRoles;
        private bool isClosed;

        public frmAddEditUserLevel(MethodType methodType, UserRoles userRoles)
        {
            InitializeComponent();
            this.userRoles = userRoles;
            this.methodType = methodType;
            Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                userRoles = new UserRoles()
                {
                    Id = userRoles.Id,
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };
                var unitOfWork = new UnitOfWork();
                unitOfWork.UserRolesRepo.Update(userRoles);
                unitOfWork.Save();
                this.isClosed = true;
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            userRoles = new UnitOfWork().UserRolesRepo.Find(m => m.Id == userRoles.Id);
            if (userRoles == null)
                return;
            txtName.Text = userRoles.Name;
            txtDescription.Text = userRoles.Description;
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Add)
                {
                    userRoles = new UserRoles()
                    {
                        Id = Guid.NewGuid().ToString(),

                    };
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.UserRolesRepo.Insert(userRoles);
                    unitOfWork.Save();
                }

                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            if (methodType == MethodType.Edit)
                return;
            if (isClosed)
                return;

            if (MessageBox.Show("Do you want to close this?", "close", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                eventArgs.Cancel = true;
                return;
            }
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.UserRolesRepo.Delete(m => m.Id == userRoles.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUserLevel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }
    }
}