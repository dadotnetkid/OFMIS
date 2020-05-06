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

        public void GenerateReport(int year, int officeId)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.Obligations = unitOfWork.ObligationsRepo.Get(m => m.Year == year && m.OfficeId == officeId);
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
