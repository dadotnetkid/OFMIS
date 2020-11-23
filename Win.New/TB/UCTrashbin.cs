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
using Models.Repository;
using Models;
using Newtonsoft.Json;

namespace Win.TB
{
    public partial class UCTrashbin : DevExpress.XtraEditors.XtraUserControl
    {
        public UCTrashbin()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            StaticSettings staticSettings = new StaticSettings();
            UnitOfWork unitOfWork = new UnitOfWork();
            this.trashBinBindingSource.DataSource =
                unitOfWork.TrashBinRepo.Get(x => x.OfficeId == staticSettings.OfficeId);
        }

        private void btnRestoreRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (TrashGridView.GetFocusedRow() is TrashBin item)
            {
                //        Type hai = Type.GetType(item.TableName, true);
                // 
                ///var s = (hai) res;
                if (item.TableName == "PayrollDifferentials")
                    PayrollDifferentials(item.OldValues);
                if (item.TableName == "PayrollWages")
                    PayrollWages(item.OldValues);
                if (item.TableName == "AOQ")
                    rAOQ(item.OldValues);
                if (item.TableName == "AIReports")
                    AIReports(item.OldValues);
            }

        }

        void PayrollDifferentials(string json)
        {
            var res = JsonConvert.DeserializeObject<PayrollDifferentials>(json);
            res.Id = 0;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.PayrollDifferentialsRepo.Insert(res);
            unitOfWork.Save();
        }
        void PayrollWages(string json)
        {
            var res = JsonConvert.DeserializeObject<PayrollWages>(json);
            res.Id = 0;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.PayrollWagesRepo.Insert(res);
            unitOfWork.Save();
        }
        void AIReports(string json)
        {
            var res = JsonConvert.DeserializeObject<AIReports>(json);
            res.Id = 0;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.AIReportsRepo.Insert(res);
            unitOfWork.Save();
        }
        void rAOQ(string json)
        {
            var res = JsonConvert.DeserializeObject<Models.AOQ>(json);
            res.Id = 0;
            UnitOfWork unitOfWork = new UnitOfWork();
            unitOfWork.AOQRepo.Insert(res);
            unitOfWork.Save();
        }
    }
}
