using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpers;
using Models;
using Models.Repository;

namespace Win
{
    public class StaticSettings
    {
        private  UnitOfWork unitOfWork = new UnitOfWork();
        private  Years activeYear => unitOfWork.YearsRepo.Find(m => m.IsActive == true);
        public  DefaultSettings settings() => unitOfWork.DefaultSettingsRepo.Fetch(m => m.Year == activeYear.Year).FirstOrDefault() ?? new DefaultSettings();

        public  int Year => activeYear.Year.ToInt();
        public  int Id => settings().Id;
        public  string PG => settings().PG;
        public  string PGPos => settings().PGPos;
        public  string PA => settings().PA;
        public  string PAPos => settings().PAPos;
        public  string PBO => settings().PBO;
        public  string PBOPos => settings().PBOPos;
        public  string PT => settings().PT;
        public  string PTPos => settings().PTPos;
        public  string PAccountant => settings().PAccountant;
        public  string PAccountantPos => settings().PAccountantPos;
        public  string PGSO => settings().PGSO;
        public  string PGSOPosition => settings().PGSOPosition;
        public  string Department => settings().Department;
        public  string ChiefOfOffice => settings().ChiefOfOffice;
        public  string ChiefOfOfficePos => settings().ChiefOfOfficePos;
        public  string ResponsibilityCenter => settings().ResponsibilityCenter;
        public  string ResponsibilityCenterCode => settings().ResponsibilityCenterCode;
        public  string OfficeId => settings().OfficeId;



    }
}
