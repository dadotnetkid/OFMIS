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
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public int? Year { get; set; }

        [Newtonsoft.Json.JsonIgnoreAttribute]
        public int OfficeId { get; set; }
    }
}
