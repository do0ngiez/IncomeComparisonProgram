using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            decimal hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            int hoursWorkedPerWeek1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate? ");
            decimal hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            int hoursWorkedPerWeek2 = Convert.ToInt32(Console.ReadLine());

            decimal annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
            decimal annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(annualSalary1);

            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);

            bool doesPerson1MakeMore = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(doesPerson1MakeMore);

            Console.ReadLine();
        }
    }
}
