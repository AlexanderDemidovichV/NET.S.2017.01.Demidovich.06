using System;
using System.Text;
using System.Configuration;

namespace Task1
{
    /// <summary>
    /// Represents immutable polinomials.
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public class Polynomial: ICloneable
    {
        #region Fields

        private readonly double[] coefficients;

        private readonly int power;

        private static readonly double epsilon;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the power of <see cref="Polynomial"/>.
        /// </summary>
        public int Power => power;

        /// <summary>
        /// Gets the epsilon of <see cref="Polynomial"/>.
        /// </summary>
        public double Epsilon => epsilon;
        #endregion  

        #region Constructors

        static Polynomial()
        {
            try
            {
                epsilon = double.Parse(ConfigurationManager.AppSettings["epsilon"]);
            }
            catch (ConfigurationErrorsException ex)
            {
                throw new ConfigurationErrorsException("Can't get epsilon value", ex);
            }
            catch (Exception ex)
            {
                throw new ConfigurationErrorsException("epsilon has an invalid value", ex);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Polynomial"/> class that is spcified by coefficients.
        /// </summary>
        /// <param name="coefficients">Coefficients of polynomial, index is power of polinomal element.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="coefficients"/> is null</exception>
        public Polynomial(params double[] coefficients)
        {
            if (ReferenceEquals(coefficients, null))
                throw new ArgumentNullException(nameof(coefficients));

            if (coefficients.Length == 0)
            {
                this.power = 0;
                this.coefficients = null;
                return;
            }

            this.power = coefficients.Length - 1;
            for (int i = coefficients.Length - 1; i >= 0; i--)
                if (i == 0 || Math.Abs(coefficients[i]) > epsilon)
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
                if (Math.Abs(this.coefficients[i] - polynomial.coefficients[i]) > epsilon)
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
                if (Math.Abs(coefficients[i]) < epsilon)
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
        /// <param name="lhs">The first <see cref="Polynomial"/> to compare.</param>
        /// <param name="rhs">The second <see cref="Polynomial"/> to compare.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public static bool operator ==(Polynomial lhs, Polynomial rhs)
        {
            if (ReferenceEquals(lhs, null) && ReferenceEquals(rhs, null))
                return true;
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
                return false;

            return lhs.Equals(lhs);
        }

        /// <summary>
        /// Determines whether the specified <see cref="Polynomial"/> instances are considered not equal.
        /// </summary>
        /// <param name="lhs">The first <see cref="Polynomial"/> to compare.</param>
        /// <param name="rhs">The second <see cref="Polynomial"/> to compare.</param>
        /// <returns>
        /// <c>false</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>true</c>.
        /// </returns>
        public static bool operator !=(Polynomial lhs, Polynomial rhs) => !(lhs == rhs);

        public static Polynomial operator +(Polynomial lhs, Polynomial rhs)
        {
            if (ReferenceEquals(lhs, null) && ReferenceEquals(rhs, null))
                return null;
            if (ReferenceEquals(lhs, null))
                return new Polynomial(rhs.coefficients);
            if (ReferenceEquals(rhs, null))
                return new Polynomial(lhs.coefficients);

            double[] resultCoefficients = (lhs.power > rhs.power) ? 
                (double[])lhs.coefficients.Clone() : (double[])rhs.coefficients.Clone();

            int resultPower = (lhs.power > rhs.power) ? rhs.power : lhs.power;

            for (int i = 0; i < resultPower + 1; i++)
                resultCoefficients[i] = lhs.coefficients[i] + rhs.coefficients[i];

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator -(Polynomial lhs, Polynomial rhs)
        {
            if (ReferenceEquals(lhs, null) && ReferenceEquals(rhs, null))
                return null;
            if (ReferenceEquals(lhs, null))
                return new Polynomial(rhs.coefficients);
            if (ReferenceEquals(rhs, null))
                return new Polynomial(lhs.coefficients);

            return lhs + (-rhs);
        }

        public static Polynomial operator -(Polynomial pl)
        {
            if (ReferenceEquals(pl, null))
                return null;

            double[] resultCoefficients = new double[pl.power + 1];
            for (int i = 0; i < resultCoefficients.Length; i++)
                resultCoefficients[i] = -pl.coefficients[i];
            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator *(Polynomial lhs, Polynomial rhs)
        {
            if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
                return null;

            double[] resultCoefficients = new double[lhs.power + 1 + rhs.power + 1];

            for (int i = 0; i <= lhs.power; i++)
                for (int j = 0; j <= rhs.power; j++)
                    resultCoefficients[i + j] += lhs.coefficients[i] * rhs.coefficients[j];

            return new Polynomial(resultCoefficients);
        }

        /// <summary>
        /// Adds the specified <paramref name="lhs"/> with <paramref name="rhs"/>.
        /// </summary>
        /// <param name="lhs">The left <see cref="Polynomial"/>.</param>
        /// <param name="rhs">The right <see cref="Polynomial"/>.</param>
        /// <returns>Returns result of addition</returns>
        public static Polynomial Add(Polynomial lhs, Polynomial rhs) => lhs + rhs;

        /// <summary>
        /// Substracts the specified <paramref name="lhs"/> from <paramref name="rhs"/>.
        /// </summary>
        /// <param name="lhs">The left <see cref="Polynomial"/>.</param>
        /// <param name="rhs">The right <see cref="Polynomial"/>.</param>
        /// <returns>Returns result of subtraction.</returns>
        public static Polynomial Subtract(Polynomial lhs, Polynomial rhs) => lhs - rhs;

        /// <summary>
        /// Multiplies the specified <paramref name="lhs"/> with <paramref name="rhs"/>.
        /// </summary>
        /// <param name="lhs">The left <see cref="Polynomial"/>.</param>
        /// <param name="rhs">The right <see cref="Polynomial"/>.</param>
        /// <returns>Returns result of multiplication</returns>
        public static Polynomial Multiply(Polynomial lhs, Polynomial rhs) => lhs * rhs;

        public double this[int power]
        {
            get
            {
                if (power < 0)
                    throw new ArgumentOutOfRangeException
                        ($"{nameof(power)} cannot be less than zero");
                if (power > this.power)
                    return 0;
                return coefficients[power];
            }
        }
        #endregion
    }
}
