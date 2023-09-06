namespace Algorithms
{
    public static class ReverseInt
    {

        public static int Reverse(int number)
        {
            int reverse = 0, rem;
            while (number != 0)
            {
                rem = number % 10;
                reverse = reverse * 10 + rem;
                number /= 10;
            }
            return reverse;
        }

        public static int ReverseWithString(int number)
        {
            var numberString = Convert.ToString(number);
            
            var result = "";

            if (numberString.Contains("-"))
            {
                numberString = numberString.Replace("-", "");
                result = "-";
            }

            char[] stringArray = numberString.ToCharArray();
            Array.Reverse(stringArray);

            foreach (char c in stringArray)
            {
                result += c;    
            }
            
            return Convert.ToInt32(result);
        }

        public static int ReverseExample3(int number)
        {
            int result = 0;

            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                // Check for integer overflow/underflow
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                {
                    return 0; // Overflow will occur
                }
                if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8))
                {
                    return 0; // Underflow will occur
                }

                result = result * 10 + digit;
            }

            return result;
        }



    }
}
