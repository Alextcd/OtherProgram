using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherProgram.HR
{
    internal class Researchers : Employee
    {
        public Researchers(string nm, string lstnm, string em, DateTime dtobirth, double? rate) : base(nm, lstnm, em, dtobirth, rate)
        {
        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHourWorked += researchHours;
            Console.WriteLine($"Researcher {Name} {LastName} has invented a new pie taste!");
        }
    }

    internal class JuniorResearcher : Researchers
    {
        public JuniorResearcher(string nm, string lstnm, string em, DateTime dtobirth, double? rate) : base(nm, lstnm, em, dtobirth, rate)
        {
        }
    }
}
