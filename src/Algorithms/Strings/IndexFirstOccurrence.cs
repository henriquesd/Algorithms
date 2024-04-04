namespace Algorithms.Strings
{
    /// <summary>
    /// Given two strings needle and haystack,
    /// return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    /// </summary>
    public static class IndexFirstOccurrence
    {
        public static int StrStrDemo1(string haystack, string needle)
        {
            var length = haystack.Length;

            if (haystack.Contains(needle))
            {
                for (int i = 0; i <= length; i++)
                {
                    if (haystack.StartsWith(needle))
                    {
                        return i;
                    }
                    else
                    {
                        haystack = haystack.Remove(0, 1);
                    }
                }
            }

            return -1;
        }

        public static int StrStrDemo2(string haystack, string needle)
        {
            int haystackLength = haystack.Length;
            int needleLength = needle.Length;

            for (int i = 0; i <= haystackLength - needleLength; i++)
            {
                if (haystack.Substring(i, needleLength) == needle)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int StrStrDemo3(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }

        public static int StrStrDemo4(string haystack, string needle)
        {
            int haystackLength = haystack.Length;
            int needleLength = needle.Length;

            for(int windowStart = 0; windowStart <= haystackLength - needleLength; windowStart++)
            {
                for (int i = 0; i < needleLength; i++)
                {
                    if (needle[i] != haystack[windowStart + i])
                    {
                        break;
                    }
                    if (i == needleLength - 1)
                    {
                        return windowStart;
                    }
                }
            }
            
            return -1;
        }
    }
}