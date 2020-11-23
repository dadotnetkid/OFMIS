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
    public partial class frmSelectedItem : DevExpress.XtraEditors.XtraForm, ITransactions<Models.AOQ>
    {
        private frmAddEditPO frm;
        private PurchaseRequests pr;
        private PurchaseOrders po;
        private List<AOQDetails> aoqDetails;

        public frmSelectedItem(PurchaseRequests pr, PurchaseOrders po, frmAddEditPO frm)
        {
            InitializeComponent();
            this.frm = frm;
            this.pr = pr;
            this.po = po;
            this.btnSelectItemRepo.ButtonClick += BtnSelectItemRepo_ButtonClick;
            Init();
        }

        private void BtnSelectItemRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (ItemsGridView.GetFocusedRow() is AOQDetails item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    po = unitOfWork.PurchaseOrdersRepo.Find(x => x.Id == po.Id);
                    po.PODetails.Add(new PODetails()
                    {
                        Item = item.Item,
                        POId = po.Id,
                        ItemNo = item.ItemNo ?? 0,
                        Category = item.Category ?? "",
                        Cost = item.Cost ?? 0,
                        Quantity = item.Quantity ?? 0,
                        TotalAmount = item.TotalAmount ?? 0,
                        UOM = item.UOM
                    });
                    unitOfWork.Save();
                    this.ItemsGridView.DeleteRow(ItemsGridView.FocusedRowHandle);
                    frm.ItemsGridControl.DataSource = new BindingList<PODetails>(unitOfWork.PODetailsRepo.Get(x => x.POId == po.Id));
                }
                // Init();
            }
            catch (Exception exception)
            {

            }
        }

        private void frmSelectedItem_Load(object sender, EventArgs e)
        {

        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Detail()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var aoq = unitOfWork.AOQRepo.Find(x => x.PRId == pr.Id);
                po = unitOfWork.PurchaseOrdersRepo.Find(x => x.Id == po.Id);
                var pos = po.PODetails.Select(x => x.ItemNo);

                this.aoqDetails = aoq.AOQDetails.Where(x => pos.All(m => m != x.ItemNo)).ToList();
                this.ItemsGridControl.DataSource = new BindingList<AOQDetails>(aoqDetails);
                //
            }
            catch (Exception e)
            {
            }
        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            throw new NotImplementedException();
        }
    }
}