using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.Interfaces
{
    public class Computer : IDevice , IRestartable
    {
        void IDevice.TurnOn()
        {
            Console.WriteLine("Explicit implementation");
        }
        public void TurnOn()
        {
            Console.WriteLine("Computer is turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Computer is turned off");
        }

        public void Restart()
        {
            Console.WriteLine("Computer restarted");
        }
    }
}
