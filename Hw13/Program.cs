using System;
using System.Collections.Generic;
using System.Linq;

namespace Hw13
{
    class Company
    {
        public string Name { get; set; }
        public DateTime Foundation { get; set; }
        public string Business { get; set; }
        public string Director { get; set; }
        public int Employees { get; set; }
        public string Address { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            List<Company> companies = new List<Company>()
            {
                new Company { Name="FoodMarket", Foundation=new DateTime(2020,1,1), Business="Marketing", Director="John White", Employees=150, Address="London"},
                new Company { Name="ITCompany", Foundation=new DateTime(2022,5,10), Business="IT", Director="Jack Black", Employees=250, Address="Paris"},
                new Company { Name="White Food", Foundation=DateTime.Now.AddDays(-123), Business="Marketing", Director="Tom Black", Employees=90, Address="London"}
            };

            Console.WriteLine("Всі фірми");
            var q1 = from c in companies select c;
            foreach (var c in q1)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nFood");
            var q2 = from c in companies
                     where c.Name.Contains("Food")
                     select c;
            foreach (var c in q2)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nMarketing");
            var q3 = from c in companies
                     where c.Business == "Marketing"
                     select c;
            foreach (var c in q3)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nMarketing або IT");
            var q4 = from c in companies
                     where c.Business == "Marketing" || c.Business == "IT"
                     select c;
            foreach (var c in q4)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nПрацівників >100");
            var q5 = from c in companies
                     where c.Employees > 100
                     select c;
            foreach (var c in q5)
                Console.WriteLine(c.Name);

            Console.WriteLine("\n100-300");
            var q6 = from c in companies
                     where c.Employees >= 100 && c.Employees <= 300
                     select c;
            foreach (var c in q6)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nLondon");
            var q7 = from c in companies
                     where c.Address == "London"
                     select c;
            foreach (var c in q7)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nWhite");
            var q8 = from c in companies
                     where c.Director.Contains("White")
                     select c;
            foreach (var c in q8)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nБільше 2 років");
            var q9 = from c in companies
                     where (DateTime.Now - c.Foundation).Days > 730
                     select c;
            foreach (var c in q9)
                Console.WriteLine(c.Name);

            Console.WriteLine("\n123 дні");
            var q10 = from c in companies
                      where (DateTime.Now - c.Foundation).Days == 123
                      select c;
            foreach (var c in q10)
                Console.WriteLine(c.Name);

            Console.WriteLine("\nBlack + White");
            var q11 = from c in companies
                      where c.Director.Contains("Black") && c.Name.Contains("White")
                      select c;
            foreach (var c in q11)
                Console.WriteLine(c.Name);
        }
    }
}
