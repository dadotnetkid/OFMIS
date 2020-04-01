﻿using System;
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

namespace Win
{
    public partial class frmSignatories : DevExpress.XtraEditors.XtraForm
    {
        public frmSignatories()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = new BindingList<Signatories>(new UnitOfWork().SignatoriesRepo.Get());
        }

        private void btnDeleteSignatory_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                if (SignatoriesGridView.GetFocusedRow() is Signatories item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.SignatoriesRepo.Delete(item);
                    unitOfWork.Save();
                    gridControl1.DataSource = new BindingList<Signatories>(new UnitOfWork().SignatoriesRepo.Get());
                }
            
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SignatoriesGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is Signatories item)
            {

                if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                
                UnitOfWork unitOfWork = new UnitOfWork();
                if (item.Id == 0)
                {
                    unitOfWork.SignatoriesRepo.Insert(item);
                }
                else
                {
                    unitOfWork.SignatoriesRepo.Update(item);
                }

                unitOfWork.Save();
                gridControl1.DataSource = new BindingList<Signatories>(new UnitOfWork().SignatoriesRepo.Get());
            }
        }
    }
}