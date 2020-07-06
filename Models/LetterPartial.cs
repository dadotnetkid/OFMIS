using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public partial class Letters
    {
        string res = '\u0022' + "For and in the absence of the PITD:" + '\u0022';
        public string ShowForandInTheAbsenceOf => ShowInTheAbsenceofthePLO == true ? res : "";
    }
}
