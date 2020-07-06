using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Win.BL;
using Models;
using Models.Repository;

namespace Win.AOQ
{
    public partial class frmBACCommittees : DevExpress.XtraEditors.XtraForm, ILoad<Signatories>
    {
        private Models.AOQ item;
        private IEnumerable<int> selected;

        public frmBACCommittees(Models.AOQ item)
        {
            InitializeComponent();

            this.item = item;
            //btnAddRepo.ButtonClick += BtnAddRepo_ButtonClick;
            //btnRemove.ButtonClick += btnRemove_ButtonClick;
            Init();
        }

        private void btnRemove_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.BACGridView.GetFocusedRow() is Signatories signatories)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item = unitOfWork.AOQRepo.Find(x => x.Id == item.Id);
                    item.BacMembers.Remove(unitOfWork.Signatories.Find(x => x.Id == signatories.Id, false));
                    unitOfWork.Save();
                }

                Init();
            }
            catch (Exception exception)
            {

            }
        }

        private void BtnAddRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (this.BACGridView.GetFocusedRow() is Signatories signatories)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item = unitOfWork.AOQRepo.Find(x => x.Id == item.Id);
                    item.BacMembers.Add(unitOfWork.Signatories.Find(x => x.Id == signatories.Id, false));
                    unitOfWork.Save();
                }

                Init();
            }
            catch (Exception exception)
            {

            }
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.AOQRepo.Find(x => x.Id == item.Id);

                this.selected = item.BacMembers.Select(x => x.Id);
                var source = new UnitOfWork().Signatories.Get(m => m.IsBacMember == true);
                foreach (var i in source)
                    i.isSelected = selected.Any(x => x == i.Id);

                this.BACGridControl.DataSource = source;

            }
            catch (Exception e)
            {

            }
        }

        public void Detail(Signatories item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {

        }




        private void frmBACCommittees_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            item = unitOfWork.AOQRepo.Find(x => x.Id == item.Id, "BacMembers");
            item.BacMembers.Clear();
            foreach (var i in BACGridView.GetSelectedRows())
            {
                if (BACGridView.GetRow(i) is Signatories signatories)
                {
                    item.BacMembers.Add(unitOfWork.Signatories.Find(x => x.Id == signatories.Id, false));
                }
            }

            unitOfWork.Save();
            this.Close();
        }
    }
}