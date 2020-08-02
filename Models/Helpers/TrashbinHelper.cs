using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Models.Repository;
using Newtonsoft.Json;

namespace Helpers
{
    public class TrashbinHelper
    {
        public void Delete(object json, string tableName,string description,string deletedBy,int officeId)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = JsonConvert.SerializeObject(json, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                });
                var trashbin = new TrashBin()
                {
                    OldValues = res,
                    TableName = tableName,
                    DeletedBy=deletedBy,
                    Description=description,
                    OfficeId=officeId,
                };

                unitOfWork.TrashBinRepo.Insert(trashbin);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
