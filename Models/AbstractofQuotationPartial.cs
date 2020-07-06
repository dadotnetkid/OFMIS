using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class AOQ
    {
        public string BACCommittees => string.Join(",", this.BacMembers.Select(x => x.Person));
    }
}
