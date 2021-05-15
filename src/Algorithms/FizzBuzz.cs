using System;

namespace Algorithms
{
    public static class FizzBuzz
    {
        /// <summary>
        /// This function will print the numbers from 1 to n,
        /// but for multiples of three, will print "fizz" instead of the number
        /// and for the multiples of five will print "buzz",
        /// for numbers which are multiples of both three and five will print "fizzbuzz".
        /// </summary>
        /// <param name="numberUpTo"></param>
        /// <returns></returns>
        public static void Execute(int numberUpTo)
        {
            for (int i = 1; i <= numberUpTo; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                } else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                } else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
