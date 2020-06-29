using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    class ContractEmployee : IEmployee
    {
        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get ; set ; }
        public string Name { get ; set ; }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
}
