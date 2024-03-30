namespace Algorithms
{
    /// <summary>
    /// Given an integer num, return the number of steps to reduce it to zero.
    // In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.
    /// </summary>
    public static class ReduceNumberToZero
    {
        public static int NumberOfStepsExample1(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                bool isNumberEven = num % 2 == 0;

                if (isNumberEven)
                {
                    num = num / 2;
                    steps++;
                }
                else
                {
                    num = num - 1;
                    steps++;
                }
            }

            return steps;
        }

        public static int NumberOfStepsExample2(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                }
                else
                {
                    num--;
                }
             
                steps++;
            }

            return steps;
        }

        public static int NumberOfStepsExample3(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                steps++;
                num = (num % 2 == 0) ? num / 2 : num - 1;
            }

            return steps;
        }

        public static int NumberOfStepsBitwiseApproach(int num)
        {
            int steps = 0;

            while (num > 0)
            {
                // The bitwise operation looks at the binary representation of num, and not the decimal value;
                // An odd number in binary always has the rightmost value of 1,
                // and an even number in binary always has the rightmost value of 0.
                if ((num & 1) == 0)
                {
                    num = num >> 1;
                }
                else
                {
                    num--;
                }

                steps++;
            }

            return steps;
        }
    }
}
