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
using Win.Actns;

namespace DMS
{
    public partial class frmDocActionChild : frmDocActions
    {
        
       
        public override void Init()
        {
            base.Init();
        }

        public frmDocActionChild(MethodType methodType, DocumentActions documentActions) : base(methodType, documentActions)
        {
        }
    }
}