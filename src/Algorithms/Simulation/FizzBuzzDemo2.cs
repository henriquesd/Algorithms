namespace Algorithms.Simulation
{
    /// <summary>
    /// Given an number, it returns an array of string, with numbers and values based on FizzBuzz game;
    /// </summary>
    public static class FizzBuzzDemo2
    {
        public static IList<string> FizzBuzzExample1(int n)
        {
            string[] result = new string[n];

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i - 1] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i - 1] = "Buzz";
                }
                else
                {
                    result[i - 1] = i.ToString();
                }
            }

            return result;
        }

        public static IList<string> FizzBuzzExample2(int n)
        {
            string[] result = new string[n];

            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;

                if (divisibleBy3 && divisibleBy5)
                {
                    result[i - 1] = "FizzBuzz";
                }
                else if (divisibleBy3)
                {
                    result[i - 1] = "Fizz";
                }
                else if (divisibleBy5)
                {
                    result[i - 1] = "Buzz";
                }
                else
                {
                    result[i - 1] = i.ToString();
                }
            }

            return result;
        }

        public static IList<string> FizzBuzzExample3(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }

        public static IList<string> FizzBuzzExample4(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;
                var currentString = "";

                if (divisibleBy3)
                {
                    currentString = "Fizz";
                }

                if (divisibleBy5)
                {
                    currentString += "Buzz";
                }

                if (currentString == string.Empty)
                {
                    currentString += i.ToString();
                }

                result.Add(currentString);
            }

            return result;
        }
    }
}
