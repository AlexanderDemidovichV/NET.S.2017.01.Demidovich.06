using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Polynomial: ICloneable
    {
        private double[] coefficients;

        private int power;

        public Polynomial(params double[] coefficients)
        {
            if (coefficients == null)
                throw new ArgumentNullException(nameof(coefficients));



            this.coefficients = coefficients;
            power = coefficients.Length;
        }

        public object Clone()
        {
            return new Polynomial(this.coefficients);
        }

        public double Compute(double x)
        {
            double result = 0;

            for (int i = power - 1; i >= 0; i--)
                result = result * x + coefficients[i];

            return result;
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

            for (int i = 0; i < resultPower; i++)
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
    }
}
