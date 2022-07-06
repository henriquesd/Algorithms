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

        public static string? ReverseEachWord(string str)
        {
            if (string.IsNullOrEmpty(str?.Trim())) return null;

            StringBuilder reversedString = new StringBuilder(str.Length);

            String[] arr = str.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                reversedString.Append(Reverse(arr[i]));

                // If it is the last word, should not add extra space;
                if (i != arr.Length -1)
                {
                    reversedString.Append(" ");
                }
            }

            return reversedString.ToString();
        }
    }
}
