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

namespace Win.Actns
{
    public partial class frmUsersInAccounts : DevExpress.XtraEditors.XtraForm
    {
        private DocumentActions documentActions;
        private List<string> userIds;
        public frmUsersInAccounts(DocumentActions documentActions)
        {
            InitializeComponent();
            this.documentActions = documentActions;
            userIds = documentActions.Users.Select(x => x.Id).ToList();
            this.Init();
        }

        private void Init()
        {
            this.Search(txtSearch.Text);
        }

        private void Search(string search = "")
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var users = unitOfWork.UsersRepo.Get(x => x.UserName.Contains(search) || (x.FirstName + " " + ". " + x.LastName).Contains(search));

            foreach (var i in users)
            {
                i.IsSelectedUserInDocuments = documentActions.Users.Any(x => x.Id == i.Id);
            }

            foreach (var i in users)
            {
                i.IsSelectedUserInDocuments = userIds.Any(x => x == i.Id);
            }
            this.usersBindingSource.DataSource = users;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(txtSearch.Text);
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            documentActions = unitOfWork.DocumentActionsRepo.Find(x => x.Id == documentActions.Id);
            documentActions.Users.Clear();
            foreach (var i in userIds)
            {
                documentActions.Users.Add(unitOfWork.UsersRepo.Find(x => x.Id == i));
            }
            unitOfWork.Save();
            Close();
        }

        private void UsersGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (UsersGridView.GetRow(e.RowHandle) is Users user)
            {

                if (user.IsSelectedUserInDocuments)
                {
                    userIds.Add(user.Id);
                }
                else
                {
                    userIds.Remove(user.Id);
                }
            }
        }

        private void UsersGridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Column.Name == "colIsSelected")
            {

            }
        }

        private void UsersGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is Users item)
            {
                if (item.IsSelectedUserInDocuments)
                    userIds.Add(item.Id);
                else
                    userIds.Remove(item.Id);
            }
        }
    }
}