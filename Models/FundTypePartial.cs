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
        //    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //    public List<Appropriations> Appropriations =>
        //        new UnitOfWork().AppropriationsRepoRepo.Fetch(m => m.FundType == FundType && m.Year == Year).ToList();
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? Year { get; set; }

        public decimal? TotalAppropriation => Appropriations.Where(x=>x.Year==Year).Sum(x => x.Appropriation);
        public decimal? TotalAllotment => Appropriations.Where(x => x.Year == Year).Sum(x => x.Allotment);
        public decimal? TotalAppBalance => Appropriations.Where(x => x.Year == Year).Sum(x => x.AppropriationBalance);
        public decimal? TotalAllotmentBalance => Appropriations.Where(x => x.Year == Year).Sum(x => x.AllotmentBalanceIncEM);
    }
}
