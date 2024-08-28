using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal class SalaryEmplyee2 : Emplyee4
    {

        public decimal BasicSalary { get; set; }
        public decimal Transportation { get; set; }
        public decimal Housing { get; set; }
        public void SetSalaryEmplyee(decimal basicSalary, decimal transportation, decimal housing)
        {
            BasicSalary = basicSalary;
            Transportation = transportation;
            Housing = housing;
        }
        public override decimal GetSalary()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return BasicSalary + Transportation + Housing;
        }
        public decimal GetSalary(int taxPercentage)
        {
            return GetSalary() - (BasicSalary * taxPercentage / 100);
        }
        public decimal GetSalary(int taxPercentage, decimal bonus)
        {
            return GetSalary(taxPercentage) + bonus;
        }

        public override IEnumerable<PayItem> GetPayItems()
        {
            return new[]
            {
                new PayItem("Basic Salary",BasicSalary),
                new PayItem("Transportation",Transportation),
                new PayItem("Housing",Housing),

            };
            }
        }
    }
