using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Win.Rprts
{
    public partial class rptItenerary : DevExpress.XtraReports.UI.XtraReport
    {
        private float height;

        public rptItenerary()
        {
            InitializeComponent();

        }

        private void xrTblITR_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //while (this.isHeight)
            //{
            //    CreateEmptyRow();
            //}

            //            this.height = xrTblITR.HeightF;
        }

        void CreateEmptyRow()
        {
            if (height < 200)
            {
                var row = new XRTableRow()
                {
                    HeightF = 25f
                };
                row.Cells.AddRange(new XRTableCell[]
                {
                    new XRTableCell()
                    {
                        WidthF=90.65f,
                        HeightF=25f
                    },
                    new XRTableCell()
                    {
                        WidthF=106.18f
                    },
                    new XRTableCell()
                    {
                        WidthF=103.9f
                    },
                    new XRTableCell()
                    {
                        WidthF=103.9f
                    },
                    new XRTableCell()
                    {
                        WidthF=103.9f
                    },
                    new XRTableCell()
                    {
                        WidthF=103.9f
                    },
                    new XRTableCell()
                    {
                        WidthF=54.35f
                    },
                    new XRTableCell()
                    {
                        WidthF=73.55f
                    },
                    new XRTableCell()
                    {
                        WidthF=59.67f
                    },
                });
                xrTblITR.Rows.Add(row);
                height += 25;
                this.xrTblITR.HeightF = height;
                this.ITRDetails.HeightF = height;
                CreateEmptyRow();
            }
        }

        private void xrITR_AfterPrint(object sender, EventArgs e)
        {
            /*this.height = xrTblITR.HeightF;
            CreateEmptyRow();*/


        }

        private void ITRDetails_AfterPrint(object sender, EventArgs e)
        {

            // CreateEmptyRow();
        }

      
    }
}
