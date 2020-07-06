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
                    unitOfWork.Signatories.Delete(m=>m.Id==item.Id);
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
                item.Person = item.Person.ToUpper();
                if (item.Id == 0)
                {

                    unitOfWork.Signatories.Insert(item);
                }
                else
                {
                    var res = unitOfWork.Signatories.Find(x => x.Id == item.Id);
                    res.Person = item.Person;
                    res.Position = item.Position;
                    res.Note = item.Note;
                    res.Year = item.Year;
                    res.Office = item.Office;
                    res.IsBacMember = item.IsBacMember;
                    res.BacPosition = item.BacPosition;
                }

                unitOfWork.Save();
                Init();
            }
        }

        public void Init()
        {
            var year = new StaticSettings().Year;
            gridControl1.DataSource = new BindingList<Signatories>(new UnitOfWork().Signatories.Get(m => m.Year == year));
            cboPosition.DataSource = new EntityServerModeSource()
            {
                QueryableSource = new UnitOfWork().PositionsRepo.Fetch(),
                ElementType = typeof(Signatories)
            };
          //  cboOfficeRepo.DataSource = new UnitOfWork().OfficesRepo.Get();
            cboHead.DataSource = new UnitOfWork().OfficesRepo.Get();
        }

        public void Detail(Signatories item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void SignatoriesGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {


        }

        private void SignatoriesGridView_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colPerson")
            {
                if (SignatoriesGridView.GetRow(e.RowHandle) is Signatories item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var office = unitOfWork.OfficesRepo.Find(x => x.Chief == item.Person);
                    item.Office = office.OfficeName;
                    item.Position = office.ChiefPosition;
                }
            }

        }

        private void SignatoriesGridView_ShownEditor(object sender, EventArgs e)
        {

        }

        private void SignatoriesGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colPerson")
            {
                if (SignatoriesGridView.GetRow(e.RowHandle) is Signatories item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var office = unitOfWork.OfficesRepo.Find(x => x.Chief == item.Person);
                    item.Office = office.OfficeName;
                    item.Position = office.ChiefPosition;
                }
            }
        }
    }
}