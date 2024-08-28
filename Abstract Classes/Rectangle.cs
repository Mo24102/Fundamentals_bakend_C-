using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.NewFolder
{
    public  class Rectangle : Shape
    {
        public Rectangle() 
        {
            Name = "My Rect";
        }
        public double leghth {  get; set; }
        public double width { get; set; }

        public override double CalculateArea()
        {
            return leghth * width;
        }

        public override void PrintArea()
        {
            base.PrintArea();
            Console.WriteLine($"Area of rectangle with length {leghth} and width {width} = {CalculateArea()}"); // Q-52 and 53
        }
        ///////////////////////////////////////////////////////////
        //public new void PrintArea()
        //{
        //    base.PrintArea();
        //    Console.WriteLine($"Area of rectangle with length {leghth} and width {width} = {CalculateArea()}"); // Q-54
        //}

    }
}
