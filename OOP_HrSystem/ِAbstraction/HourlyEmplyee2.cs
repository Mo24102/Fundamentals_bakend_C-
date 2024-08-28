using Fundamentals_bakend.OOP_HrSystem.Polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal  class  HourlyEmplyee2 : Emplyee4 
    {
        public decimal HourRate { get; set; }
        public decimal TotalWorkingHour { get; set; }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[] { new PayItem("Total Hours", GetSalary()) };
        }

        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return HourRate * TotalWorkingHour;
        }


    }
    }

