using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.NewFolder
{
    public abstract class Shape
    {
        protected String Name { get; set; }
        public abstract double CalculateArea();
        public virtual void PrintArea()
        {

            Console.WriteLine($"Area of shape {Name} {CalculateArea()}"); // Q-52 and 53
        }
        //////////////////////////////////////////////////////////////////
        //public  void PrintArea()
        //{

        //    Console.WriteLine($"Area of shape {Name} {CalculateArea()}"); // Q-54
        //}
    }

    //public sealed class MySealedClacc { }
    //public class Test : MySealedClacc { }

}
