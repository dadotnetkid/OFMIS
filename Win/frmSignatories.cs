using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Models;
using Models.Repository;
using Win.BL;

namespace Win
{
    public partial class frmSignatories : DevExpress.XtraEditors.XtraForm, ILoad<Signatories>
    {
        public frmSignatories()
        {
            InitializeComponent();
            Init();
            btnDeleteSignatory.ButtonClick += btnDeleteSignatory_ButtonClick;
        }

        private void btnDeleteSignatory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                if (SignatoriesGridView.GetFocusedRow() is Signatories item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.ChiefOfOfficesRepo.Delete(item);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SignatoriesGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is Signatories item)
            {



                UnitOfWork unitOfWork = new UnitOfWork();
                item.Year = item.Year ?? new StaticSettings().Year;
                if (item.Id == 0)
                {

                    unitOfWork.ChiefOfOfficesRepo.Insert(item);
                }
                else
                {
                    unitOfWork.ChiefOfOfficesRepo.Update(item);
                }

                unitOfWork.Save();
                Init();
            }
        }

        public void Init()
        {
            var year = new StaticSettings().Year;
            gridControl1.DataSource = new BindingList<Signatories>(new UnitOfWork().ChiefOfOfficesRepo.Get(m => m.Year == year));
            cboPosition.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PositionsRepo.Fetch(),
                ElementType = typeof(Signatories)
            };
        }

        public void Detail(Signatories item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
    }
}