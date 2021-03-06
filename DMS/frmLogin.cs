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
using DMS.Properties;
using Helpers;
using Models;
using Models.Repository;
using Win;

namespace DMS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool isClosed;
        private List<Users> users = new List<Users>();
        public frmLogin()
        {
            InitializeComponent();
            txtToday.Text = DateTime.Now.ToString();
            if (Settings.Default.UserNames == null)
            {
                Settings.Default.UserNames = new System.Collections.Specialized.StringCollection();
            }
            foreach (var i in Settings.Default.UserNames)
            {
                if (users.All(x => x.UserName != i))
                    users.Add(new Users() { Id = Guid.NewGuid().ToString(), UserName = i });
            }
            this.txtUserName.Properties.DataSource = users;

        }



        private void frmLogin_Load(object sender, EventArgs e)
        {

            if (Settings.Default.RememberMe)
            {
                txtPassword.Text = Settings.Default.Password;
                txtUserName.EditValue = Settings.Default.UserName;
                chkRemember.Checked = Settings.Default.RememberMe;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
                   UnitOfWork unitOfWork = new UnitOfWork();
          
            unitOfWork = new UnitOfWork();
            var user = unitOfWork.UsersRepo.Find(m => m.UserName == txtUserName.Text);

            if (user == null)
            {
                MessageBox.Show("Invalid UserName", "Invalid UserName", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Cryptography.Encrypt(txtPassword.Text, user.SecurityStamp ?? "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio") != user.PasswordHash)
            {
                MessageBox.Show("Invalid UserName", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Settings.Default.UserNames.Contains(txtUserName.Text))
                Settings.Default.UserNames.Add(txtUserName.Text);

            if (chkRemember.Checked)
            {
                Settings.Default.UserName = txtUserName.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.RememberMe = chkRemember.Checked;
                Settings.Default.Save();
            }
            else
            {
                Settings.Default.UserName = string.Empty;
                Settings.Default.Password = string.Empty;
                Settings.Default.RememberMe = false;
                Settings.Default.Save();
            }


            User.UserId = user.Id;
            isClosed = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnServerSetup_Click(object sender, EventArgs e)
        {
            ConnectionDialog.ShowDialog();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!this.isClosed)
                Application.ExitThread();
        }
    }
}