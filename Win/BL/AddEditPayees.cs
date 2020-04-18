using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using Helpers;
using Models;
using Models.Repository;
using Win.OB;

namespace Win.BL
{
    public class AddEditPayees : ITransactions<Payees>
    {
        private frmAddEditPayee frm;
        public bool isClosed;
        private Payees payees;
        private int payeeId;
        private StaticSettings staticSettings = new StaticSettings();
        public AddEditPayees(frmAddEditPayee frm, Payees payees)
        {
            this.frm = frm;
            this.payees = payees;
            this.frm.txtOffice.Properties.DataSource = new BindingList<Offices>(new UnitOfWork().OfficesRepo.Get(m => m.Id == staticSettings.OfficeId));
            this.frm.cboMembers.Properties.DataSource =
                new BindingList<Employees>(
                    new UnitOfWork().EmployeesRepo.Get(m => m.OfficeId == staticSettings.OfficeId));

        }
        public MethodType methodType { get; set; }
        public void Save()
        {
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                var unitOfWork = new UnitOfWork();
                var office = frm.txtOffice.GetSelectedDataRow() as Offices;
                payees = unitOfWork.PayeesRepo.Find(m => m.Id == payees.Id, includeProperties: "Employees");

                payees.Id = payees.Id;
                payees.Name = frm.txtName.Text;
                payees.Office = office?.OfficeName;
                payees.Address = office?.Address;
                payees.Note = frm.txtNote.Text;
                var res = frm.cboMembers.Properties.GetCheckedItems();
                payees.Employees.Clear();
                foreach (var i in res.ToString()?.Split(','))
                {
                    var id = i.Trim().ToInt();
                    payees.Employees.Add(unitOfWork.EmployeesRepo.Find(m => m.Id == id));

                }
                unitOfWork.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            if (methodType == MethodType.Add)
                return;
            try
            {
                var item = payees; //?? new UnitOfWork().PayeesRepo.Find(m => m.Id == this.pay);
                if (item == null) return;
                frm.txtName.Text = item.Name;
                frm.txtAddress.Text = item.Address;
                frm.txtOffice.Text = item.Office;
                frm.txtNote.Text = item.Note;
                foreach (var i in frm.cboMembers.Properties.GetItems().Cast<CheckedListBoxItem>())
                {
                    var id = i.Value.ToInt();
                    if (item.Employees.Any(x => x.Id == id))
                        i.CheckState = CheckState.Checked;
                }
              //  frm.cboMembers.EditValue = string.Join(",", item.Employees.Select(x => x.EmployeeName));


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                var unitOfWork = new UnitOfWork();
                payees = new Payees();
                unitOfWork.PayeesRepo.Insert(payees);
                unitOfWork.Save();
                payeeId = payees.Id;
                return;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs formClosing)
        {
            try
            {
                if (methodType == MethodType.Edit)
                    return;
                if (isClosed)
                    return;
                var unitOfWork = new UnitOfWork();
                //this.payeeId =
                //    (unitOfWork.PayeesRepo.Fetch().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
                unitOfWork.PayeesRepo.Delete(m => m.Id == payeeId);
                unitOfWork.Save();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
