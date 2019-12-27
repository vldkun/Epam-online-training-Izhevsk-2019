using System;

namespace Module12
{
    public class Calculator
    {
        private delegate int Operation(int a, int b);

        /// <summary>
        /// Computing expressions in Reverse Polish notation.
        /// </summary>
        /// <param name="expression">
        /// Expression in Reverse Polish notation where are always spaces between numbers and operations.
        /// Valid operations are +, -, *, /.
        /// </param>
        /// <returns>Returns result of this expression.</returns>
        public static int Calculate_rpn(string expression)
        {
            var operators = "+-/*";
            var tokens = expression.Split(' ');
            var stack = new Stack<int>();
            foreach (var token in tokens)
            {
                if (operators.Contains(token))
                {
                    Operation operation;
                    switch (token)
                    {
                        case "+":
                            operation = (a, b) => a + b;
                            break;
                        case "-":
                            operation = (a, b) => a - b;
                            break;
                        case "*":
                            operation = (a, b) => a * b;
                            break;
                        case "/":
                            operation = (a, b) => a / b;
                            break;
                        default:
                            throw new ArgumentException("Invalid RPN expression");
                    }

                    var operand2 = stack.Pop();
                    var operand1 = stack.Pop();
                    stack.Push(operation(operand1, operand2));
                }
                else
                {
                    var temp = token;
                    if (token[0] == '-')
                    {
                        temp = token.Substring(1, token.Length - 1);
                    }
                    if (!Array.TrueForAll(temp.ToCharArray(), char.IsDigit))
                    {
                        throw new ArgumentException("Invalid RPN expression");
                    }

                    stack.Push(Convert.ToInt32(token));
                }
            }

            if (stack.Count != 1)
            {
                throw new ArgumentException("Invalid RPN expression");
            }

            return stack.Pop();
        }
    }
}
