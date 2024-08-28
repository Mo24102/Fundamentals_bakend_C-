using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem.Polymorphism
{
    internal class InternEmplyee : Emplyee3
    {
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return 200;
        }

    }
}
