using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F25IntroToLinq
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName; 
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{FirstName,-10} {LastName,-10} {Salary,10:C}";
        }
    }
}
