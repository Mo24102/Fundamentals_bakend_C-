using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem.Inheritance
{
    internal class Emplyee2 : Person
    {
        public decimal BasicSalary { get; private set; }
        public void SetBasicSalary(decimal basicSalary)
        {
            if (basicSalary < 5000)
                Console.WriteLine("Invalid Salary");
            BasicSalary = basicSalary;
        }
        public int TaxPercentage { get; private set; }
        public void SetTaxPercentage(int taxPercentage)
        {
            if (taxPercentage < 100)
                throw new ArgumentNullException("Invalid Taxe");
            TaxPercentage = taxPercentage;
        }


    }
}

