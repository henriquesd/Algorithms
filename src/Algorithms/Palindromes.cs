namespace Algorithms
{
    public static class Palindromes
    {
        public static bool IsPalindrome(string str)
        {
            string reversed;
            char[] ch = str.ToCharArray();

            Array.Reverse(ch);
            reversed = new string(ch);

            return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsPalindromeUsingLinq(string str)
        {
            return str.SequenceEqual(str.Reverse());
        }
    }
}
