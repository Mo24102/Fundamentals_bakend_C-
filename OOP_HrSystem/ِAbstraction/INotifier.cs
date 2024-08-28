using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.OOP_HrSystem._ِAbstraction
{
    internal interface INotifier
    {
        void Notify(String email, String subject, String body);
    }
}
