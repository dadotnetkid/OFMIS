using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Helpers
{
    public class IdHelper
    {
        public static string OfficeControlNo(string lastId)
        {
            var id = DateTime.Now.ToString("yyyy-MM-") + "0001";
            if (lastId == null)
                return id;
            if (lastId.Contains(DateTime.Now.ToString("yyyy-MM")))
            {
                var ids = lastId.Split(new string[] { DateTime.Now.ToString("yyyy-MM-") }, StringSplitOptions.RemoveEmptyEntries);
                id = DateTime.Now.ToString("yyyy-MM-") + (ids[0].ToInt() + 1).ToString("0000");
            }


            return id;
        }
        public static string OfficeControlNo(string lastId, int? officeId, string documentType, string tableName)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var office = unitOfWork.OfficesRepo.Find(x => x.Id == officeId);
            var id = $"{office?.OffcAcr}-{documentType }-" + DateTime.Now.ToString($"yyyy-MM-") + "0001";

            var controlNo = unitOfWork.ControlNumbersRepo.Fetch(x => x.OfficeId == officeId && x.TableName == tableName)
                .OrderByDescending(x => x.Id).FirstOrDefault();
            if (controlNo == null)
            {
                InsertOfficeControlNumber(id, officeId, tableName);
                return id;
            }

            if (lastId == null)
            {
                InsertOfficeControlNumber(id, officeId, tableName);
                return id;
            }

            if (lastId.Contains(DateTime.Now.ToString($"yyyy-MM-")))
            {
                var ids = lastId.Split(new string[] { DateTime.Now.ToString($"yyyy-MM-") }, StringSplitOptions.RemoveEmptyEntries);
                var res = DateTime.Now.ToString($"yyyy-MM-");

                if (ids[0].Contains($"{office?.OffcAcr}-{documentType}"))
                {
                    id = $"{office?.OffcAcr}-{documentType }-"+DateTime.Now.ToString($"yyyy-MM-") + (ids[1].ToInt() + 1).ToString("0000");
                }
                else
                {
                    id = $"{office?.OffcAcr}-{documentType }-" + DateTime.Now.ToString($"yyyy-MM-") + (ids[0].ToInt() + 1).ToString("0000");
                }
            }

            InsertOfficeControlNumber(id, officeId, tableName);
            return id;
        }

        public static string ReplaceOldControlNo(int? officeId, string documentType, string controlNo)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var office = unitOfWork.OfficesRepo.Find(x => x.Id == officeId);
            if (!controlNo.Contains($"{office?.OffcAcr}-{documentType}"))
            {
                controlNo = $"{office?.OffcAcr}-{documentType}-" + controlNo;
            }
            return controlNo;
        }
        public static string OfficeControlNo(string lastId, int? officeId)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var id = DateTime.Now.ToString("yyyy-MM-") + "0001";


            if (lastId == null)
            {
                return id;
            }

            if (lastId.Contains(DateTime.Now.ToString("yyyy-MM")))
            {
                var ids = lastId.Split(new string[] { DateTime.Now.ToString("yyyy-MM-") }, StringSplitOptions.RemoveEmptyEntries);
                id = DateTime.Now.ToString("yyyy-MM-") + (ids[0].ToInt() + 1).ToString("0000");
            }

            return id;
        }
        static void InsertOfficeControlNumber(string lastId, int? officeId, string tableName)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            if (unitOfWork.ControlNumbersRepo.Fetch(x => x.ControlNo == lastId && x.OfficeId == officeId && x.TableName == tableName).Any())
                return;
            unitOfWork.ControlNumbersRepo.Insert(new Models.ControlNumbers()
            {
                ControlNo = lastId,
                OfficeId = officeId,
                TableName = tableName
            });
            unitOfWork.Save();

        }
    }
}
