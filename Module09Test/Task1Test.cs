using System;
using NUnit.Framework;
using Module09;

namespace Module09Test
{
    [TestFixture]
    public class Task1Test
    {
        [Test]
        public void TestCustomerStringRepresentationNameRevenuePhone()
        {
            var customer = new Customer("Jeffrey Richter", 1000000, "+1 (425) 555-0100");
            Assert.AreEqual("Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100",
                customer.StringRepresentation());
        }

        [Test]
        public void TestCustomerStringRepresentationName()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";

            Assert.AreEqual("Customer record: Jeffrey Richter", customer.StringRepresentation());
        }

        [Test]
        public void TestCustomerStringRepresentationNameRevenue()
        {
            var customer = new Customer();
            customer.Name = "Jeffrey Richter";
            customer.Revenue = 1000000;

            Assert.AreEqual("Customer record: Jeffrey Richter, 1,000,000.00", customer.StringRepresentation());
        }

        [Test]
        public void TestCustomerStringRepresentationPhone()
        {
            var customer = new Customer();
            customer.ContactPhone = "+1 (425) 555-0100";

            Assert.AreEqual("Customer record: +1 (425) 555-0100", customer.StringRepresentation());
        }
    }
}