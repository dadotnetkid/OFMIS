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
using Helpers;
using Models.Repository;
using Win.PPMS.Properties;

namespace Win.PPMS
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool isClosed;

        public frmLogin()
        {
            InitializeComponent();
            txtToday.Text = DateTime.Now.ToString();
        }



        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Settings.Default.RememberMe)
            {
                txtPassword.Text = Settings.Default.Password;
                txtUserName.Text = Settings.Default.UserName;
                chkRemember.Checked = Settings.Default.RememberMe;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (new CMS.Models.cmsEntities().Database.Connection.State == ConnectionState.Open)
            {
                var cms_user = new UnitOfWork(new CMS.Models.cmsEntities()).CMS_USERRepo.Find(x => x.USER_nme == txtUserName.Text);

                if (cms_user != null)
                {
                    if (!unitOfWork.UsersRepo.Fetch(x => x.UserName == cms_user.USER_nme).Any())
                        unitOfWork.UsersRepo.Insert(new Models.Users()
                        {
                            Id = Guid.NewGuid().ToString(),
                            UserName = cms_user.USER_nme,
                            Email = cms_user.USER_email,
                            FirstName = cms_user.USER_fnm,
                            MiddleName = cms_user.USER_mnm,
                            LastName = cms_user.USER_lnm,
                            SecurityStamp = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio",
                            PasswordHash = cms_user.USER_pwd
                        });
                    unitOfWork.Save();
                }}
             
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