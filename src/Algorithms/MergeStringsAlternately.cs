using System.Text;

namespace Algorithms
{
    /// <summary>
    /// You are given two strings word1 and word2.
    /// Merge the strings by adding letters in alternating order, starting with word1.
    /// If a string is longer than the other, append the additional letters onto the end of the merged string.
    /// Return the merged string.
    /// </summary>
    public static class MergeStringsAlternately
    {
        // Two Pointers approach;

        public static string MergeAlternately(string word1, string word2)
        {
            int n1 = word1.Length;
            int n2 = word2.Length;
            StringBuilder result = new StringBuilder();

            int p1 = 0;
            int p2 = 0;

            while (p1 < n1 || p2 < n2)
            {
                if (p1 < n1)
                {
                    result.Append(word1[p1]);
                    p1++;
                }
                if (p2 < n2)
                {
                    result.Append(word2[p2]);
                    p2++;
                }
            }

            return result.ToString();
        }
    }
}
