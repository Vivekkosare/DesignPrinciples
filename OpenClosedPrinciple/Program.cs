using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohn = new PermanentEmployee(1, "John");
            Console.WriteLine($"Employee:\n {empJohn.ToString()} \nBonus: {empJohn.CalculateBonus(100000).ToString()}");

            Employee empManu = new TemporaryEmployee(2, "Manu");
            Console.WriteLine($"Employee:\n {empManu.ToString()} \nBonus: {empManu.CalculateBonus(100000).ToString()}");
            Console.ReadLine();
        }
    }
}
