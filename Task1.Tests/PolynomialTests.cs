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
        public void ToString_negativeCoef_Returns()
        {
            Polynomial a = new Polynomial(1, -2, 3);

            string expected = "1x^0 + -2x^1 + 3x^2";

            string actual = a.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToString_positiveCoefs_Returns()
        {
            Polynomial a = new Polynomial(4, 2, 3, 4);

            string expected = "4x^0 + 2x^1 + 3x^2 + 4x^3";

            string actual = a.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ToString_nullCoef_Returns()
        {
            Polynomial a = new Polynomial(4, 0, 3, 4);

            string expected = "4x^0 + 3x^2 + 4x^3";

            string actual = a.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void OperatorPlus_positiveValues()
        {

            Polynomial a = new Polynomial(1, 2, 3, 4, 5, 6),
                       b = new Polynomial(2, 3, 4, 5, 6);
            Polynomial expected = new Polynomial(3, 5, 7, 9, 11, 6);

            Polynomial actual = a + b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorPlus_negativeValues()
        {

            Polynomial a = new Polynomial(-1, -2, -3, -4, -5, -6),
                       b = new Polynomial(2, 3, 4, 5, 6);
            Polynomial expected = new Polynomial(1, 1, 1, 1, 1, -6);

            Polynomial actual = a + b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorPlus_oneNullValue()
        {

            Polynomial a = new Polynomial(-1, -2, -3, -4, -5, -6),
                       b = null;
            Polynomial expected = new Polynomial(-1, -2, -3, -4, -5, -6);

            Polynomial actual = a + b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorPlus_twoNullValues()
        {

            Polynomial a = null,
                       b = null;
            Polynomial expected = null;

            Polynomial actual = a + b;

            Assert.IsTrue(actual == expected);

        }

        [Test]
        public void OperatorUnaryMinus_positiveValues()
        {

            Polynomial a = new Polynomial(1, 2, 3, 4, 5, 6);
            Polynomial expected = new Polynomial(-1, -2, -3, -4, -5, -6);

            Polynomial actual = -a;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorUnaryMinus_negativeValues()
        {

            Polynomial a = new Polynomial(-1, -2, -3, -4, -5, -6);
            Polynomial expected = new Polynomial(1, 2, 3, 4, 5, 6);

            Polynomial actual = -a;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorUnaryMinus_nullValue()
        {

            Polynomial a = null;
            Polynomial expected = null;

            Polynomial actual = -a;

            Assert.IsTrue(actual == expected);

        }

        [Test]
        public void OperatorMinus_positiveValues()
        {

            Polynomial a = new Polynomial(1, 2, 3, 4, 5, 6),
                       b = new Polynomial(2, 3, 4, 5, 6);
            Polynomial expected = new Polynomial(-1, -1, -1, -1, -1, 6);

            Polynomial actual = a - b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorMinus_negativeValues()
        {

            Polynomial a = new Polynomial(-1, -2, -3, -4, -5, -6),
                       b = new Polynomial(-2, -3, -4, -5, -6);
            Polynomial expected = new Polynomial(1, 1, 1, 1, 1, -6);

            Polynomial actual = a - b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorMinus_oneNullValue()
        {

            Polynomial a = new Polynomial(-1, -2, -3, -4, -5, -6),
                       b = null;
            Polynomial expected = new Polynomial(-1, -2, -3, -4, -5, -6);

            Polynomial actual = a - b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorMinus_twoNullValues()
        {

            Polynomial a = null,
                       b = null;
            Polynomial expected = null;

            Polynomial actual = a - b;

            Assert.IsTrue(actual == expected);

        }

        [Test]
        public void OperatorСomposition_positiveValues()
        {

            Polynomial a = new Polynomial(1, 2, 3),
                       b = new Polynomial(2, 3);
            Polynomial expected = new Polynomial(2, 7, 12, 9);

            Polynomial actual = a * b;

            Assert.IsTrue(actual.Equals(expected));

        }

        [Test]
        public void OperatorСomposition_negativeValues()
        {

            Polynomial a = new Polynomial(-1, -2, -3),
                       b = new Polynomial(2, 3);
            Polynomial expected = new Polynomial(-2, -7, -12, -9);

            Polynomial actual = a * b;

            Assert.IsTrue(actual.Equals(expected));

        }

    }
}
