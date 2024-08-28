using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem.Polymorphism
{
    internal class HourlyEmplyee : Emplyee3
    {
        public decimal HourRate {  get; set; }
        public decimal TotalWorkingHour { get; set; }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return HourRate * TotalWorkingHour;
        }
    }
}
