using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.Interfaces
{
    public class MobilePhon : IDevice , IRestartable
    {
        public void TurnOn()
        {
            Console.WriteLine("Mobile is turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Mobile is turned off");
        }
        public void Restart()
        {
            Console.WriteLine("Mobile restarted");
        }
    }
}
