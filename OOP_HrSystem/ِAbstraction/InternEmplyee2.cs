using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal class InternEmplyee2 : Emplyee4
    {
        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Basic Salary", 2000) };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return 200;
        }
    }
}
