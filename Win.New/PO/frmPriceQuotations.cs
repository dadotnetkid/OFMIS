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
using Win.BL;

namespace Win.PO
{
    public partial class frmPriceQuotations : DevExpress.XtraEditors.XtraForm, ITransactions<PurchaseRequests>
    {
        private PurchaseRequests purchaseRequests;
        private int pOId;

        public frmPriceQuotations(PurchaseRequests purchaseRequests, int pOId)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            this.pOId = pOId;
            Init();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (unitOfWork.PODetailsRepo.Fetch(x => x.POId == pOId).Any())
                {

                    if (MessageBox.Show("Purchase Detail has already item do you want to add this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                if (cboPQ.GetSelectedDataRow() is PriceQuotations item)
                {
                    var itemNo = 1;
                    foreach (var i in item.PQDetails)
                    {
                        unitOfWork.PODetailsRepo.Insert(new PODetails()
                        {
                            Category = i.Category,
                            Cost = i.Cost ?? 0,
                            Item = i.Item,
                            ItemNo = i.ItemNo ?? itemNo,
                            POId = pOId,
                            Quantity = i.Quantity ?? 1,
                            UOM = i.UOM,
                            TotalAmount = (i.Cost ?? 0) * 1
                        });
                        itemNo++;

                    }
                    unitOfWork.Save();
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Detail()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            try
            {

                cboPQ.Properties.DataSource =
                    new BindingList<PriceQuotations>(purchaseRequests.PriceQuotations.ToList());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}