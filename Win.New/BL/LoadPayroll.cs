using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data.Linq;
using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using Helpers;
using Models;
using Models.DataTables;
using Models.Repository;
using Models.ViewModels;
using Win.Pyrll;
using Win.Rprts;

namespace Win.BL
{
    public class LoadPayroll : ILoad<Payrolls>
    {
        private UCPayrolls uCPayrolls;
        private Payrolls payrolls;
        internal SimpleButton btnEditNew, btnDelete;
        private int obId;
        private DataSet ds;

        public LoadPayroll(UCPayrolls uCPayrolls, int obId)
        {
            this.uCPayrolls = uCPayrolls;
            this.obId = obId;
            payrolls = new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId);
            btnEditNew = uCPayrolls.btnEditNew;
            btnDelete = uCPayrolls.btnDelete;
            btnEditNew.Click += BtnEditNew_Click;
            uCPayrolls.btnPreview.Click += BtnPreview_Click;
        }

        private List<OBRPayrollViewModel> oBRPayrollViewModels;
        private PrintOnPageEventHandler printOnPageEventArgs;
        private XRTableCell xRTableCell;

        void AddPageTotalValue(XRTableCell xRTableCell, string columnName)
        {
            this.xRTableCell = xRTableCell;
            printOnPageEventArgs = (sender, e) =>
           {
               var columnTitle1 = sender as XRTableCell;
               oBRPayrollViewModels.Add(new OBRPayrollViewModel()
               {
                   ColumnName = columnName,
                   Value = columnTitle1.Text?.ToDecimal(),
                   PageIndex = e.PageIndex
               });
               columnTitle1.Text = columnTitle1.Text?.ToDecimal().ToString("n2");
           };
            xRTableCell.PrintOnPage += printOnPageEventArgs;


        }

        void CalculatePageTotalValue(XRTableCell xRTableCell, string columnName, bool sumAll = false)
        {
            xRTableCell.PrintOnPage += (sender, e) =>
            {
                var columnTitle1 = sender as XRTableCell;
                var sum = oBRPayrollViewModels.Where(x => x.PageIndex == e.PageIndex && x.ColumnName == columnName).Sum(x => x.Value);

                if (sumAll)
                    sum = oBRPayrollViewModels.Where(x => x.ColumnName == columnName).Sum(x => x.Value);
                columnTitle1.Text = sum?.ToString("n2");
            };
        }
        //TODO: Method to add column header 
        void AddColumnHeader(string[] customColumn, rptOBRPayroll rpt)
        {
            var xrCell = new DevExpress.XtraReports.UI.XRTableCell();
            foreach (var i in customColumn)
            {
                xrCell = new DevExpress.XtraReports.UI.XRTableCell() { Text = i, Name = i };
                xrCell.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[]
                {
                    new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", $"[{i}]")
                });

                rpt.tblRowPayrollDetailHeader.Cells.Add(xrCell);
            }

            //
            rpt.tblRowPayrollDetailHeader.Cells.AddRange(new[]
            {
                new DevExpress.XtraReports.UI.XRTableCell()
                {
                    Text = "TOTAL",
                },
                new DevExpress.XtraReports.UI.XRTableCell()
                {
                    Text = "Signature",
                },
            });
        }

        void AddColumnHeaderDetails(string[] customColumn, rptOBRPayroll rpt)
        {
            var xrCell = new DevExpress.XtraReports.UI.XRTableCell();
            foreach (var i in customColumn)
            {
                xrCell = new DevExpress.XtraReports.UI.XRTableCell()
                {
                    Text = i,
                    Name = i,
                    TextFormatString = "{0:#,##.0#}",
                    WidthF = 150
                };
                xrCell.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[]
                {
                    new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", $"[{i}]")
                });
                AddPageTotalValue(xrCell, i);
                rpt.tblRowPayrollDetails.Cells.Add(xrCell);
            }

            var totalCell = new DevExpress.XtraReports.UI.XRTableCell()
            {
                Text = "TOTAL",
                Name = "colTotal",
                TextFormatString = "{0:#,##.0#}"
            };
            totalCell.ExpressionBindings.AddRange(new ExpressionBindingCollection()
                {new ExpressionBinding("BeforePrint", "Text", $"[Total]")});
            rpt.tblRowPayrollDetails.Cells.Add(totalCell);
            AddPageTotalValue(totalCell, "Total");
            rpt.tblRowPayrollDetails.Cells.Add(new XRTableCell() { Name = "colSig" });
        }

        void InitializePayrollDataset(Payrolls res, string[] customColumn)
        {
            StaticSettings staticSettings = new StaticSettings();

            ds = new dsPayroll();
            var payrollDetails = ds.Tables["PayrollDetails"];
            var payroll = ds.Tables["Payrolls"];
            foreach (var i in customColumn)
            {
                payroll.Columns.Add(new DataColumn(i, typeof(string)) { AllowDBNull = true });
            }

            var pRow = payroll.NewRow();
            pRow["Id"] = res.Id;
            pRow["Date"] = res.Date;
            pRow["ControlNo"] = res.ControlNo;
            pRow["Description"] = res.Description;
            pRow["Title"] = res.Title;
            pRow["DivisionHead"] = res.ChiefOfOffice;
            pRow["DivisionHeadPos"] = res.Position;
            pRow["Accountant"] = res.Accountant;
            pRow["AccountantPOS"] = res.AccountantPos;
            pRow["Treasurer"] = res.Treasurer;
            pRow["TreasurerPOS"] = res.TreasurerPos;
            pRow["Head"] = res.DeptHead;
            pRow["HeadPos"] = res.DeptHeadPos;
            if (staticSettings.Offices.IsDivision == false)
            {
                pRow["Head"] = staticSettings.Head;
                pRow["HeadPos"] = staticSettings.HeadPos;
            }

            pRow["Governor"] = res.Governor?.Person;
            pRow["GovernorPOS"] = res.Governor?.Position;
            pRow["Note"] = res.Note;
            pRow["ApprovedBy"] = res.ApprovedBy;
            pRow["ApprovedByPos"] = res.ApprovedByPos;
            pRow["PANote"] = res.ProvincialAdministrator?.Note;

            foreach (var i in customColumn)
            {
                pRow[i] = i;
            }

            payroll.Rows.Add(pRow);

            payrollDetails.Columns.AddRange(new[]
            {
                    new DataColumn("Total", typeof(decimal)) { },
                });
            foreach (var i in customColumn)
            {
                payrollDetails.Columns.Add(new DataColumn(i, typeof(decimal)) { AllowDBNull = true });
            }

            for (var i = 0; i <= res.PayrollDetails.Count() - 1; i++)
            {
                var row = payrollDetails.NewRow();
                row["Id"] = res.PayrollDetails.ToList()[i]?.Id;
                row["Name"] = res.PayrollDetails.ToList()[i]?.Employees?.EmployeeNameByLastName;
                row["ItemNumber"] = res.PayrollDetails.ToList()[i]?.ItemNumber;
                row["PayrollId"] = res.PayrollDetails.ToList()[i]?.PayrollId;
                row["Designation"] = res.PayrollDetails.ToList()[i]?.Designation;
                row["Total"] = res.PayrollDetails.ToList()[i]?.Total;

                for (var x = 0; x <= customColumn.Count() - 1; x++)
                {
                    var columnTitle = res.PayrollDetails.ToList()[i]?.ColumnTitle.Split(',')
                        .Select(c => new { columnTitle = c }).ToList();
                    row[customColumn[x]] =
                        columnTitle?.FirstOrDefault(c => c.columnTitle.Contains(customColumn[x]))?.columnTitle
                            ?.Split('=')[1]
                            ?.ToDecimal() ?? 0;
                }

                payrollDetails.Rows.Add(row);
            }
        }

        void AddPageTotalColumn(string[] customColumn, XRTableCell xrCell, rptOBRPayroll rpt)
        {

            foreach (var i in customColumn)
            {
                xrCell = new DevExpress.XtraReports.UI.XRTableCell()
                {
                    //  Text = payrollDetails.AsEnumerable().Sum(x => x.Field<decimal>(i)).ToString("Php #,##.#0"),
                    Name = "colPageTotal" + i,
                    WidthF = 150
                };
                CalculatePageTotalValue(xrCell, i);
                rpt.tblPageTotalRow.Cells.Add(xrCell);

            }


            var pageTotalCell = new DevExpress.XtraReports.UI.XRTableCell()
            {
                //  Text = ds.Tables["PayrollDetails"].AsEnumerable().Sum(x => x.Field<decimal>("Total")).ToString("Php #,##.#0"),
                Name = "pageTotal",
            };



            CalculatePageTotalValue(pageTotalCell, "Total");
            rpt.tblPageTotalRow.Cells.Add(pageTotalCell);
            rpt.tblPageTotalRow.Cells.Add(new XRTableCell());
            rpt.colPageTotal.WidthF = rpt.tblRowPayrollDetails.Cells[0].WidthF +
                                      rpt.tblRowPayrollDetails.Cells[1].WidthF +
                                      rpt.tblRowPayrollDetails.Cells[2].WidthF;
        }

        void AddGrandTotalColumn(string[] customColumn, XRTableCell xrCell, rptOBRPayroll rpt)
        {
            foreach (var i in customColumn)
            {
                xrCell = new DevExpress.XtraReports.UI.XRTableCell()
                {
                    Name = "colGrandTotal" + i,
                    WidthF = 150
                };
                xrCell.PrintOnPage += (s, e) =>
                {
                    var cell = s as XRTableCell;
                    cell.Visible = (e.PageCount - 1) == e.PageIndex;
                    cell.Text = oBRPayrollViewModels.Where(x => x.ColumnName == i).Sum(m => m.Value)
                        ?.ToString("n2");
                };
                rpt.tblGrandTotalRow.Cells.Add(xrCell);
                //Total


            }
            xrCell = new DevExpress.XtraReports.UI.XRTableCell()
            {
                //
                Name = "colGrandTotal",

            };
            xrCell.PrintOnPage += (s, e) =>
            {
                var cell = s as XRTableCell;
                cell.Visible = (e.PageCount - 1) == e.PageIndex;
                cell.Text = oBRPayrollViewModels.Where(x => x.ColumnName == "Total").Sum(m => m.Value)?.ToString("n2");
            };
            rpt.tblGrandTotalRow.Cells.Add(xrCell);
            xrCell = new XRTableCell()
            {
                Name = "colSigGrandTotal",

            };
            xrCell.PrintOnPage += (s, e) =>
            {
                var cell = s as XRTableCell;
                cell.Visible = (e.PageCount - 1) == e.PageIndex;

            };
            rpt.tblGrandTotalRow.Cells.Add(xrCell);
            rpt.colGrandTotalLabel.WidthF = rpt.colPageTotal.WidthF;
        }
        private void BtnPreview_Click(object sender, EventArgs e)
        {
            oBRPayrollViewModels = new List<OBRPayrollViewModel>();

            var res = new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId);
            var xrCell = new XRTableCell();
            var rpt = new rptOBRPayroll(res?.Obligations.ResponsibilityCenter + " - " + res?.ControlNo);
            if (res.Obligations.ORDetails.Any(x => x.Appropriations.AccountName.ToLower().Contains("casual")))
                rpt.xrLblPurpose.BackColor = Color.Pink;
            var customColumn = res?.ColumnTitle1?.Split(',');

            //Start TODO: adding Header columns
            if (customColumn != null)
            {

                //End TODO: adding Header columns
                AddColumnHeader(customColumn, rpt);
                //Start TODO: add row columns of payroll details
                AddColumnHeaderDetails(customColumn, rpt);
                //End TODO: add row columns of payroll details


                //TODO: Initialize DataSet and DataTable
                this.InitializePayrollDataset(res, customColumn);
                rpt.DataSource = ds;

                //TODO: ReRender column width
                for (var i = 0; i <= rpt.tblRowPayrollDetailHeader.Cells.Count - 1; i++)
                {
                    rpt.tblRowPayrollDetailHeader.Cells[i].WidthF = rpt.tblRowPayrollDetails.Cells[i].WidthF;
                }

                //rpt.tblPageTotal.WidthF = rpt.tblRowPayrollDetailHeader.WidthF - rpt.tblRowPayrollDetails.Cells["colSig"].WidthF;
                //TODO: RENDERING PAGE TOTAL
                this.AddPageTotalColumn(customColumn, xrCell, rpt);
                //TODO: RENDERING GRAND TOTAL
                AddGrandTotalColumn(customColumn, xrCell, rpt);
            }

            StaticSettings staticSettings = new StaticSettings();

            if (staticSettings.Offices.IsDivision != true)
            {
                foreach (XRControl control in rpt.AllControls<XRControl>().Where(x => x.Tag == "Division"))
                {
                    control.Visible = false;
                }
                rpt.grpDiv.Visible = false;
                rpt.grpDept.Visible = true;
            }
            else
            {
                rpt.grpDiv.Visible = true;
                rpt.grpDept.Visible = false;
            }

            //  rpt.CreateDocument();
            //xRTableCell.PrintOnPage -= printOnPageEventArgs;

            frmReportViewer frm =
                new frmReportViewer(rpt);

            frm.ShowDialog();
        }

        private void BtnDeletePayrollRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (uCPayrolls.PayrollGridView.GetFocusedRow() is Payrolls item)
            {

            }
        }


        private void BtnEditNew_Click(object sender, EventArgs e)
        {
            frmAddEditPayroll frm;
            if (payrolls == null)
                frm = new frmAddEditPayroll(MethodType.Add, obId);
            else
                frm = new frmAddEditPayroll(MethodType.Edit, obId);
            frm.ShowDialog();
            Init();

        }

        public async void Init()
        {

            payrolls = await Task.Run(() => new UnitOfWork().PayrollsRepo.Find(m => m.Id == obId));
            InitializeGridView(payrolls);
            if (payrolls == null)
            {
                btnEditNew.Text = "New Payroll";
                btnDelete.Enabled = false;
            }
            else
            {
                btnEditNew.Text = "Edit Payroll";
                btnDelete.Enabled = true;
            }
        }

        public void Detail(Payrolls item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }
        void InitializeGridView(Payrolls item)
        {
            if (item == null)
                return;
            DataTable dt = new DataTable();
            var customCol = item.ColumnTitle1?.Split(',');
            dt.Columns.AddRange(new[]
            {
                new DataColumn("Id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("ItemNumber", typeof(string)),
                new DataColumn("PayrollId", typeof(string)),
                new DataColumn("Designation", typeof(string)),
                new DataColumn("Total", typeof(decimal)){},
            });
            if (customCol != null)
            {
                foreach (var i in customCol)
                {
                    dt.Columns.Add(new DataColumn(i, typeof(decimal)) { AllowDBNull = true });
                }

                item.PayrollDetails = item.PayrollDetails.OrderBy(x => x.ItemNumber).ToList();
                for (var i = 0; i <= item.PayrollDetails.Count() - 1; i++)
                {
                    var row = dt.NewRow();
                    row["Id"] = item.PayrollDetails.ToList()[i]?.Id;
                    row["Name"] = item.PayrollDetails.ToList()[i]?.Name;
                    row["ItemNumber"] = item.PayrollDetails.ToList()[i]?.ItemNumber;
                    row["PayrollId"] = item.PayrollDetails.ToList()[i]?.PayrollId;
                    row["Designation"] = item.PayrollDetails.ToList()[i]?.Designation;
                    row["Total"] = item.PayrollDetails.ToList()[i]?.Total;

                    for (var x = 0; x <= customCol.Count() - 1; x++)
                    {
                        var columnTitle = item.PayrollDetails.ToList()[i]?.ColumnTitle.Split(',')
                            .Select(c => new { columnTitle = c }).ToList();
                        row[customCol[x]] =
                            columnTitle?.FirstOrDefault(c => c.columnTitle.Contains(customCol[x]))?.columnTitle
                                ?.Split('=')[1]?.ToDecimal() ?? 0.0M;
                    }

                    dt.Rows.Add(row);
                }

                uCPayrolls.PayrollGridView.Columns.Clear();
                uCPayrolls.PayrollGridView.Columns.AddRange(new[]
                {
                    new GridColumn()
                    {
                        Name = "Id", FieldName = "Id", Caption = "Id",
                        UnboundType = DevExpress.Data.UnboundColumnType.String, VisibleIndex = -1,

                    },

                    new GridColumn()
                    {
                        Name = "ItemNumber", FieldName = "ItemNumber", Caption = "Item No.",
                        UnboundType = DevExpress.Data.UnboundColumnType.String, VisibleIndex = 0
                    },
                    new GridColumn()
                    {
                        Name = "Name", FieldName = "Name", Caption = "Name",
                        UnboundType = DevExpress.Data.UnboundColumnType.String, VisibleIndex = 1
                    },
                    new GridColumn()
                    {
                        Name = "Designation", FieldName = "Designation", Caption = "Designation",
                        UnboundType = DevExpress.Data.UnboundColumnType.String, VisibleIndex = 2
                    },
                });
                var index = 3;
                var grid = new GridColumn();
                foreach (var i in customCol)
                {
                     grid = new GridColumn()
                    {
                        Name = i,
                        FieldName = i,
                        Caption = i,
                        UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
                        VisibleIndex = 3,


                    };
                    grid.DisplayFormat.FormatString = "n2";
                    grid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                    this.uCPayrolls.PayrollGridView.Columns.Add(grid);
                    index++;
                }

                grid = new GridColumn()
                {
                    Name = "Total",
                    FieldName = "Total",
                    Caption = "Total",
                    UnboundType = DevExpress.Data.UnboundColumnType.Decimal,
                    VisibleIndex = index
                };
                grid.DisplayFormat.FormatString = "n2";
                grid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
                this.uCPayrolls.PayrollGridView.Columns.Add(grid);
            }

            this.uCPayrolls.PayrollGridControl.DataSource = dt;
        }
    }
}
