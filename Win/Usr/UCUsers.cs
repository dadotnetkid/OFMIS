﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMS.Models;
using DevExpress.Data.Linq;
using DevExpress.UserSkins;
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
            var unitOfWork = new UnitOfWork();
            UserGridControl.DataSource = new BindingList<Users>(unitOfWork.UsersRepo.Get());
        }

        public void Detail(Users item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            try
            {
                var unitOfWork = new UnitOfWork();
                IQueryable<Users> users = unitOfWork.UsersRepo.Fetch();
                if (users.Select(x => new { FullName = x.FirstName + ", " + x.MiddleName + " " + x.LastName })
                    .Any(x => x.FullName.Contains(search)))
                {
                    users = users.Where(x => (x.FirstName + ", " + x.MiddleName + " " + x.LastName).Contains(search));
                }

                else if (users.Select(x => new {x.UserName}).Any(x => x.UserName.Contains(search)))
                    users = users.Where(x => x.UserName.Contains(search));
                
                UserGridControl.DataSource = new BindingList<Users>(users.ToList());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnImpersonateRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UserGridView.GetFocusedRow() is Users item)
            {
                var th = new Thread(() =>
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    BonusSkins.Register();

                    Application.Run(new Main(new string[] { item.Id }));
                });
                th.ApartmentState = ApartmentState.STA;
                th.Start();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            foreach (var i in new UnitOfWork(new cmsEntities()).CMS_USERRepo.Get())
            {
                if (unitOfWork.UsersRepo.Fetch(x => x.UserName == i.USER_nme).Any())
                    continue;
                unitOfWork.UsersRepo.Insert(new Users()
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = i.USER_nme,
                    Email = i.USER_email,
                    FirstName = i.USER_fnm,
                    MiddleName = i.USER_mnm,
                    LastName = i.USER_lnm,
                    SecurityStamp = "0ram@1234xxxxxxxxxxtttttuuuuuiiiiio",
                    PasswordHash = i.USER_pwd,
                    UserRoles = new List<UserRoles>() { unitOfWork.UserRolesRepo.Find(x => x.Name == "User") },
                });
                unitOfWork.Save();
            }

            Init();
        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            Search(txtSearch.Text);
        }
    }
}
