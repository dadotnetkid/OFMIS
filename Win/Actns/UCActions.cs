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
using DevExpress.XtraTreeList.Nodes;
using Models;
using Models.Repository;

namespace Win.Actns
{
    public partial class UCActions : DevExpress.XtraEditors.XtraUserControl
    {
        private string category;

        public UCActions()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            dropdownsBindingSource.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get());
            treeActionList.ExpandAll();
            foreach (TreeListNode node in treeActionList.Nodes)
            {
                // The left image displayed when the node is NOT focused.
                node.ImageIndex = 0;
                // The left image displayed when the node is focused.
                node.SelectImageIndex = 1;
                // The right image that does not depend on the focus.
                node.StateImageIndex = 2;
            }
        }

        private void treeActionList_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (treeActionList.GetFocusedRow() is Actions item)
            {
                this.btnAdd.Enabled = true;
                if (item.Category == "Programs")
                {
                    btnEdit.Text = @"Edit Program";
                    btnAdd.Text = @"Add New Project";
                    this.category = "Program";
                }
                else if (item.Category == "Projects")
                {
                    btnEdit.Text = @"Edit Project";
                    btnAdd.Text = @"Add New Activity";
                    this.category = "Project";
                }
                else if (item.Category == "Activity")
                {
                    btnEdit.Text = @"Edit Activity";
                    btnAdd.Text = @"Add New Sub Activity";
                    this.category = "Activity";
                }
                else if (item.Category == "SubActivity")
                {
                    btnEdit.Text = @"Edit Sub Activity";
                    this.category = "Sub Activity";
                    this.btnAdd.Enabled = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (treeActionList.GetFocusedRow() is Actions item)
            {
                if (category == "Program")
                {
                    FrmAddEditPrograms frmAddEditPrograms = new FrmAddEditPrograms(MethodType.Edit, item);
                    frmAddEditPrograms.ShowDialog();
                    dropdownsBindingSource.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get());
                    return;
                }
                frmAddEditDocActionTree frm = new frmAddEditDocActionTree(category, item, MethodType.Edit);
                frm.ShowDialog();
    
                treeActionList.ExpandAll();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (treeActionList.GetFocusedRow() is Actions item)
            {
                frmAddEditDocActionTree frm = new frmAddEditDocActionTree(category, item, MethodType.Add);
                frm.ShowDialog();
                dropdownsBindingSource.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (treeActionList.GetFocusedRow() is Actions item)
            {
                var unitOfWork = new UnitOfWork();
                unitOfWork.ActionsRepo.Delete(m => m.Id == item.Id);
                unitOfWork.Save();

            }
            dropdownsBindingSource.DataSource = new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get());
        }

        private void btnNewProgram_Click(object sender, EventArgs e)
        {
            FrmAddEditPrograms frm = new FrmAddEditPrograms(MethodType.Add, new Actions());
            frm.ShowDialog(); 
            treeActionList.DataSource= new BindingList<Actions>(new UnitOfWork().ActionsRepo.Get());
        }
    }
}
