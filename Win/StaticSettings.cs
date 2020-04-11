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
        private UnitOfWork unitOfWork = new UnitOfWork();
        int? officeId = User.OfficeId();
        private Years activeYear => unitOfWork.YearsRepo.Find(m => m.IsActive == true);
        public Offices settings() => unitOfWork.OfficesRepo.Fetch(m => m.Id == officeId).FirstOrDefault();
        public List<Signatories> chiefOfOffice => new UnitOfWork().ChiefOfOfficesRepo.Get(m => m.Year == Year);
        public int Year => activeYear.Year.ToInt();
        public int Id => settings().Id;
        //public  string PG => settings().PG;
        //public  string PGPos => settings().PGPos;
        //public  string PA => settings().PA;
        //public  string PAPos => settings().PAPos;
        //public  string PBO => settings().PBO;
        //public  string PBOPos => settings().PBOPos;
        //public  string PT => settings().PT;
        //public  string PTPos => settings().PTPos;
        //public  string PAccountant => settings().PAccountant;
        //public  string PAccountantPos => settings().PAccountantPos;
        //public  string PGSO => settings().PGSO;
        //public  string PGSOPosition => settings().PGSOPosition;
        public string OfficeName => settings().OfficeName;
        public string Head => settings().Chief;
        public string HeadPos => settings().ChiefPosition;
        public string ResponsibilityCenter => settings().ResponsibilityCenter;
        public string ResponsibilityCenterCode => settings().ResponsibilityCenterCode;
        public int OfficeId => settings().Id;



    }
}
