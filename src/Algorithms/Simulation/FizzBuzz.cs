using System.Text;

namespace Algorithms.Simulation
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
        public static void ExecuteExample1(int numberUpTo)
        {
            for (int i = 1; i <= numberUpTo; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void ExecuteExample2(int numberUpTo)
        {
            Dictionary<int, string> fizzBuzzValues = new Dictionary<int, string>();
            fizzBuzzValues.Add(3, "fizz");
            fizzBuzzValues.Add(5, "buzz");

            for (int i = 1; i <= numberUpTo; i++)
            {
                string output = "";

                foreach (var item in fizzBuzzValues)
                {
                    if (i % item.Key == 0)
                    {
                        output += item.Value;
                    }
                }

                if (output == "")
                {
                    output = i.ToString();
                }

                Console.WriteLine(output);
            }
        }

        /// <summary>
        /// By using binary values and bitwise operations, the code can efficiently combine the Fizz, Buzz, and FizzBuzz flags to determine
        ///   the correct output value for each number in the loop. This can lead to better performance compared to other implementations
        ///   that use string comparisons or multiple if statements to determine the output value.
        /// </summary>
        /// <param name="numberUpTo"></param>
        public static void ExecuteExample3(int numberUpTo)
        {
            // Fizz is defined as 0x1, which is a hexadecimal literal that represents the binary value 00000001. This value represents the Fizz flag;
            const int Fizz = 0x1;

            // Buzz is defined as 0x2, which is a hexadecimal literal that represents the binary value 00000010. This value represents the Buzz flag;
            const int Buzz = 0x2;

            // FizzBuzz is defined as Fizz | Buzz, which is a bitwise OR operation between the Fizz and Buzz constants.
            // The resulting value is 0x3, which is a hexadecimal literal that represents the binary value 00000011. This value represents the FizzBuzz flag;
            const int FizzBuzz = Fizz | Buzz;

            const string FizzStr = "fizz";
            const string BuzzStr = "buzz";
            const string FizzBuzzStr = "fizzbuzz";

            // The * 8 in the line var output = new StringBuilder(numberUpTo * 8) is used to pre-allocate the initial capacity
            // of the StringBuilder object to improve performance. The max INT value is 2147483647 (which contains 10 characteres);
            var output = new StringBuilder(numberUpTo * 10);

            for (int i = 1; i <= numberUpTo; i++)
            {
                // code is be a bitwise combination of Fizz, Buzz, and FizzBuzz 
                int code = (i % 3 == 0 ? Fizz : 0) | (i % 5 == 0 ? Buzz : 0);

                string value = code switch
                {
                    Fizz => FizzStr,
                    Buzz => BuzzStr,
                    FizzBuzz => FizzBuzzStr,
                    _ => i.ToString()
                };

                output.Append(value);
                output.Append('\n');
            }

            Console.Write(output.ToString());
        }
    }
}
