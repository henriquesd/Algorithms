namespace Algorithms.Arrays
{
    // You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer.
    // The digits are ordered from most significant to least significant in left-to-right order.
    // The large integer does not contain any leading 0's.
    // Increment the large integer by one and return the resulting array of digits;
    public static class PlusOne
    {
        public static int[] Execute(int[] digits)
        {
            // Iterate through the array from the end (least significant digit) to the beginning (most significant digit);
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                // If the current digit is less than 9, increment it by one;
                if (digits[i] < 9)
                {
                    digits[i]++;

                    // Return the array immediately since there's no carry-over needed;
                    return digits;
                }

                // If the current digit is 9, it becomes 0 and we need to carry over 1 to the next significant digit;
                digits[i] = 0;
            }

            // If all the digits were 9, we need to handle the overflow by adding an extra digit;
            // Create a new array with one additional length, all elements initialized to 0;
            int[] result = new int[digits.Length + 1];

            // Set the most significant digit to 1 (e.g., 999 + 1 = 1000);
            result[0] = 1;

            return result;
        }
    }
}