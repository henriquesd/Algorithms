namespace Algorithms.Strings
{
    public static class FirstUniqueCharacterInString
    {
        // Given a string s, find the first non-repeating character in it and return its index.
        // If it does not exist, return -1;
        public static int FirstUniqChar(string s)
        {
            // Dictionary to store the frequency of each character;
            Dictionary<char, int> charCount = new Dictionary<char, int>();
;
            // Iterate over the string to count the frequency of each character;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Iterate over the string again to find the first non-repeating character;
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i; // Return the index of the first non-repeating character;
                }
            }

            // If no non-repeating character is found, return -1;
            return -1;
        }
    }
}
