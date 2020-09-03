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
using System.Data.Entity;
using Helpers;

namespace Win.Actns
{
    public partial class frmAddEditDocActionTree : DevExpress.XtraEditors.XtraForm
    {
        private string category;
        private Models.Actions item;
        private MethodType methodType;
        private StaticSettings staticSettings = new StaticSettings();
        public frmAddEditDocActionTree(string category, Models.Actions item, MethodType methodType)
        {
            InitializeComponent();
            this.category = category;
            this.item = item;
            this.methodType = methodType;


            txtParent.Properties.DataSource = new BindingList<Models.Actions>(new UnitOfWork().ActionsRepo.Get());
            detail();
            addNewInit();
        }

        void detail()
        {
            if (methodType == MethodType.Add)
                return;

            if (item.Category == "Programs")
            {

            }
            else if (item.Category == "Projects")
            {

                txtParent.Properties.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get(m => m.Category == "Programs"));
            }
            else if (item.Category == "Activity")
            {
                lblParent.Text = "Activity";
                lblvalue.Text = "Activity";
                txtParent.Properties.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get(m => m.Category == "Activity"));
            }
            else if (item.Category == "SubActivity")
            {
                lblParent.Text = "Activity";
                lblvalue.Text = "Sub Activity";
                txtParent.Properties.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get(m => m.Category == "Activity"));
            }


            txtValue.Text = item.Value;
            txtParent.EditValue = new UnitOfWork().ActionsRepo.Find(m => m.Id == item.ParentId)?.Id;
            txtOrder.Text = item.ItemOrder?.ToString();
            var parentId = item.ParentId;
            while (true)
            {
                if (item.ParentId == null)
                {
                    lblHeader.Text = item.Value;
                    break;
                }
                var dropdown = new UnitOfWork().ActionsRepo.Find(x => x.Id == parentId);

                if (dropdown == null)
                {

                    break;
                }
                lblHeader.Text = dropdown.Value;
                parentId = dropdown.ParentId;

            }
        }

        void addNewInit()
        {
            if (methodType == MethodType.Edit)
                return;

            if (item.Category == "Programs")
            {
                txtParent.Properties.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get(m => m.Category == "Programs"));
            }
            else if (item.Category == "Projects")
            {
                txtParent.Properties.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get(m => m.Category == "Projects"));
            }
            else if (item.Category == "Activity")
            {
                lblParent.Text = "Activity";
                lblvalue.Text = "Sub Activity";
            }
            txtParent.EditValue = item.Id;
            var parentId = item.ParentId;
            while (true)
            {
                if (item.ParentId == null)
                {
                    lblHeader.Text = item.Value;
                    break;
                }
                var dropdown = new UnitOfWork().ActionsRepo.Find(x => x.Id == parentId);

                if (dropdown == null)
                {

                    break;
                }
                lblHeader.Text = dropdown.Value;
                parentId = dropdown.ParentId;

            }
        }

        void Edit()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var res = unitOfWork.ActionsRepo.Find(x => x.Id == item.Id);
            res.Value = txtValue.Text;
            res.ItemOrder = txtOrder.EditValue?.ToInt();
            res.ParentId = txtParent.EditValue?.ToInt();
            res.Category = category;
            unitOfWork.ActionsRepo.Update(item);
            unitOfWork.Save();
        }

        void add()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                item = new Actions();
                item.Value = txtValue.Text;
                item.ItemOrder = txtOrder.EditValue?.ToInt();
                item.ParentId = txtParent.EditValue?.ToInt();
                item.Category = category;
                unitOfWork.ActionsRepo.Insert(item);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
            }
        }

        private void frmAddEditDocActionTree_Load(object sender, EventArgs e)
        {

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
            {
                add();
            }
            else if (methodType == MethodType.Edit)
            {
                Edit();
            }

            this.Close();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}