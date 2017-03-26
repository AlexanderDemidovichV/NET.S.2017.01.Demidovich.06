using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Polynomial: ICloneable
    {
        #region Fields

        private double[] coefficients;

        private int power;

        private const float Precision = 0.0000001f;

        #endregion

        #region Properties

        public int Power => power;

        public double[] Coefficients => (double[])coefficients.Clone();

        #endregion  

        #region Constructors

        public Polynomial(double value)
        {
            this.coefficients = new double[1] {value};
            this.power = 0;
        }

        public Polynomial(double value1, double value2)
        {
            this.coefficients = new double[2] {value1, value2};
            this.power = 1;
        }

        public Polynomial(double value1, double value2, double value3)
        {
            this.coefficients = new double[3] { value1, value2, value3 };
            this.power = 2;
        }

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
                if (i == 0 || coefficients[i] != 0)
                {
                    this.power = i;
                    break;
                }
            this.coefficients = new double[power + 1];
            Array.Copy(coefficients, this.coefficients, power + 1);
        }

        #endregion

        #region Public Methods

        public object Clone()
        {
            return new Polynomial(this.coefficients);
        }

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

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Polynomial);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            int power = 0;
            for (int i = 0; i < coefficients.Length; i++)
            {
                result.AppendFormat($"{coefficients[i]}x^{power++}");
                if (i != coefficients.Length - 1) result.Append(" + ");
            }

            return result.ToString();
        }

        public static bool operator ==(Polynomial value1, Polynomial value2)
        {
            if (ReferenceEquals(value1, null) && ReferenceEquals(value2, null))
                return true;
            if (ReferenceEquals(value1, null) || ReferenceEquals(value2, null))
                return false;

            return value1.Equals(value1);
        }

        public static bool operator !=(Polynomial value1, Polynomial value2)
        {
            return !(value1 == value2);
        }

        public static Polynomial operator +(Polynomial value1, Polynomial value2)
        {
            if (value1 == null && value2 == null)
                return null;
            if (value1 == null)
                return new Polynomial(value2.coefficients);
            if (value2 == null)
                return new Polynomial(value1.coefficients);

            double[] resultCoefficients = (value1.power > value2.power) ? 
                (double[])value1.coefficients.Clone() : (double[])value2.coefficients.Clone();

            int resultPower = (value1.power > value2.power) ? value2.power : value1.power;

            for (int i = 0; i < resultPower + 1; i++)
                resultCoefficients[i] = value1.coefficients[i] + value2.coefficients[i];

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator -(Polynomial value1, Polynomial value2)
        {
            if (value1 == null && value2 == null)
                return null;
            if (value1 == null)
                return new Polynomial(value2.coefficients);
            if (value2 == null)
                return new Polynomial(value1.coefficients);

            return value1 + (-value2);
        }

        public static Polynomial operator -(Polynomial value)
        {
            if (value == null)
                return null;

            double[] resultCoefficients = new double[value.power + 1];
            for (int i = 0; i < resultCoefficients.Length; i++)
                resultCoefficients[i] = -value.coefficients[i];
            return new Polynomial(resultCoefficients);
        }

        public static Polynomial operator *(Polynomial value1, Polynomial value2)
        {
            if (value1 == null || value2 == null)
                return null;

            double[] resultCoefficients = new double[value1.power + 1 + value2.power + 1];

            for (int i = 0; i <= value1.power; i++)
                for (int j = 0; i <= value2.power; j++)
                    resultCoefficients[i + j] = value1.coefficients[i] * value2.coefficients[j];

            return new Polynomial(resultCoefficients);
        }

        public static Polynomial Add(Polynomial leftPoly, Polynomial rightPoly)
        {
            return leftPoly + rightPoly;
        }

        public static Polynomial Substract(Polynomial leftPoly, Polynomial rightPoly)
        {
            return leftPoly - rightPoly;
        }

        public static Polynomial Multiple(Polynomial leftPoly, Polynomial rightPoly)
        {
            return leftPoly * rightPoly;
        }

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

        #endregion
    }
}
