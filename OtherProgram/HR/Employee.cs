using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherProgram
{
    
    internal class Employee
    {
        private string name;
        private string lastName;
        private string email;

        private int numberOfHourWorked;
        private double wage;
        private double ? hourlyRate;
        public static double taxRate = 0.15;


        private DateTime birthDay;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int NumberOfHourWorked { 
            get => numberOfHourWorked;

            set { 
                if(numberOfHourWorked < 0) numberOfHourWorked = 0;
                else numberOfHourWorked = value;
            }

        }
        public double Wage
        {
            get => wage;

            set
            {
                if (wage < 0) numberOfHourWorked = 0;
                else wage = value;
            }

        }
        public double ? HourlyRate
        {
            get => hourlyRate;

            set
            {
                if (hourlyRate < 0) hourlyRate = 0;
                else hourlyRate = value;
            }

        }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }

        public Employee(string nm, string lstnm, string em, DateTime dtobirth, double ? rate)
        {
            Name = nm;
            LastName = lstnm;
            Email = em;
            BirthDay = dtobirth;
            HourlyRate = rate ?? 10;

        }

        public void PerformingWork()
        {
            NumberOfHourWorked++;
            Console.WriteLine($"{name} {lastName} is now working...!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{name} {lastName} has stopped working...");
        }

        public double ReceiveWage()
        {
            double wageBeforeTaxes = NumberOfHourWorked * HourlyRate.Value;
            double taxAmount = wageBeforeTaxes * taxRate;

            Wage = wageBeforeTaxes - taxAmount;

            Console.WriteLine($"The wage for {NumberOfHourWorked} hours of work is: {Wage}.");
            NumberOfHourWorked = 0;

            return Wage;

        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {Name}\nLast name: {LastName}\nEmail: {Email}\nBirthday:" +
                $"{BirthDay.ToLongDateString()}");
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{Name} {LastName} received a bonus of 100.");
        }
    }
}
