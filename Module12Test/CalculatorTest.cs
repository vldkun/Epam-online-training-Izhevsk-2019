using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase("5 1 2 + 4 * + 3 -", ExpectedResult = 14)]
        [TestCase("1 2 + 4 * -3 +", ExpectedResult = 9)]
        public int TestRPN(string str)
        {
            return Calculator.Calculate_rpn(str);
        }
    }
}
