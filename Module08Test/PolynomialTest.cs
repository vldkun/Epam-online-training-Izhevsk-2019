using System;
using NUnit.Framework;
using Module08;

namespace Module08Test
{
    [TestFixture]
    public class PolynomialTest
    {
        [Test]
        public void TestEqualPolynomials()
        {
            var pol1 = new Polynomial(new double[] { 2, 4, 5 });
            var pol2 = new Polynomial(2);
            pol2[0] = 2;
            pol2[1] = 4;
            pol2[2] = 5;

            Assert.IsTrue(pol1.Equals(pol2));
        }

        [Test]
        public void TestNotEqualPolynomials()
        {
            var pol1 = new Polynomial(new double[] { 2, 4, 5 });
            var pol2 = new Polynomial(2);
            pol2[0] = 2;
            pol2[1] = 4;
            pol2[2] = 4;

            Assert.IsFalse(pol1.Equals(pol2));
        }

        [Test]
        public void TestSumOfPolynomials()
        {
            var pol1 = new Polynomial(new double[] {2, 4, 5});
            var pol2 = new Polynomial(1);
            pol2[0] = 1;
            pol2[1] = 3;

            var result = pol1 + pol2;

            Assert.AreEqual(new Polynomial(new double[] { 3, 7, 5 }),result);
        }
        [Test]
        public void TestPolynomialToString()
        {
            var pol = new Polynomial(new double[] {2, 4, 5});

            Assert.AreEqual("2 + 4 * x^1 + 5 * x^2", pol.ToString());
        }
    }
}
