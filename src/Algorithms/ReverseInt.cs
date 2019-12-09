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
    }
}
