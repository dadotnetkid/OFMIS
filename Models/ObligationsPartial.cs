using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Obligations
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TotalAmount => this.ORDetails.Sum(m => m.Amount);
    }
}
