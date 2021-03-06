﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DMS.Properties;
using Helpers;
using Models;
using Models.Repository;

namespace DMS
{
    public partial class frmSplashScreen : SplashScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.labelControl1.Text = "PITD Copyright © 1998-" + DateTime.Now.Year.ToString();

            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += bg_DoWork;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.RunWorkerAsync();
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                DataSource.ConnectionString = Settings.Default.ConnectionString;
                Console.Write(new UnitOfWork(new DTSDb()).DocumentTypesRepo.Fetch().Count());
                Console.Write(new UnitOfWork().UsersRepo.Fetch().Count());
                MachineTime.UpdateTime();
            }
            catch (Exception exception)
            {
                Invoke(new Action(() => { ConnectionDialog.ShowDialog(); }));
            }
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}