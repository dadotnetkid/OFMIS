using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;
using Models;
using Models.Repository;
using Win.Pyrll;

namespace Win.BL
{
    public class AddEditPayroll : ITransactions<Payrolls>
    {
        private Payrolls payrolls;
        private frmAddEditPayroll frm;
        private int obId;
        private bool isClosed;

        public AddEditPayroll(frmAddEditPayroll frm, int obId)
        {
            this.obId = obId;
            this.frm = frm;
            frm.btnSave.Click += BtnSave_Click;
            frm.btnClose.Click += BtnClose_Click;
            frm.FormClosing += Frm_FormClosing;
            frm.PayrollGridView.RowUpdated += PayrollGridView_RowUpdated;
            frm.btnDeletePayrollRepo.ButtonClick += BtnDeletePayrollRepo_ButtonClick;
            frm.btnEditPayrollRepo.ButtonClick += BtnEditPayrollRepo_ButtonClick;
        }

        private void BtnEditPayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frm.PayrollGridView.GetFocusedRow() is PayrollDetails item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
            }
        }

        private void BtnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frm.PayrollGridView.GetFocusedRow() is PayrollDetails item)
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.PayrollDetailsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();
                Detail();
            }
        }

        private void PayrollGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                if (e.Row is PayrollDetails item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    item.PayrollId = obId;
                    item.Total = item.ColumnTitle1 + item.ColumnTitle2;
                    if (item.Id == 0)
                        unitOfWork.PayrollDetailsRepo.Insert(item);
                    else
                        unitOfWork.PayrollDetailsRepo.Update(new PayrollDetails()
                        {
                            Id = item.Id,
                            ColumnTitle1 = item.ColumnTitle1,
                            ColumnTitle2 = item.ColumnTitle2,
                            Designation = item.Designation,
                            ItemNumber = item.ItemNumber,
                            Name = item.Name,
                            PayrollId = item.PayrollId,
                            Total = item.Total
                        });
                    unitOfWork.Save();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            frm.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();

        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var p = unitOfWork.PayrollsRepo.Find(m => m.Id == obId);
                p.Date = frm.txtDate.DateTime;
                p.Description = frm.txtPayDescription.Text;
                p.Title = frm.txtPayTitle.Text;
                p.ColumnTitle1 = frm.txtColumn1.Text;
                p.ColumnTitle2 = frm.txtColumn2.Text;
                p.ChiefOfOffice = frm.txtChief.Text;
                p.Position = frm.txtPosition.Text;
                unitOfWork.Save();
                this.isClosed = true;
                frm.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            try
            {
                var item = new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId);
                frm.txtDate.DateTime = item.Date ?? DateTime.Now;
                frm.txtControl.Text = item.ControlNo;
                frm.txtPayTitle.Text = item.Title;
                frm.txtPayDescription.Text = item.Description;
                frm.txtColumn1.Text = item.ColumnTitle1;
                frm.txtColumn2.Text = item.ColumnTitle2;
                frm.txtChief.Text = item.ChiefOfOffice;
                frm.txtPosition.Text = item.Position;
                frm.txtAccountant.Text = item.Accountant;
                frm.txtTreasurer.Text = item.Treasurer;
                frm.lblHeader.Text = item.Description;
                frm.PayrollGridControl.DataSource = new BindingList<PayrollDetails>(item.PayrollDetails.ToList());
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
                UnitOfWork unitOfWork = new UnitOfWork();
                if (methodType == MethodType.Add)
                {
                    var item = unitOfWork.PayrollsRepo.Fetch().OrderByDescending(m => m.Id);
                    var id = (item.FirstOrDefault()?.Id ?? 0) + 1;

                    payrolls = new Payrolls()
                    {
                        Id = obId,
                        ControlNo = IdHelper.OfficeControlNo(item?.FirstOrDefault()?.ControlNo),
                        Date = DateTime.Now
                    };
                    unitOfWork.PayrollsRepo.Insert(payrolls);
                    unitOfWork.Save();
                }

                Detail();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Close(FormClosingEventArgs eventArgs)
        {

        }
    }
}
