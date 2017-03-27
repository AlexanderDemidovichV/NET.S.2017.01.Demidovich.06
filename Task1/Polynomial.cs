using System;
using System.Text;

namespace Task1
{
    /// <summary>
    /// Represents polinomials.
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class Polynomial: ICloneable
    {
        #region Fields

        private readonly double[] coefficients;

        private readonly int power;

        private const float Precision = 0.0000001f;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the power of <see cref="Polynomial"/>.
        /// </summary>
        public int Power => power;

        /// <summary>
        /// Coefficients of <see cref="Polynomial"/>, index is power of <see cref="Polynomial"/> element.
        /// </summary>
        public double[] Coefficients => (double[])coefficients.Clone();

        #endregion  

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the zero-degree <see cref="Polynomial"/> class that is specified by coefficient.
        /// </summary>
        /// <param name="value">Coefficient of zero-degree polynomial.</param>
        public Polynomial(double value)
        {
            this.coefficients = new double[1] {value};
            this.power = 0;
        }

        /// <summary>
        /// Initializes a new instance of the first-degree <see cref="Polynomial"/> that is specified by coefficients.
        /// </summary>
        /// <param name="value1">First coefficient of first-degree polynomial.</param>
        /// <param name="value2">Second coefficient of first-degree polynomial.</param>
        public Polynomial(double value1, double value2)
        {
            this.coefficients = new double[2] {value1, value2};
            this.power = 1;
        }

        /// <summary>
        /// Initializes a new instance of the first-degree <see cref="Polynomial"/> that is specified by coefficients
        /// </summary>
        /// <param name="value1">First coefficient of third-degree polynomial</param>
        /// <param name="value2">Second coefficient of first-degree polynomial.</param>
        /// <param name="value3">Third coefficient of third-degree polynomial.</param>
        public Polynomial(double value1, double value2, double value3)
        {
            this.coefficients = new double[3] { value1, value2, value3 };
            this.power = 2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polynomial"/> class that is spcified by coefficients.
        /// </summary>
        /// <param name="coefficients">Coefficients of polynomial, index is power of polinomal element.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="coefficients"/> is null</exception>
        public Polynomial(params double[] coefficients)
        {
            if (coefficients == null)
                throw new ArgumentNullException(nameof(coefficients));

            if (coefficients.Length == 0)
            {
                this.power = 0;
                this.coefficients = null;
                return;
            }

            this.power = coefficients.Length - 1;
            for (int i = coefficients.Length - 1; i >= 0; i--)
                if (i == 0 || Math.Abs(coefficients[i]) > Precision)
                {
                    this.power = i;
                    break;
                }
            this.coefficients = new double[power + 1];
            Array.Copy(coefficients, this.coefficients, power + 1);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Computes polynomial with specified number.
        /// </summary>
        /// <param name="x">A specified number.</param>
        /// <returns></returns>
        public double Compute(double x)
        {
            double result = 0;

            for (int i = power; i >= 0; i--)
            {
                result *= x;
                result += coefficients[i];
            }
            return result;
        }

        /// <summary>
        /// Determines whether this instance and object which must be also <see cref="Polynomial"/>, have same value.
        /// </summary>
        /// <param name="polynomial"><see cref="Polynomial"/> to compare with the current <see cref="Polynomial"/>.</param>
        /// <returns> 
        /// <c>true</c> if the specified <see cref="Polynomial"/> is equal to the current object; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(Polynomial polynomial)
        {
            if (ReferenceEquals(polynomial, null)) return false;
            if (ReferenceEquals(this, polynomial)) return true;
            if (this.power != polynomial.Power) return false;

            for (int i = 0; i < this.power; i++)
                if (Math.Abs(this.coefficients[i] - polynomial.coefficients[i]) > Precision)
                    return false;

            return true;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) => this.Equals(obj as Polynomial);

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode() => this.ToString().GetHashCode();

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object Clone() => new Polynomial(this.coefficients);

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this <see cref="Polynomial"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this <see cref="Polynomial"/>.
        /// </returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            int power = 0;
            for (int i = 0; i < coefficients.Length; i++)
            {
                if (Math.Abs(coefficients[i]) < Precision)
                {
                    power++;
                    continue;
                }
                result.AppendFormat($"{coefficients[i]}x^{power++}");
                if (i != coefficients.Length - 1) result.Append(" + ");
            }

            return result.ToString();
        }

        /// <summary>
        /// Determines whether the specified <see cref="Polynomial"/> instances are considered equal.
        /// </summary>
        /// <param name="leftPl">The first <see cref="Polynomial"/> to compare.</param>
        /// <param name="rightPl">The second <see cref="Polynomial"/> to compare.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(Polynomial leftPl, Polynomial rightPl)
        {
            if (ReferenceEquals(leftPl, null) && ReferenceEquals(rightPl, null))
                return true;
            if (ReferenceEquals(leftPl, null) || ReferenceEquals(rightPl, null))
                return false;

            return leftPl.Equals(leftPl);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Polynomial"/> instances are considered not equal.
        /// </summary>
        /// <param name="leftPl">The first <see cref="Polynomial"/> to compare.</param>
        /// <param name="rightPl">The second <see cref="Polynomial"/> to compare.</param>
        /// <returns>
        /// <c>false</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>true</c>.
        /// </returns>
        public static bool operator !=(Polynomial leftPl, Polynomial rightPl) => !(leftPl == rightPl);

        public static Polynomial operator +(Polynomial leftPl, Polynomial rightPl)
        {
            if (leftPl == null && rightPl == null)
                return null;
            if (leftPl == null)
                return new Polynomial(rightPl.coefficients);
            if (rightPl == null)
                return new Polynomial(leftPl.coefficients);

            double[] resultCoefficients = (leftPl.power > rightPl.power) ? 
                (double[])leftPl.coefficients.Clone() : (double[])rightPl.coefficients.Clone();

            int resultPower = (leftPl.power > rightPl.power) ? rightPl.power : leftPl.power;

            for (int i = 0; i < resultPower + 1; i++)
                resultCoefficients[i] = leftPl.coefficients[i] + rightPl.coefficients[i];

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator -(Polynomial leftPl, Polynomial rightPl)
        {
            if (leftPl == null && rightPl == null)
                return null;
            if (leftPl == null)
                return new Polynomial(rightPl.coefficients);
            if (rightPl == null)
                return new Polynomial(leftPl.coefficients);

            return leftPl + (-rightPl);
        }

        public static Polynomial operator -(Polynomial pl)
        {
            if (pl == null)
                return null;

            double[] resultCoefficients = new double[pl.power + 1];
            for (int i = 0; i < resultCoefficients.Length; i++)
                resultCoefficients[i] = -pl.coefficients[i];
            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator *(Polynomial leftPl, Polynomial rightPl)
        {
            if (leftPl == null || rightPl == null)
                return null;

            double[] resultCoefficients = new double[leftPl.power + 1 + rightPl.power + 1];

            for (int i = 0; i <= leftPl.power; i++)
                for (int j = 0; j <= rightPl.power; j++)
                    resultCoefficients[i + j] += leftPl.coefficients[i] * rightPl.coefficients[j];

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial Add(Polynomial leftPl, Polynomial rightPl) => leftPl + rightPl;

        public static Polynomial Substract(Polynomial leftPl, Polynomial rightPl) => leftPl - rightPl;

        public static Polynomial Multiple(Polynomial leftPl, Polynomial rightPl) => leftPl * rightPl;

        #endregion
    }
}
