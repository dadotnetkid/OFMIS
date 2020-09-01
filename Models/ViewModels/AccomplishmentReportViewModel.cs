using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Models.Repository;

namespace Models.ViewModels
{
    public class AccomplishmentReportViewModel
    {
        public IQueryable<DocumentActions> Generate()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var user = unitOfWork.UsersRepo.Find(x => x.Id == UserId);
            this.EmployeePosition = user.Position;
            this.EmployeeName = user.FullName;
            var doc = unitOfWork.DocumentActionsRepo.Fetch(x => x.CreatedBy == user.Id)
                .Where(x => x.ActionDate >= DateFrom && x.ActionDate <= DateTo);
            if (!string.IsNullOrEmpty(this.TableName))
            {
                doc = doc.Where(x => x.TableName == this.TableName);
            }

            AccomplishmentReports = new List<ExpandoObject>();
            //foreach (var i in doc.ToList().Where(x => x.MainActivityId != null).GroupBy(x => x.SubActivityId))
            //{
            //    var subActivity = i.Key;
            //    var action = doc.FirstOrDefault(x => x.SubActivityId == subActivity);
            //    AccomplishmentReports.Add(new AccomplishmentReport()
            //    {
            //        MainActivity = action?.MainActivity?.Value,
            //        SubActivity = action?.SubActivity?.Value,
            //        TotalCount = doc.Count(x => x.SubActivityId == subActivity)
            //    });
            //}
            var dtFrom = DateFrom;
            var dtTo = DateTo;
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("SubActivity", typeof(string));
            //var data = new ExpandoObject() as IDictionary<string, Object>;
            //data.Add("SubActivity", string.Empty);
            //while (dtFrom <= dtTo)
            //{
            //   // dataTable.Columns.Add(dtFrom.ToString("dd"), typeof(decimal));
            //    data.Add(dtFrom.ToString("dd"), string.Empty);

            //    dtFrom = dtFrom.AddDays(1);
            //}
            //   List< IDictionary<string, Object> > datas
            List<ExpandoObject> dict = new List<ExpandoObject>();
            foreach (var i in doc.ToList().Where(x => x.MainActivityId != null).GroupBy(x => x.SubActivityId))
            {
                dtFrom = DateFrom;
                dtTo = DateTo;
                //var drRow = dataTable.NewRow();
                var subActivity = i.Key;

                var action = doc.FirstOrDefault(x => x.SubActivityId == subActivity);
                //  drRow["SubActivity"] = action?.SubActivity?.Value;
                var docList = doc.ToList();
                var data = new ExpandoObject();
                ExpandoHelper.AddProperty(data, $"SubActivityId", action?.SubActivity?.Id);
                ExpandoHelper.AddProperty(data, $"SubActivity", action?.SubActivity?.Value);
                //      while (dtFrom <= dtTo)
                //      {
                //          var _from = dtFrom;
                //          var _to = dtFrom.AddHours(23).AddMinutes(59).AddSeconds(59);
                //          //drRow[$"{dtFrom:dd}"] = docList.Where(x => Convert.ToDateTime(x.ActionDate.Value.ToShortDateString()) >= _from && Convert.ToDateTime(x.ActionDate.Value.ToShortDateString()) <= _to).Count(x => x.SubActivityId == subActivity);
                //          ExpandoHelper.AddProperty(data, $"_{dtFrom:dd}",
                //              docList.Where(x =>
                //                      Convert.ToDateTime(x.ActionDate.Value.ToShortDateString()) >= _from &&
                //                      Convert.ToDateTime(x.ActionDate.Value.ToShortDateString()) <= _to)
                //                  .Count(x => x.SubActivityId == subActivity));
                //          //data.Add($"{dtFrom:dd}",
                //          //    docList.Where(x =>
                //          //            Convert.ToDateTime(x.ActionDate.Value.ToShortDateString()) >= _from &&
                //          //            Convert.ToDateTime(x.ActionDate.Value.ToShortDateString()) <= _to)
                //          //        .Count(x => x.SubActivityId == subActivity));
                //          dtFrom = dtFrom.AddDays(1);
                ////          data = new ExpandoObject();

                //      }

                dict.Add(data);
                // dataTable.Rows.Add(drRow);
            }
            //PropertyInfo pinfo = typeof(string).GetProperty("YourProperty");

            AccomplishmentReports = dict;
            return doc;
        }

        public string NotedBy { get; set; }
        public string NotedByPosition { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewedByPosition { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string PeriodOf { get; set; }
        public List<ExpandoObject> AccomplishmentReports { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public string UserId { get; set; }
        public string Office { get; set; }
        public string TelNo { get; set; }
        public string Address { get; set; }
        public string TableName { get; set; }
    }

    public class AccomplishmentReport
    {
        public string MainActivity { get; set; }
        public string SubActivity { get; set; }
        public int TotalCount { get; set; }
    }
}
