using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal class PayItem
    {
        public PayItem(String name , decimal value) 
        {
            Name = name;
            Value = value;

        }

        public string Name { get; }
        public decimal Value { get; }
    }
}
