using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
        StaticSettings staticSettings = new StaticSettings();
        public AddEditPayroll(frmAddEditPayroll frm, int obId)
        {

            UnitOfWork unitOfWork = new UnitOfWork();
            this.obId = obId;
            this.frm = frm;
            frm.btnSave.Click += BtnSave_Click;
            frm.btnClose.Click += BtnClose_Click;
            frm.FormClosing += Frm_FormClosing;
            frm.PayrollGridView.RowUpdated += PayrollGridView_RowUpdated;
            frm.btnDeletePayrollRepo.ButtonClick += BtnDeletePayrollRepo_ButtonClick;
            frm.btnEditPayrollRepo.ButtonClick += BtnEditPayrollRepo_ButtonClick;
            if (staticSettings.Offices.IsDivision == true)
            {
                var officeName = staticSettings.Offices.UnderOfOffice.OfficeName;
                frm.txtDeptHead.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get(m => m.Office == officeName));
            }
            frm.txtAccountant.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")));
            frm.txtTreasurer.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get(m => m.Office.Contains("Treasurer")));
            frm.cboApprovedBy.Properties.DataSource = new BindingList<Signatories>(
                unitOfWork.Signatories.Get(x =>
                    x.Position.Contains("Governor") || x.Position.Contains("Provincial Administrator")));
            frm.lookUpEditEmployees.DataSource =
                new BindingList<Employees>(unitOfWork.EmployeesRepo.Get());
            frm.txtAccountant.ItemIndex = 0;
        }

        private void BtnEditPayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frm.PayrollGridView.GetFocusedRow() is DataRowView item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var id = item["Id"].ToInt();
                unitOfWork.PayrollDetailsRepo.Delete(m => m.Id == id);
                unitOfWork.Save();

            }
        }

        private void BtnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (frm.PayrollGridView.GetFocusedRow() is DataRowView item)
            {
                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                var id = item["Id"].ToInt();
                unitOfWork.PayrollDetailsRepo.Delete(m => m.Id == id);
                unitOfWork.Save();
                InitializeGridView(unitOfWork.PayrollsRepo.Find(x => x.Id == obId));
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
                p.ColumnTitle1 = frm.txtColumnTitle.Text;
                p.ChiefOfOffice = frm.txtChief.Text;
                p.Position = staticSettings.HeadPos;

                p.Accountant = (frm.txtAccountant.GetSelectedDataRow() as Signatories)?.Person;
                p.AccountantPos = (frm.txtAccountant.GetSelectedDataRow() as Signatories)?.Position;
                p.Treasurer = (frm.txtTreasurer.GetSelectedDataRow() as Signatories)?.Person;
                p.TreasurerPos = (frm.txtTreasurer.GetSelectedDataRow() as Signatories)?.Position;
                p.DeptHead = (frm.txtDeptHead.GetSelectedDataRow() as Signatories)?.Person;
                p.DeptHeadPos = (frm.txtDeptHead.GetSelectedDataRow() as Signatories)?.Position;
                p.ApprovedById = (frm.cboApprovedBy.GetSelectedDataRow() as Signatories)?.Id;
                p.ApprovedBy = (frm.cboApprovedBy.GetSelectedDataRow() as Signatories)?.Person;
                p.ApprovedByPos = (frm.cboApprovedBy.GetSelectedDataRow() as Signatories)?.Position;
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
                var staticSettings = new StaticSettings();
                UnitOfWork unitOfWork = new UnitOfWork();
                var item = unitOfWork.PayrollsRepo.Find(m => m.Id == obId);
                frm.txtDate.DateTime = item.Date ?? DateTime.Now;
                frm.txtControl.Text = item.ControlNo;
                frm.txtPayTitle.Text = item.Title;
                frm.txtPayDescription.Text = string.IsNullOrWhiteSpace(item.Description) ? frm.txtPayDescription.Text : item.Description;
                frm.txtColumnTitle.Text = item.ColumnTitle1;
                frm.txtDeptHead.Properties.DataSource = new BindingList<Signatories>(unitOfWork.Signatories.Get());
                if (staticSettings.Offices.IsDivision == true)
                {
                    frm.txtChief.Text = item.ChiefOfOffice ?? staticSettings.Head;
                }


                frm.txtAccountant.EditValue = item.Accountant ?? (unitOfWork.Signatories.Get(m => m.Office.Contains("Accounting") || m.Office.Contains("Accountant")))?.FirstOrDefault()?.Person;

                frm.txtTreasurer.EditValue = item.Treasurer ?? (unitOfWork.Signatories.Get(m => m.Office.Contains("Treasurer")))?.FirstOrDefault()?.Person; ;
                if (staticSettings.Offices.IsDivision == true)
                {
                    frm.txtDeptHead.EditValue = item.DeptHead ?? (unitOfWork.Signatories.Get(m => m.Office.Contains(staticSettings.OfficeName))?.FirstOrDefault()?.Person);
                }
                else
                {
                    //
                    frm.txtDeptHead.EditValue = item.DeptHead ?? staticSettings.Head;
                }
                frm.cboApprovedBy.EditValue = item.ApprovedBy;
                frm.lblHeader.Text = frm.txtPayDescription.Text;
                InitializeGridView(item);
                frm.txtColumnTitle.Leave += (s, e) => { InitializeGridView(item); };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InitializeGridView(Payrolls item)
        {

            DataTable dt = new DataTable();
            var columnTitles = string.IsNullOrWhiteSpace(frm.txtColumnTitle.Text) ? null : frm.txtColumnTitle?.Text?.Split(',');
            dt.Columns.AddRange(new[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("ItemNumber", typeof(string)),
                new DataColumn("PayrollId", typeof(string)),
                new DataColumn("Designation", typeof(string)),
                new DataColumn("Total", typeof(decimal)){},
                new DataColumn("EmployeeId", typeof(Int32)){},
            });
            if (columnTitles != null)
            {
                foreach (var i in columnTitles)
                {
                    dt.Columns.Add(new DataColumn(i, typeof(decimal)) { AllowDBNull = true });
                }

                for (var i = 0; i <= item.PayrollDetails.Count() - 1; i++)
                {
                    var row = dt.NewRow();
                    row["Id"] = item.PayrollDetails.ToList()[i]?.Id;
                    row["Name"] = item.PayrollDetails.ToList()[i]?.Name;
                    row["ItemNumber"] = item.PayrollDetails.ToList()[i]?.ItemNumber;
                    row["PayrollId"] = item.PayrollDetails.ToList()[i]?.PayrollId;
                    row["Designation"] = item.PayrollDetails.ToList()[i]?.Designation;
                    row["Total"] = item.PayrollDetails.ToList()[i]?.Total;
                    row["EmployeeId"] = item.PayrollDetails.ToList()[i].EmployeeId;
                    for (var x = 0; x <= columnTitles.Count() - 1; x++)
                    {
                        var columnTitle = item.PayrollDetails.ToList()[i]?.ColumnTitle?.Split(',')
                            .Select(c => new { columnTitle = c }).ToList();
                        row[columnTitles[x]] =
                            columnTitle?.FirstOrDefault(c => c.columnTitle.Contains(columnTitles[x]))?.columnTitle
                                ?.Split('=')[1]
                                ?.ToDecimal() ?? 0;
                    }

                    dt.Rows.Add(row);
                }

                frm.PayrollGridView.Columns.Clear();
                frm.PayrollGridView.Columns.AddRange(new[]
                {
                    new GridColumn()
                    {
                        Name = "Id", FieldName = "Id", Caption = "Id",
                        UnboundType = DevExpress.Data.UnboundColumnType.String, VisibleIndex = -1
                    },
                    new GridColumn()
                        {Name = "colDelete", ColumnEdit = frm.btnDeletePayrollRepo, VisibleIndex = 0, Width = 20},
                    new GridColumn()
                    {
                        Name = "ItemNumber", FieldName = "ItemNumber", Caption = "Item No.", Width = 25,
                        UnboundType = DevExpress.Data.UnboundColumnType.String, VisibleIndex = 1
                    },
                    new GridColumn()
                    {
                        Name = "Name", FieldName = "EmployeeId", Caption = "Name",
                        UnboundType = DevExpress.Data.UnboundColumnType.Integer, VisibleIndex = 2,
                        ColumnEdit = frm.lookUpEditEmployees
                    },
                });
                var index = 3;
                foreach (var i in columnTitles)
                {
                    var c = new GridColumn()
                    {
                        Name = i,
                        FieldName = i,
                        Caption = i,
                        UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
                        VisibleIndex = index,
                        ColumnEdit = frm.spinTotalRepo
                    };
                    c.DisplayFormat.FormatString = "n2";
                    frm.PayrollGridView.Columns.Add(c);
                    index++;
                }

                var t = new GridColumn()
                {
                    Name = "Total",
                    FieldName = "Total",
                    Caption = "Total",
                    UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
                    VisibleIndex = index
                };
                t.DisplayFormat.FormatString = "n2";
                frm.PayrollGridView.Columns.Add(t);
            }

            frm.PayrollGridControl.DataSource = dt;
        }
        private void PayrollGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {


                if (e.Row is DataRowView row)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    var employeeId = row["EmployeeId"]?.ToInt();

                    var employee = unitOfWork.EmployeesRepo.Find(m => m.Id == employeeId);
                    if (employee == null)
                    {
                        if (sender is GridView gridView)
                        {
                            gridView.SetFocusedRowModified();
                            return;
                        }
                    }
                    var item = new PayrollDetails()
                    {
                        Id = row["Id"].ToInt(),
                        ItemNumber = row["ItemNumber"].ToInt(),
                        Name = employee?.EmployeeName,
                        Designation = employee?.Position,
                        EmployeeId = employeeId,
                    };
                    item.PayrollId = obId;
                    item.Total = 0;
                    foreach (var i in frm.txtColumnTitle.Text.Split(','))
                    {
                        item.Total += row[i]?.ToDecimal() ?? 0;
                        item.ColumnTitle += i + "=" + (row[i]?.ToDecimal() ?? 0) + ",";
                    }
                    row["Total"] = item.Total;


                    if (item.Id == 0)
                        unitOfWork.PayrollDetailsRepo.Insert(item);
                    else
                        unitOfWork.PayrollDetailsRepo.Update(item);
                    unitOfWork.Save();
                    InitializeGridView(unitOfWork.PayrollsRepo.Find(x => x.Id == obId));
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var approvedBy = unitOfWork.Signatories.Find(x => x.Position == "Governor");



                    payrolls = new Payrolls()
                    {
                        Id = obId,
                        ControlNo = IdHelper.OfficeControlNo(item?.FirstOrDefault()?.ControlNo),
                        Date = DateTime.Now,
                        ColumnTitle1 = "Column Title",
                        ApprovedBy = approvedBy?.Person,
                        ApprovedById = approvedBy?.Id,
                        ApprovedByPos = approvedBy?.Position
                    };
                    int itemNo = 1;
                    foreach (var i in unitOfWork.ObligationsRepo.Find(m => m.Id == obId).Payees.Employees.OrderBy(x => x.LastName))
                    {
                        payrolls.PayrollDetails.Add(new PayrollDetails()
                        {
                            ItemNumber = itemNo,
                            EmployeeId = i.Id,
                            Name = i.EmployeeName,
                            Designation = i.Position,
                            Total = 0,
                            ColumnTitle = "Column Title=0.0"

                        });
                    }
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
