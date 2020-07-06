using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class Offices
    {
        public int HeadId => new UnitOfWork().Signatories.Find(x => x.Person == this.Chief)?.Id ?? 0;
    }
}
