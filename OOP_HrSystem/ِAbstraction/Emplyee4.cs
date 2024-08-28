using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal abstract class Emplyee4 : Person2
    {
       
        public string Email { get; internal set; }

        public abstract decimal GetSalary();
        public abstract IEnumerable<PayItem> GetPayItems();
    }
}
