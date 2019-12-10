using System;
using System.Text;

namespace Module08
{
    /// <summary>
    /// Izh-08-3. Encapsulation. Inheritance. Polymorphism
    /// </summary>
    public class Polynomial
    {
        private const double Eps = 0.000001;
        private readonly double[] coefficients;
        public int Length { get; }
        public int Degree { get; }

        public Polynomial(int degree)
        {
            coefficients = new double[degree + 1];
            Degree = degree;
            Length = degree + 1;
        }

        public Polynomial(double[] array)
        {
            Length = array.Length;
            Degree = Length - 1;
            coefficients = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                coefficients[i] = array[i];
            }
        }


        public double this[int index]
        {
            get => coefficients[index];
            set => coefficients[index] = value;
        }

        public static Polynomial operator +(Polynomial pol1, Polynomial pol2)
        {
            var maxLength = Math.Max(pol1.Length, pol2.Length);
            var minLength = Math.Min(pol1.Length, pol2.Length);
            var result = new Polynomial(maxLength - 1);
            for (int i = 0; i < minLength; i++)
            {
                result[i] = pol1[i] + pol2[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                result[i] = (pol1.Degree > pol2.Degree) ? pol1[i] : pol2[i];
            }

            return result;
        }

        public override string ToString()
        {
            var polynomialSb = new StringBuilder();
            if (Length > 0)
            {
                polynomialSb.Append(coefficients[0]);
            }
            else
            {
                return "0";
            }
            for (int i = 1; i < Length; i++)
            {
                polynomialSb.Append(" + " + coefficients[i] + " * x^" + i);
            }
            return polynomialSb.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Polynomial))
            {
                return false;
            }

            if (coefficients.Length != ((Polynomial) obj).coefficients.Length)
            {
                return false;
            }

            for (int i = 0; i < coefficients.Length; i++)
            {
                if (Math.Abs(coefficients[i] - ((Polynomial) obj).coefficients[i]) > Eps)
                {
                    return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return coefficients.GetHashCode();
        }
    }
}
