using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee empJohn = new PermanentEmployee(1, "John");
            //Console.WriteLine($"Employee:\n {empJohn.ToString()} \nBonus: {empJohn.CalculateBonus(100000).ToString()}");

            //Employee empManu = new TemporaryEmployee(2, "Manu");
            //Console.WriteLine($"Employee:\n {empManu.ToString()} \nBonus: {empManu.CalculateBonus(100000).ToString()}");

            //ContractEmployee empMike = new ContractEmployee(3, "Mike");
            //Console.WriteLine($"Employee:\n {empMike.ToString()} \nBonus: {empMike.GetMinimumSalary().ToString()}");

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Manu"));
            employees.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee:\n {employee.ToString()} \nSalary: {employee.GetMinimumSalary()}");
                
            }
            Console.ReadLine();

        }
    }
}
