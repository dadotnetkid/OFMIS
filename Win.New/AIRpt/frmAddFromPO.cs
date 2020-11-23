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

namespace Win.AIRpt
{
    public partial class frmAddFromPO : DevExpress.XtraEditors.XtraForm
    {
        private AIReports item;

        public frmAddFromPO(AIReports item)
        {
            InitializeComponent();
            this.item = item;
            Init();
        }

        private void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.cboPO.Properties.DataSource = unitOfWork.PurchaseOrdersRepo.Get(x => x.PRId == item.PRId);
            }
            catch (Exception e)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (cboPO.GetSelectedDataRow() is PurchaseOrders order)
                {
                    foreach (var i in order.PODetails)
                    {
                        unitOfWork.AIRDetailsRepo.Insert(new AIRDetails()
                        {
                            AIReportId = item.Id,
                            Item = i.Item,
                            ItemNo = i.ItemNo,
                            Quantity = i.Quantity,
                            TotalAmount = i.TotalAmount,
                            UOM = i.UOM,
                            Category = i.Category,
                            Cost = i.Cost,


                        });
                    }

                    unitOfWork.Save();
                    this.Close();
                }

            }
            catch (Exception exception)
            {

            }
        }
    }
}