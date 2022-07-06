using System;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public static class ReverseString
    {
        public static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string ReverseUsingLinq(string str)
        {
            return new string (str.Reverse().ToArray());
        }

        public static string? ReverseWithStringBuilder(string str)
        {
            if (string.IsNullOrEmpty(str?.Trim())) return null;

            StringBuilder reversedString = new StringBuilder(str.Length);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString.Append(str[i]);
            }

            return reversedString.ToString();
        }
    }
}
