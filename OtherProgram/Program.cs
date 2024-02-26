using OtherProgram.HR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee bethany = new Employee("Bethany", "Carrasco","bethant@gmail.com", new DateTime(1999,7,14), 300.3);

            Manager diomedes = new Manager("Diomedes", "Trinidad", "diomedes@gmail.com", new DateTime(1995, 9, 7), 300.3);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***********************");
            Console.ForegroundColor = ConsoleColor.White;

            bethany.DisplayEmployeeDetails();
            bethany.PerformingWork();
            bethany.PerformingWork();
            bethany.PerformingWork();
            bethany.PerformingWork();
            bethany.PerformingWork();
            bethany.ReceiveWage();

            diomedes.DisplayEmployeeDetails();
            diomedes.PerformingWork();
            diomedes.PerformingWork();
            diomedes.PerformingWork();
            diomedes.AttendingMettings();
            diomedes.ReceiveWage();



        }
    }
}
