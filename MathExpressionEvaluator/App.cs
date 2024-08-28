using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.MathExpressionEvaluator
{
    /*
    public static class App
    {
         
        public static void Run(String[] args)
        {
            while (true)
            {
                Console.Write("Please enter math experation: ");
                var input= Console.ReadLine();
                var expr = ExpressionParser.parse(input);
                Console.WriteLine($"Left Side = {expr.leftsideOperand}, Operation = {expr.Operation},Right side = {expr.RightsideOperand}");
                Console.WriteLine($"{input} = {EvaluateExpression(expr)}");
            }

        }

        private static object EvaluateExpression(MathExpression expr)
        {
            switch(expr.Operation)
            {
                case MathOperation.Addition:
                    return expr.leftsideOperand + expr.RightsideOperand;
                case MathOperation.Subtraction:
                    return expr.leftsideOperand - expr.RightsideOperand;
                case MathOperation.Multiplication:
                    return expr.leftsideOperand * expr.RightsideOperand;
                case MathOperation.Division:
                    return expr.leftsideOperand / expr.RightsideOperand;
                case MathOperation.Modulus:
                    return expr.leftsideOperand % expr.RightsideOperand;
                case MathOperation.Power:
                    return Math.Pow(expr.leftsideOperand, expr.RightsideOperand);
                case MathOperation.Sin:
                    return Math.Sin( expr.RightsideOperand);
                case MathOperation.Cos:
                    return Math.Cos( expr.RightsideOperand);
                case MathOperation.Tan:
                    return Math.Tan( expr.RightsideOperand);
                default:

                    return 0;

            }
            return 0;
        }
         
    }
    */
}
