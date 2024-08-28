using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals_bakend.MathExpressionEvaluator
{
    public static class ExpressionParser
    {
        /*
        * 5+7
        * 6 +7
        * 6 - 5
        * sin 8
        * -4-7
        * 6--1
        * cos    28
        * 5 mod   5
        * 6 pow 2
        */
        private const string MathSymobls = "+*/%^";
        public static MathExpression parse(String input)
        {
            input = input.Trim();
            var expr = new MathExpression();
            // 12345 * 2456
            String token = "";
            bool leftSideInitialized = false;
            for(int i = 0;i < input.Length; i++)
            {
                var currentChar = input[i];
                if (char.IsDigit(currentChar))
                {
                    token += currentChar;
                    if (i == input.Length - 1 && leftSideInitialized)
                    {
                        try
                        {
                            expr.RightsideOperand = double.Parse(token);
                            break;
                        }  
                        catch (Exception mo)
                        {

                            Console.WriteLine("incorecct");
                        }
                    }
                }
                else if (MathSymobls.Contains(currentChar))
                {
                    if (!leftSideInitialized)
                    {
                        expr.leftsideOperand = double.Parse(token);
                        leftSideInitialized = true;

                    }
                    expr.Operation = parseMathOperation(currentChar.ToString());
                    token = "";
                }
                else if (currentChar == '-' && i > 0)
                {
                    if (expr.Operation == MathOperation.None)
                    {
                        if (!leftSideInitialized)
                        {
                            expr.leftsideOperand = double.Parse(token);
                            leftSideInitialized = true;
                        }
                        expr.Operation = MathOperation.Subtraction;
                        token = "";
                    }
                    else
                        token += currentChar;
                }
                else if (Char.IsLetter(currentChar))
                {
                    token += currentChar;
                    leftSideInitialized = true;
                }
                else if (currentChar == ' ')
                {
                    if (!leftSideInitialized)
                    {
                        expr.leftsideOperand = double.Parse(token);
                        leftSideInitialized = true;
                        token = "";
                    }
                
                else if (expr.Operation == MathOperation.None)
                {
                    expr.Operation = parseMathOperation(token);
                    token = "";
                }
                    
                }
                else
                token += currentChar;
            }

            return expr;
        }

        private static MathOperation parseMathOperation(string token)
        {
            switch (token.ToLower())
            {
                case "+":
                    return MathOperation.Addition;
                case "*":
                    return MathOperation.Multiplication;
                case "/":
                    return MathOperation.Division;
                case "%":
                    return MathOperation.Modulus;
                case "^":
                case "pow":
                    return MathOperation.Power;
                case "sin":
                    return MathOperation.Sin;
                case "cos":
                    return MathOperation.Cos;
                case "tan":
                    return MathOperation.Tan;
                default:
                    return MathOperation.None;
            }
        }
    }
}
