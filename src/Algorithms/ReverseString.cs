using System;
using System.Linq;

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
    }
}
