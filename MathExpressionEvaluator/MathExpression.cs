using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.MathExpressionEvaluator
{
    public class MathExpression
    {
        public double leftsideOperand {  get; set; }
        public double RightsideOperand {  get; set; }
        public MathOperation Operation { get; set; }
    }
}
