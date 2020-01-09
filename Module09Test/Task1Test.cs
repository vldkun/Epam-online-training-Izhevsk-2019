using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task1Test
    {
        [TestCase("Customer record: NN, RR, PP", ExpectedResult = "Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100")]
        [TestCase("Name: NN, Revenue: RR, Contact phone: PP.", ExpectedResult = "Name: Jeffrey Richter, Revenue: 1,000,000.00, Contact phone: +1 (425) 555-0100.")]
        public string TestCustomerStringRepresentation(string format)
        {
            var customer = new Customer("Jeffrey Richter", 1000000, "+1 (425) 555-0100");
            return customer.StringRepresentation(format);
        }
    }
}