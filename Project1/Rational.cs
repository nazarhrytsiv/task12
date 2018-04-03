using System;


namespace MathSuite.Core.Numeric
{

    public class Rational
    {
        #region Static fields
        private const string NAN_LITERAL = "NaN";
        #endregion

        //Use Hungary anotation
        private readonly int _numerator, _denominator;

        #region Consturctors
        public Rational(int numerator) : this(numerator, 1) { }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException(NAN_LITERAL);
            }

            this._numerator = numerator;
            this._denominator = denominator;

            if (IsReduce())
            {
                int reduce_number = GCD();

                this._numerator /= reduce_number;
                this._denominator /= reduce_number;
            }
        }
        #endregion

        private bool IsReduce()
        {
            bool answer = false;
            if (GCD() > 1)
            {
                answer = true;
                return answer;
            }
            return answer;
        }

        private int GCD()
        {
            int answer = 1;
            int smallest = Math.Min(this._numerator, this._denominator);
            for (int i = smallest; i >= 2; i--)
            {
                if (this._numerator % i == 0 & _denominator % i == 0)
                {
                    answer = i;
                    return answer;
                }
            }
            return answer;
        }

        public string Print()
        {
            return _numerator.ToString() + "/" + _denominator.ToString();
        }

        public static Rational operator +(Rational first_number, Rational second_number)
        {
            if (first_number._denominator == second_number._denominator)
            {
                return new Rational(first_number._numerator + second_number._numerator, first_number._denominator);
            }
            else
            {
                return new Rational(first_number._numerator * second_number._denominator + second_number._numerator * first_number._denominator,
                    first_number._denominator * second_number._denominator);
            }
        }

        public static Rational operator -(Rational first_number, Rational second_number)
        {
            if (first_number._denominator == second_number._denominator)
            {
                return new Rational(first_number._numerator - second_number._numerator, first_number._denominator);
            }
            else
            {
                return new Rational(first_number._numerator * second_number._denominator - second_number._numerator * first_number._denominator,
                    first_number._denominator * second_number._denominator);
            }
        }

        public static Rational operator *(Rational first_number, Rational second_number)
        {
            return new Rational(first_number._numerator * second_number._numerator, first_number._denominator * second_number._denominator);
        }

        public static Rational operator /(Rational first_number, Rational second_number)
        {
            return new Rational(first_number._numerator * second_number._denominator, first_number._denominator * second_number._numerator);
        }
    }

}
    