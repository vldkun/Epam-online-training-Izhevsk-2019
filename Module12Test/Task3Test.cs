using System.Text;
using NUnit.Framework;
using Module12;

namespace Module12Test
{
    [TestFixture]
    public class Task3Test
    {
        [TestCase(1, ExpectedResult = "0")]
        [TestCase(2, ExpectedResult = "0 1")]
        [TestCase(3, ExpectedResult = "0 1 1")]
        [TestCase(6, ExpectedResult = "0 1 1 2 3 5")]
        [TestCase(8, ExpectedResult = "0 1 1 2 3 5 8 13")]
        public string TestFibonacciNumbers(int n)
        {
            var result = new StringBuilder();
            foreach (var num in Task3.Fibonacci(n))
            {
                result.Append(num + " ");
            }

            if (result[result.Length - 1] == ' ')
            {
                result.Remove(result.Length - 1, 1);
            }
            return result.ToString();
        }
    }
}
