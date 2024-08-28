using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.NewFolder
{
    public static class MyStaticClass
    {
        static MyStaticClass()
        {
            Console.WriteLine("Static Constructor Calle");
        }
        public static void DoSomething()
        {
            Console.WriteLine("Hello World");
        }

    }
}
