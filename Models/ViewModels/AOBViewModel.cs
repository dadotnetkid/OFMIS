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


        public void GenerateReport(int year, int officeId)
        {
            this.Year = year;

            UnitOfWork unitOfWork = new UnitOfWork();
            FundTypesRepo = new List<FundTypeViewModel>();
            foreach (var i in unitOfWork.FundTypesRepo.Get())
            {
                var fundTypeViewModel = new FundTypeViewModel()
                {
                    Id = i.Id,
                    FundType = i.FundType,
                    Description = i.Description,
                    Year = year,
                    OfficeId = officeId
                };
                fundTypeViewModel.Generate();

                FundTypesRepo.Add(fundTypeViewModel);
            }

            this.Office = unitOfWork.OfficesRepo.Find(x => x.Id == officeId);
        }

        public Offices Office { get; set; }

        public int Year { get; set; }

        public List<FundTypeViewModel> FundTypesRepo { get; set; }
        // public List<FundTypes> FundTypesRepo { get; set; }

    }

    public class FundTypeViewModel
    {
        public int Id { get; set; }
        public string FundType { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int OfficeId { get; set; }

        public void Generate()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.Appropriations = unitOfWork.AppropriationsRepoRepo.Get(x => x.OfficeId == OfficeId && x.Year == Year && x.FundTypeId == Id);
            TotalAppropriation = Appropriations.Sum(x => x.Appropriation);
            TotalAllotment = Appropriations.Sum(x => x.Allotment);
            TotalAppBalance = Appropriations.Sum(x => x.AppropriationBalance);
            TotalAllotmentBalance = Appropriations.Sum(x => x.AllotmentBalanceIncEM);
            TotalObligations = Appropriations.Sum(x => x.ORDetails.Sum(m => m.Amount));
        }

        public List<Appropriations> Appropriations { get; set; }
        public decimal? TotalAppropriation { get; set; }
        public decimal? TotalAllotment { get; set; }
        public decimal? TotalAppBalance { get; set; }
        public decimal? TotalAllotmentBalance { get; set; }
        public decimal? TotalObligations { get; set; }
    }

}
/*
 *
 *  this.FundTypesRepo = new UnitOfWork().FundTypesRepo.Get().ToList();
            this.FundTypesRepo.ForEach(x =>
            {
                x.Year = year;
                x.OfficeId = officeId;
            });
            this.Year = year;
            this.FundTypesRepo = FundTypesRepo.Where(x => x.Appropriations.Any(m => m.OfficeId == officeId)).ToList();
 */
