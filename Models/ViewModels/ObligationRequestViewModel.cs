using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class ObligationRequestViewModel
    {
        private List<Obligations> _obligations;
        public string PreparedBy { get; set; }
        public string PreparedByPos { get; set; }
        public void GenerateReport(Action<ObligationRequestViewModel> action ,int year, int officeId, string defaultFundType)
        {
            ObligationRequestViewModel vm = new ObligationRequestViewModel();
            action(vm);

               UnitOfWork unitOfWork = new UnitOfWork();
            this.Obligations = unitOfWork.ObligationsRepo.Get(m => m.Year == year && m.OfficeId == officeId && m.FT == defaultFundType);
            this.Offices = unitOfWork.OfficesRepo.Find(m => m.Id == officeId);
            this.Year = year;
        }

        public int Year { get; set; }

        public List<Obligations> Obligations
        {
            get => _obligations;
            set => _obligations = value;
        }

        public decimal? TotalObligations => Obligations.Sum(m => m.TotalAmount);
        public Offices Offices { get; set; }
    }
}
