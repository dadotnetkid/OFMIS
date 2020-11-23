using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using Helpers;
using Models;
using Models.Repository;
using Win.BL;
using Win.Rprts;

namespace Win.AOQ
{
    public partial class UCAOQ : DevExpress.XtraEditors.XtraUserControl, ILoad<Models.AOQ>
    {
        private PurchaseRequests purchaseRequests;

        public UCAOQ(PurchaseRequests purchaseRequests)
        {
            InitializeComponent();
            this.purchaseRequests = purchaseRequests;
            Init();
            btnDeletePQRepo.ButtonClick += BtnDeletePQRepo_ButtonClick;
            btnEditPQRepo.ButtonClick += BtnEditPQRepo_ButtonClick;
        }

        private void BtnEditPQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (AOQGridView.GetFocusedRow() is Models.AOQ item)
                {
                    frmAddEditAOQ frm = new frmAddEditAOQ(item, MethodType.Edit);
                    frm.ShowDialog();
                    Init();
                }

            }
            catch (Exception exception)
            {

            }
        }

        private void BtnDeletePQRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (!User.UserInAction("can delete"))
                    return;
                if (AOQGridView.GetFocusedRow() is Models.AOQ item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork(false, false);
                    TrashbinHelper trashbinHelper = new TrashbinHelper();
                    item = unitOfWork.AOQRepo.Find(x => x.Id == item.Id, false, includeProperties: "AOQDetails,BacMembers");
                    trashbinHelper.Delete(item, "AOQ", item.Description, User.UserId, new StaticSettings().OfficeId);
                    unitOfWork.AOQRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }

            }
            catch (Exception exception)
            {

            }
        }

        public void Init()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.AOQGridControl.DataSource = unitOfWork.AOQRepo.Get(x => x.PRId == purchaseRequests.Id);
            }
            catch (Exception e)
            {

            }
        }

        public void Detail(Models.AOQ item)
        {
            throw new NotImplementedException();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddEditAOQ frm = new frmAddEditAOQ(new Models.AOQ()
                {
                    PRId = purchaseRequests.Id,
                    Description = purchaseRequests.Description,
                    ABC = purchaseRequests.TotalAmount
                }, MethodType.Add);
                frm.ShowDialog();
                Init();
            }
            catch (Exception exception)
            {

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (AOQGridView.GetFocusedRow() is Models.AOQ item)
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.AOQRepo.Find(x => x.Id == item.Id);
                item.AOQDetails = item.AOQDetails.OrderBy(x => x.Id).ThenByDescending(x=>x.ItemNo).ToList();
                foreach (var i in item.AOQDetails.OrderBy(x=>x.ItemNo))
                {
                    var rtf = new RichEditControl();
                    //rtf.Font = new Font("Calibri", 9.5f);
                    rtf.RtfText = i.Item;
                    if (string.IsNullOrEmpty(rtf.RtfText))
                    {
                        RichEditDocumentServer server = new RichEditDocumentServer();
                        server.Text = i.Item;
                        i.Item = server.RtfText;
                    }
                }

                unitOfWork.Save();

                var rpt = new rptAOQ()
                {
                    DataSource = new List<Models.AOQ>() { item }
                };
                if (item.BacMembers.Any())
                {
                    rpt.lblbac1.Text = item.BacMembers.ToList()[0]?.Person;
                    rpt.lblBacPos1.Text = item.BacMembers.ToList()[0]?.Position;
                    rpt.pos1.Text = item.BacMembers.ToList()[0]?.BacPosition;
                }

                if (item.BacMembers.Count() > 1)
                {
                    rpt.lblbac2.Text = item.BacMembers.ToList()[1]?.Person;
                    rpt.lblbacpos2.Text = item.BacMembers.ToList()[1]?.Position;
                    rpt.pos2.Text = item.BacMembers.ToList()[1]?.BacPosition;
                }

                if (item.BacMembers.Count() > 2)
                {
                    rpt.lblbac3.Text = item.BacMembers.ToList()[2]?.Person;
                    rpt.lblbacpos3.Text = item.BacMembers.ToList()[2]?.Position;
                    rpt.pos3.Text = item.BacMembers.ToList()[2]?.BacPosition;
                }
                if (item.BacMembers.Count() > 3)
                {
                    rpt.lblbac4.Text = item.BacMembers.ToList()[3]?.Person;
                    rpt.lblbacpos4.Text = item.BacMembers.ToList()[3]?.Position;
                    rpt.pos4.Text = item.BacMembers.ToList()[3]?.BacPosition;
                }
                //if (item.BacMembers.Count() > 4)
                //{rpt.lblbac5.Text = item.BacMembers.ToList()[4]?.Person;
                //    rpt.lblbacpos5.Text = item.BacMembers.ToList()[4]?.Position;
                //    rpt.pos5.Text = item.BacMembers.ToList()[4]?.BacPosition;
                //}

                var twg = new UnitOfWork().Signatories.Find(x => x.BacPosition.Contains("TWG-Goods"));
                rpt.lblTWG.Text = twg.Person;
                rpt.lblTWGPos.Text = twg.Position;
                rpt.lblBACTWGPos.Text = twg.BacPosition;


                frmReportViewer frm = new frmReportViewer(rpt);
                frm.ShowDialog();
            }
        }
    }
}
