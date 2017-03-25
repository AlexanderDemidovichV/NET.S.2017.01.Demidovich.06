using NUnit.Framework;

namespace Task1.Tests
{
    class PolynomialTests
    {
        [Test]
        public void Compute_12_457_Returns()
        {
            Polynomial a = new Polynomial(1, 2, 3);
            double x = 12;

            double expected = 457;

            double actual = a.Compute(x);

            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Compute_0_1_Returns()
        {
            Polynomial a = new Polynomial(1, 2, 3);
            double x = 0;

            double expected = 1;

            double actual = a.Compute(x);

            Assert.AreEqual(actual, expected);
        }
    }
}
