using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.ToastNotifications;
using Models.Repository;


namespace Win.PPMS
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private string[] param;

        public Main()
        {
            new frmSplashScreen().ShowDialog();
            InitializeComponent();
        }

        void Init(bool isLogged = false)
        {
            Form frm = new frmLogin();
            if (isLogged == false)
                frm.ShowDialog();
            lblUsername.Caption = $"Name: {User.GetFullName() }";
            lblUserLevel.Caption = $"User Level: {User.GetUserLevel()}";
          
        }
        private void btnObligation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!User.UserInAction("Obligations"))
                return;
        

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

      

       

        private void btnItems_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

       




        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

            if (MessageBox.Show("Do you want to close this application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            backstageViewControl1.Close();
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            Init(true);
        }

      

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
      

       
    }
}
