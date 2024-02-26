using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherProgram.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string nm, string lstnm, string em, DateTime dtobirth, double? rate) : base(nm, lstnm, em, dtobirth, rate)
        {
        }
    }
}
