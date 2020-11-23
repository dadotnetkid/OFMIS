using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Repository;
using Models.Startups;
using Win.Properties;
using DevExpress.Utils.OAuth;
using Newtonsoft.Json;
using Models.ViewModels;

namespace Win
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool isClosed;
        private List<Users> users = new List<Users>();

        private HttpClient httpClient;
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
            this.httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Program.URL)
            };
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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var tokenResult = await (await httpClient.PostAsync("token", new FormUrlEncodedContent(new Dictionary<string, string>()
            {
                {"password", txtPassword.Text},
                {"username", txtUserName.Text},
                {"grant_type", "password"}
            }))).Content.ReadAsStringAsync();
            var token = JsonConvert.DeserializeObject<LoginViewModel>(tokenResult);
            if (!string.IsNullOrEmpty(token.Error))
            {
                MessageBox.Show(token.ErrorDescription, "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


            User.Token = token;
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