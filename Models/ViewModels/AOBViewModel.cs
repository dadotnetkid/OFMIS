using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class AOBViewModel
    {


        public void GenerateReport(int year)
        {
            this.FundTypesRepo = new UnitOfWork().FundTypesRepo.Get().ToList();
            this.FundTypesRepo.ForEach(x => x.Year = year);
            this.Year = year;
            this.FundTypesRepo = FundTypesRepo.Where(x => x.Appropriations.Any()).ToList();
        }

        public int Year { get; set; }


        public List<FundTypes> FundTypesRepo { get; set; }

    }
}
