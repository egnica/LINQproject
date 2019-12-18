using System;
using System.Linq;

namespace LINQproject
{
    class Employees
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int YearsWorked { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employees[] employeeArray =
             {
                new Employees() {EmployeeID = 1, EmployeeName = "Dave", YearsWorked = 12},
                new Employees() {EmployeeID = 2, EmployeeName = "Sara", YearsWorked = 15},
                new Employees() {EmployeeID = 3, EmployeeName = "Mike", YearsWorked = 5},
                new Employees() {EmployeeID = 4, EmployeeName = "Diana", YearsWorked = 2},
                new Employees() {EmployeeID = 5, EmployeeName = "Bill", YearsWorked = 12},
                new Employees() {EmployeeID = 6, EmployeeName = "Vicky", YearsWorked = 10},
                new Employees() {EmployeeID = 7, EmployeeName = "George", YearsWorked = 5},
                new Employees() {EmployeeID = 8, EmployeeName = "Debbie", YearsWorked = 20},
                new Employees() {EmployeeID = 9, EmployeeName = "Dean", YearsWorked = 18},
                new Employees() {EmployeeID = 10, EmployeeName = "Leslie", YearsWorked = 10},
                new Employees() {EmployeeID = 11, EmployeeName = "Bobbi", YearsWorked = 21},
                new Employees() {EmployeeID = 12, EmployeeName = "Mike", YearsWorked = 11},
                new Employees() {EmployeeID = 13, EmployeeName = "Ryan", YearsWorked = 12},
                new Employees() {EmployeeID = 14, EmployeeName = "Jamie", YearsWorked = 1},
                new Employees() {EmployeeID = 15, EmployeeName = "David", YearsWorked = 14},
            };

            var years = from y in employeeArray
                        where y.YearsWorked >= 15
                        select y;

            foreach(var yea in years)
            {
                Console.WriteLine($"{yea.EmployeeName} has been working for the company for over 15 years. Years: {yea.YearsWorked}");
            }
            Console.WriteLine("============================================================");

            var name = from n in employeeArray
                       where n.EmployeeName.StartsWith("D")
                       orderby n.EmployeeName
                       select n;
            foreach(var nam in name)
            {
                Console.WriteLine($"{nam.EmployeeName} starts with the letter 'D'.");
            }
            Console.WriteLine("============================================================");

            var workedYears = from w in employeeArray
                              orderby w.YearsWorked
                              group w by w.YearsWorked;
            foreach(var wor in workedYears)
            {
                Console.WriteLine($"************************ Years worked group:{wor.Key}");
                foreach(Employees e in wor)
                {
                    Console.WriteLine($"Worker name: {e.EmployeeName}");
                }
            }
        }
    }
}