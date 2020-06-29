using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Employee : IEmployee, IEmployeeBonus 
    {

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get ; set ; }
        public string Name { get ; set ; }

        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal GetMinimumSalary();

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
}
