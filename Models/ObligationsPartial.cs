using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Obligations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TotalAmount => this.ORDetails.Sum(m => m.Amount);

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string AmountToWords => Amount.ToString().NumberToWords();
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public Signatories Governor
        {
            get
            {
                var res = ApprovedBy?.Position == "Governor" ? null : new UnitOfWork().ChiefOfOfficesRepo.Find(m => m.Position == "Governor");

                return res;
            }
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [NotMapped]
        public Signatories ApprovedBy => new UnitOfWork().ChiefOfOfficesRepo.Find(m => m.Person == this.OBRApprovedBy);
    }
}
