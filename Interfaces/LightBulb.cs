using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.Interfaces
{
    internal class LightBulb : IDevice
    {
        public void TurnOn()
        {
            Console.WriteLine("Bulb is turned on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Bulb is turned off");

        }
    }
}
