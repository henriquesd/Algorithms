namespace Algorithms.Strings
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            int reversed = 0;

            while (x != 0)
            {
                // Extract the last digit of x;
                int pop = x % 10;

                // "x" is divided by "10", to remove the last digit from x;
                x /= 10;

                // Check for overflow before actually reversing;
                if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && pop > 7)) // int.MaxValue is 2147483647, and the last digit 7 must be taken into account;
                {
                    return 0;
                }
                if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && pop < -8)) // int.MinValue is -2147483648, and the last digit -8 must be taken into account;
                {
                    return 0;
                }

                // Push the digit to the reversed number;
                reversed = reversed * 10 + pop;
            }

            return reversed;
        }
    }
}