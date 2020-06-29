﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {
        }

        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05M;
        }
    }
}
