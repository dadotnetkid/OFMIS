using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class AccomplishmentReportViewModel
    {
        public void Generate()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var user = unitOfWork.UsersRepo.Find(x => x.Id == UserId);
            this.EmployeePosition = user.Position;
            this.EmployeeName = user.FullName;
            var doc = unitOfWork.DocumentActionsRepo.Fetch(x => x.CreatedBy == user.Id)
                .Where(x => x.ActionDate >= DateFrom && x.ActionDate <= DateTo).ToList();

            AccomplishmentReports = new List<AccomplishmentReport>();
            foreach (var i in doc.Where(x => x.MainActivityId != null).GroupBy(x => x.SubActivityId))
            {
                var subActivity = i.Key;
                var action = doc.FirstOrDefault(x => x.SubActivityId == subActivity);
                AccomplishmentReports.Add(new AccomplishmentReport()
                {
                    MainActivity = action?.MainActivity?.Value,
                    SubActivity = action?.SubActivity?.Value,
                    TotalCount = doc.Count(x => x.SubActivityId == subActivity)
                });
            }

        }

        public string NotedBy { get; set; }
        public string NotedByPosition { get; set; }
        public string ReviewedBy { get; set; }
        public string ReviewedByPosition { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string PeriodOf { get; set; }
        public List<AccomplishmentReport> AccomplishmentReports { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePosition { get; set; }
        public string UserId { get; set; }
        public string Office { get; set; }
        public string TelNo { get; set; }
        public string Address { get; set; }
    }

    public class AccomplishmentReport
    {
        public string MainActivity { get; set; }
        public string SubActivity { get; set; }
        public int TotalCount { get; set; }
    }
}
