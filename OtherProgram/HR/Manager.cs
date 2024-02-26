using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherProgram.HR
{
    internal class Manager : Employee
    {
        public Manager(string nm, string lstnm, string em, DateTime dtobirth, double? rate) : base(nm, lstnm, em, dtobirth, rate)
        {
        }

        public override void GiveBonus()
        {
            if(NumberOfHourWorked > 5) Console.WriteLine($"{Name} {LastName} has receive a bonus of 500!");
            else Console.WriteLine($"{Name} {LastName} has receive a bonus of 250!");
        }

        public void AttendingMettings()
        {
            NumberOfHourWorked += 10;
            Console.WriteLine($"Manager {Name} {LastName} is now attending to a meeting that could have been an email!");
        }
    }
}
