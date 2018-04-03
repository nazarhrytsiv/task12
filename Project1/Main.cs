using System;
using System.Collections.Generic;


namespace MathSuite.Core.Numeric
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Rational> array = new List<Rational>();
            string numerator;
            string denominator;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} Number", i + 1);
                numerator = Console.ReadLine();
                denominator = Console.ReadLine();
                array.Add(new Rational(Convert.ToInt32(numerator), Convert.ToInt32(denominator)));
            }
            Rational result = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                result += array[i];
            }
            Console.WriteLine(result.Print());

            result = array[0];

            for (int i = 1; i < array.Count; i++)
            {
                result *= array[i];
            }
            Console.WriteLine(result.Print());


            Console.ReadKey();
        }
    }
}