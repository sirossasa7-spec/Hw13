using System;
using System.Collections.Generic;
using System.Linq;

namespace Hw13
{
    class Employee
    {
        public string Name;
        public string Position;
        public string Phone;
        public string Email;
        public int Salary;
    }

    class Company
    {
        public string Name;
        public List<Employee> Employees = new List<Employee>();
    }
    internal class Task3
    {
        static void Main()
        {
            Company company = new Company();
            company.Name = "ITCompany";

            company.Employees.Add(new Employee
            {
                Name = "Lionel Messi",
                Position = "Manager",
                Phone = "231111",
                Email = "director@gmail.com",
                Salary = 50000
            });

            company.Employees.Add(new Employee
            {
                Name = "Ivan Ivanov",
                Position = "Programmer",
                Phone = "451111",
                Email = "ivan@gmail.com",
                Salary = 25000
            });

            var q1 = from e in company.Employees
                     select e;

            var q2 = from e in company.Employees
                     where e.Salary > 30000
                     select e;

            var q3 = from e in company.Employees
                     where e.Position == "Manager"
                     select e;

            var q4 = from e in company.Employees
                     where e.Phone.StartsWith("23")
                     select e;

            var q5 = from e in company.Employees
                     where e.Email.StartsWith("di")
                     select e;

            var q6 = from e in company.Employees
                     where e.Name.StartsWith("Lionel")
                     select e;

            foreach (var e in q6)
                Console.WriteLine(e.Name);
        }
    }
}
