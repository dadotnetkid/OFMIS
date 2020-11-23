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
using Helpers;
using Models;
using Models.Repository;
using Win.BL;

namespace Win.Actns
{
    public partial class FrmAddEditPrograms : DevExpress.XtraEditors.XtraForm, ITransactions<Actions>
    {
        private Actions item;
        private bool isClosed;

        public FrmAddEditPrograms(MethodType methodType, Actions item)
        {
            InitializeComponent();
            this.item = item;
            this.methodType = methodType;
            Init();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            Save();
        }



        private void btnEditPo_Click(object sender, EventArgs e)
        {
            Close();
        }

        public MethodType methodType { get; set; }
        public void Save()
        {
            try
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.ActionsRepo.Find(x => x.Id == item.Id);
                item.Value = txtValue.Text;
                item.ItemOrder = txtOrder.EditValue?.ToInt();
                unitOfWork.Save();
                isClosed = true;
                Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Detail()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item = unitOfWork.ActionsRepo.Find(x => x.Id == item.Id);
                this.txtOrder.EditValue = item.ItemOrder;
                this.txtValue.Text = item.Value;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Init()
        {
            try
            {
                if (methodType == MethodType.Edit)
                {
                    Detail();
                    return;
                }
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ActionsRepo.Insert(item);
                unitOfWork.Save();
                Detail();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Close(FormClosingEventArgs eventArgs)
        {
            if (methodType == MethodType.Edit || this.isClosed)
                return;
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                unitOfWork.ActionsRepo.Delete(x => x.Id == item.Id);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddEditPrograms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close(e);
        }
    }
}