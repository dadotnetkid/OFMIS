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

namespace Win.Test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new ModelDb());
                var res = unitOfWork.DocumentActionsRepo.Get(x => x.ControlNo == null || x.ControlNo == "");
                foreach (var i in res)
                {
                    var controlNumber = "";

                    if (i.TableName == "PurchaseRequests")
                    {
                        controlNumber = unitOfWork.PurchaseRequestsRepo.Find(x => x.Id == i.RefId)?.ControlNo;
                    }

                    if (i.TableName == "Obligations")
                    {
                        controlNumber = unitOfWork.ObligationsRepo.Find(x => x.Id == i.RefId)?.ControlNo;
                    }

                    if (!string.IsNullOrEmpty(controlNumber))
                    {
                        i.ControlNo = controlNumber;
                    }

                    this.lstStatus.Items.Add($"{i.TableName} : {i.RefId} : updated control no: {i.ControlNo}");
                }

                unitOfWork.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}