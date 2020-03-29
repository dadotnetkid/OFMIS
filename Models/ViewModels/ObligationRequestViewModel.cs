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

        public void GenerateReport(int year)
        {
            this.Obligations = new UnitOfWork().ObligationsRepo.Get(m => m.Year == year);
            this.Year = year;
        }

        public int Year { get; set; }

        public List<Obligations> Obligations
        {
            get => _obligations;
            set => _obligations = value;
        }

        public decimal? TotalObligations => Obligations.Sum(m => m.TotalAmount);
    }
}
