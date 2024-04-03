namespace Algorithms
{
    /// <summary>
    ///  Given two strings s and t, determine if they are isomorphic.
    ///  Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    /// </summary>
    public static class IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            HashSet<char> mapped = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char charS = s[i];
                char charT = t[i];

                if (dic.ContainsKey(charS))
                {
                    if (dic[charS] != charT) return false;
                }
                else
                {
                    if (mapped.Contains(charT)) return false;

                    dic[charS] = charT;
                    mapped.Add(charT);
                }
            }

            return true;
        }
    }
}
