using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Repository;

namespace Models
{
    public partial class AOQ
    {
        public string BACCommittees => string.Join(",", this.BacMembers.Select(x => x.Person));
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public Signatories ViceChairperson =>
            new UnitOfWork(false,false).Signatories.Find(x => x.BacPosition == "BAC-Goods, Vice-Chairperson");
    }
}
