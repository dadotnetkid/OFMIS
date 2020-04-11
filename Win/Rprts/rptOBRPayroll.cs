using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using DevExpress.XtraReports.UI;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;

namespace Win.Rprts
{
    public partial class rptOBRPayroll : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOBRPayroll(string controlId)
        {
            InitializeComponent();
            this.controlId = controlId;
        }

        private List<OBRPayrollViewModel> oBRPayrolls = new List<OBRPayrollViewModel>();
        private int pageCount = 0;
        private string controlId;

        private void xrTableRow2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var columnTitle1 = sender as XRTableCell;
            oBRPayrolls.Add(new OBRPayrollViewModel()
            {
                PageIndex = e.PageIndex,
                ColumnTitle2 = columnTitle1?.Value?.ToDecimal(),

            });
        }

        private void colTotalTitle1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            pageCount = this.Pages.Count();
            var sum = oBRPayrolls.Where(x => x.PageIndex == e.PageIndex).Sum(x => x.ColumnTitle1);
            colTotalTitle1.Text = sum?.ToString("PHP #,##.#0");
        }

        private void xrTable2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {


        }

        private void colColumnTitle1_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var columnTitle1 = sender as XRTableCell;


            oBRPayrolls.Add(new OBRPayrollViewModel()
            {
                PageIndex = e.PageIndex,
                ColumnTitle1 = columnTitle1?.Text?.ToDecimal(),

            });
            columnTitle1.Text = columnTitle1?.Text?.ToDecimal().ToString("PHP #,##.#0");
        }
        private void xrTableCell12_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var columnTitle2 = sender as XRTableCell;

            oBRPayrolls.Add(new OBRPayrollViewModel()
            {
                PageIndex = e.PageIndex,
                ColumnTitle2 = columnTitle2?.Text?.ToDecimal(),

            });
            columnTitle2.Text = columnTitle2?.Text?.ToDecimal().ToString("PHP #,##.#0");
        }

        private void xrTableCell13_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var total = sender as XRTableCell;


            oBRPayrolls.Add(new OBRPayrollViewModel()
            {
                PageIndex = e.PageIndex,
                Total = total?.Text?.ToDecimal(),
            });
            total.Text = total?.Text?.ToDecimal().ToString("PHP #,##.#0");
        }
        private void rptOBRPayroll_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            StaticSettings staticSettings = new StaticSettings();
            var accountant = staticSettings.chiefOfOffice.FirstOrDefault(x => x.Office == "Provincial Accountant Office");
            var treasurer = staticSettings.chiefOfOffice.FirstOrDefault(x => x.Office == "Provincial Treasurer Office");
            var provincialAdministrator = staticSettings.chiefOfOffice.FirstOrDefault(x => x.Office == "Provincial Administration Office");
            lblAccountant.Text = accountant?.Person;
            lblAccountantPOS.Text = accountant?.Position;
            lblPT.Text = treasurer?.Person;
            lblPTPOS.Text = treasurer?.Position;
            lblPA.Text = provincialAdministrator?.Person;
            lblPAPOS.Text = provincialAdministrator?.Position;
            lblHeadDivision.Text = staticSettings.Head;
            lblHeadDivisionPos.Text = staticSettings.HeadPos;
            lblControlId.Text = controlId;

        }

        private void colTotalTitle2_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var sum = oBRPayrolls.Where(x => x.PageIndex == e.PageIndex).Sum(x => x.ColumnTitle2);
            colTotalTitle2.Text = sum?.ToString("PHP #,##.#0");
        }



        private void colTotal_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var sum = oBRPayrolls.Where(x => x.PageIndex == e.PageIndex).Sum(x => x.Total);
            colTotal.Text = sum?.ToString("PHP #,##.#0");
        }

        private void colGrandTotal_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            if (sender is XRTableCell cell)
            {
                cell.Visible = e.PageIndex == (Pages.Count() - 1) ? true : false;
                colGrandTotalTitle1.Text = oBRPayrolls.Sum(x => x.ColumnTitle1)?.ToString("PHP #,##.#0");
                colGrandTotalTitle2.Text = oBRPayrolls.Sum(x => x.ColumnTitle2)?.ToString("PHP #,##.#0");
                colGrandTotal.Text = oBRPayrolls.Sum(x => x.Total)?.ToString("PHP #,##.#0");
                //if (cell.Name == "colGrandTotalLabel")
                //    cell.Visible = e.PageCount == Pages.Count() ? true : false;
            }
        }

        private void xrTableCell12_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
