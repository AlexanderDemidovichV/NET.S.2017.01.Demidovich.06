using NUnit.Framework;

namespace Task1.Tests
{
    class PolynomialTests
    {

        [Test]
        public void Equals_oneObject_true_Returned()
        {

            Polynomial a = new Polynomial(1, 2, 3, 4, 5);
            bool expected = true;

            bool actual = a.Equals(a);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Equals_objAndNull_false_Returned()
        {

            Polynomial a = new Polynomial(1, 2, 3, 4, 5);
            bool expected = false;

            bool actual = a.Equals(null);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Equals_equalObjects_true_Returned()
        {

            Polynomial a = new Polynomial(1, 2, 3, 4, 5),
                       b = new Polynomial(1, 2, 3, 4, 5);
            bool expected = true;

            bool actual = a.Equals(b);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Equals_differentObjects_false_Returned()
        {
            Polynomial a = new Polynomial(1, 2, 3, 4, 5),
                       b = new Polynomial(2, 2, 3, 4, 5);
            bool expected = false;

            bool actual = a.Equals(b);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Add_12_457_Returns()
        {
            Polynomial a = new Polynomial(1, 2, -3, 4, 5, 6),
                       b = new Polynomial(2, 3, 4, 5, 6);
            Polynomial expected = new Polynomial(3, 5, 1, 9, 11, 6);

            Polynomial actual = a + b;

            Assert.IsTrue(actual.Equals(expected));
        }

        [Test]
        public void Compute_12_457_Returns()
        {
            Polynomial a = new Polynomial(1, 2, 3);
            double x = 12;

            double expected = 457;

            double actual = a.Compute(x);

            Assert.AreEqual(expected, actual);
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

        [Test]
        public void ToString_0_1_Returns()
        {
            Polynomial a = new Polynomial(1, -2, 3);

            string expected = "1x^0 + -2x^1 + 3x^2";

            string actual = a.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToString_Returns()
        {
            Polynomial a = new Polynomial(4, 2, 3, 4);

            string expected = "4x^0 + 2x^1 + 3x^2 + 4x^3";

            string actual = a.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
