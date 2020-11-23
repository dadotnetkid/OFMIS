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

namespace Win.AOQ
{
    public partial class frmAddFromPQ : DevExpress.XtraEditors.XtraForm, ITransactions<PurchaseRequests>
    {
        private Models.AOQ abstractofQuotation;

        public frmAddFromPQ(Models.AOQ abstractofQuotation)
        {
            InitializeComponent();
            this.abstractofQuotation = abstractofQuotation;
            Init();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Save();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                if (unitOfWork.AOQDetailsRepo.Fetch(x => x.AOQId == abstractofQuotation.Id).Any())
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
                        unitOfWork.AOQDetailsRepo.Insert(new AOQDetails()
                        {
                            Category = i.Category,
                            Cost = i.Cost ?? 0,
                            Item = i.Item,
                            ItemNo = i.ItemNo ?? itemNo,
                            AOQId = abstractofQuotation.Id,
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
                    new BindingList<PriceQuotations>(abstractofQuotation?.PurchaseRequests?.PriceQuotations?.ToList());
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
    }
}