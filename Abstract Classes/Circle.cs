using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.NewFolder
{
    public  class Circle : Shape
    {
        public Circle()
        {
            Name = "My circle";
        }
        public double Radius {  get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
