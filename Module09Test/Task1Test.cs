using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task1Test
    {
        [TestCase(7, ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        [TestCase(1, ExpectedResult = "Customer record: +1 (425) 555-0100")]
        [TestCase(6, ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00")]
        [TestCase(2, ExpectedResult = "Customer record: 1,000,000.00")]
        [TestCase(4, ExpectedResult = "Customer record: Jeffrey Richter")]

        public string TestCustomerStringRepresentation(byte flag)
        {
            var customer = new Customer("Jeffrey Richter", 1000000, "+1 (425) 555-0100");
            return customer.StringRepresentation(flag);
        }
    }
}