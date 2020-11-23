using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models.ViewModels
{
    public class LARViewModel
    {
        public List<FundTypeVM> FundTypes { get; set; }
        public int OfficeId { get; set; }
        public int Year { get; set; }
        public string FT { get; set; }

        public void Generate()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            var res = new List<FundTypeVM>();
            foreach (var i in unitOfWork.FundTypesRepo.Fetch().OrderBy(x => x.ItemNumber))
            {
                var vm = new FundTypeVM()
                {
                    Id = i.Id,
                    FundType = i.FundType,
                    OfficeId = OfficeId,
                    Year = Year
                };

                vm.Generate(FT);
                res.Add(vm);
            }

            this.FundTypes = res;
        }


    }

    public class FundTypeVM : FundTypes
    {
        private string ft;

        public void Generate(string ft)
        {
            this.ft = ft;
            this.AppropriationVms = this._appropriationVMs;

        }

        public List<AppropriationVM> AppropriationVms { get; set; }
        private List<AppropriationVM> _appropriationVMs
        {
            get
            {

                UnitOfWork unitOfWork = new UnitOfWork();
                var res = new List<AppropriationVM>();

                foreach (var i in unitOfWork.AppropriationsRepoRepo.Get(x => x.FundTypeId == Id && x.OfficeId == OfficeId && x.Year == Year && x.FT == ft).Where(x => x.Allotments.Any()))
                {

                    var vm = new AppropriationVM()
                    {
                        Id = i.Id,
                        FundType = i.FundType,
                        FundTypeId = i.FundTypeId,
                        AccountCode = i.AccountCode,
                        AccountCodeText = i.AccountCodeText,
                        AccountName = i.AccountName,
                        Appropriation = i.Appropriation,
                        OfficeId = OfficeId,
                        Year = Year,

                    };
                    vm.Generate();
                    res.Add(vm);

                }
                return res;
            }
        }


        public decimal? TotalAppropriation => this.AppropriationVms?.Sum(x => x.Appropriation);

    }

    public class AppropriationVM : Appropriations
    {
        public decimal? TotalAppropriationBalance { get; set; }
        public void Generate()
        {
            AllotmentVms = _allotmentVM;
        }
        public List<AllotmentVM> AllotmentVms { get; set; }

        private List<AllotmentVM> _allotmentVM
        {
            get
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                var res = new List<AllotmentVM>();
                var balance = this.Appropriation;
                foreach (var i in unitOfWork.AllotmentsRepo.Get(x => x.AppropriationId == Id))
                {
                    balance = balance - i.AllotmentAmount;
                    res.Add(new AllotmentVM()
                    {
                        Id = i.Id,
                        AppropriationId = i.AppropriationId,
                        AllotmentAmount = i.AllotmentAmount,
                        AllotmentDate = i.AllotmentDate,
                        Remarks = i.Remarks,
                        AllotmentBalance = balance
                    });

                }
                return res;
            }

        }

        public decimal? TotalBalance => (this.Appropriation ?? 0) - (TotalAllotment ?? 0);
        public decimal? TotalAllotment => this.AllotmentVms?.Sum(x => x.AllotmentAmount);
        /*
         *  TotalAllotmentName=$"Total Allotment Release for { i.AccountName}" ,
                        TotalAppropriationBalance= $"Total Apropriation Balance for { i.AccountName}"
         */
        public string TotalAllotmentReleaseName => $"Total Allotment Release for {AccountName} ";
        public string TotalAppropriationBalanceName => $"Total Apropriation Balance for {AccountName} ";
    }

    public class AllotmentVM : Allotments
    {
        public decimal? AllotmentBalance { get; set; }
    }
}
//[FundTypes.AppropriationVms.Appropriation]-[AllotmentAmount]
