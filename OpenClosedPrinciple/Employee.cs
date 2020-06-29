using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }

    //    public Employee()
    //    {

    //    }
    //    public Employee(int id, string name)
    //    {
    //        Id = id;
    //        Name = name;
    //    }

    //    public decimal CalculateBonus(decimal salary)
    //    {
    //        return salary * 0.1M;
    //    }
    //    public override string ToString()
    //    {
    //        return $"Id: {Id} Name: {Name}";
    //    }
    //}

    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name}";
        }
    }
}
