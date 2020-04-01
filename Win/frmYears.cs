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
    public partial class frmYears : DevExpress.XtraEditors.XtraForm
    {
        public frmYears()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            this.YearGridControl.DataSource = new BindingList<Years>(new UnitOfWork().YearsRepo.Get().ToList());
        }

        private void YearGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                foreach (var i in unitOfWork.YearsRepo.Get())
                {
                    i.IsActive = false;
                    unitOfWork.Save();
                }
                unitOfWork = new UnitOfWork();
                if (e.Row is Years item)
                {
                    if (item.Id == 0)
                        unitOfWork.YearsRepo.Insert(item);
                    else
                        unitOfWork.YearsRepo.Update(item);
                    unitOfWork.Save();
                    this.YearGridControl.DataSource = new BindingList<Years>(new UnitOfWork().YearsRepo.Get().ToList());
                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmYears_Load(object sender, EventArgs e)
        {

        }

        private void frmYears_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!new UnitOfWork().YearsRepo.Fetch().Any(x => x.IsActive == true))
            {
                e.Cancel = true;
                MessageBox.Show("You need to add Default Year", "Year", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}