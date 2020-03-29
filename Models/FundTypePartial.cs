using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class FundTypes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public List<Appropriations> Appropriations =>
            new UnitOfWork().AppropriationsRepoRepo.Fetch(m => m.FundType == FundType && m.Year == Year).ToList();
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Year { get; set; }

        public decimal? TotalAppropriation => Appropriations.Sum(x => x.Appropriation);
        public decimal? TotalAllotment => Appropriations.Sum(x => x.Allotment);
        public decimal? TotalAppBalance => Appropriations.Sum(x => x.AppropriationBalance);
        public decimal? TotalAllotmentBalance => Appropriations.Sum(x => x.AllotmentBalanceIncEM);
    }
}
