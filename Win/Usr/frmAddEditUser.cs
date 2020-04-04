﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using Helpers;
using Models;
using Models.Repository;
using Models.Startups;
using Win.BL;

namespace Win.Usr
{
    public partial class frmAddEditUser : DevExpress.XtraEditors.XtraForm, ITransactions<Users>
    {
        public frmAddEditUser(MethodType method, Users user)
        {
            InitializeComponent();
            this.user = user;
            this.methodType = method;
            Init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();

        }

        public MethodType methodType { get; set; }
        private Users user;
        private bool isClosed;

        public async void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;


                UnitOfWork unitOfWork = new UnitOfWork();
                user = new UnitOfWork().UsersRepo.Find(m => m.Id == user.Id, includeProperties: "UserRoles");
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.FirstName = txtFirstName.Text;
                user.MiddleName = txtMiddleName.Text;
                user.UserName = txtUserName.Text;
                user.PasswordHash = Cryptography.Encrypt(txtPassword.Text, user.SecurityStamp);
                unitOfWork.Save();


                ApplicationUserManager applicationUserManager =
                    new ApplicationUserManager(new UserStores(new ModelDb()));
                var roles = await applicationUserManager.GetRolesAsync(user.Id);
                await applicationUserManager.RemoveFromRolesAsync(user.Id, roles.ToArray());
                foreach (string i in cboUserRole.Properties.GetItems().GetCheckedValues())
                {
                    await applicationUserManager.AddToRoleAsync(user.Id, i);
                }


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
            user = new UnitOfWork().UsersRepo.Find(m => m.Id == user.Id);
            if (user == null)
                return;
            txtUserName.Text = user.UserName;
            txtFirstName.Text = user.FirstName;
            txtMiddleName.Text = user.MiddleName;
            txtLastName.Text = user.LastName;
            txtPassword.Text = Cryptography.Decrypt(user.PasswordHash, user.SecurityStamp);

            cboUserRole.EditValue = user.UserRole;

            userRolesBindingSource.DataSource = new BindingList<UserRoles>(new UnitOfWork().UserRolesRepo.Get());
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Add)
                {
                    user = new Users()
                    {
                        SecurityStamp = Guid.NewGuid().ToString(),
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        Id = Guid.NewGuid().ToString(),
                    };
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.UsersRepo.Insert(user);
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
            if (isClosed)
            {

                return;
            }

            if (methodType == MethodType.Edit)
                return;

            if (MessageBox.Show("Do you want to close this?", "Close", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
            {
                eventArgs.Cancel = true;
                return;
            }

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.UsersRepo.Delete(m => m.Id == user.Id);
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

        private void frmAddEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }
    }
}