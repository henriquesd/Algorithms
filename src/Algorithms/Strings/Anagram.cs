namespace Algorithms.Strings
{
    public static class Anagram
    {
        public static bool IsAnagram1(string word1, string word2)
        {
            if (word1.ToLower().Equals(word2.ToLower())) return true;

            var array1 = word1.Replace(" ", "").ToLower().ToCharArray();
            var array2 = word2.Replace(" ", "").ToLower().ToCharArray();
            
            if (array1.Length != array2.Length) return false;

            Array.Sort(array1);
            Array.Sort(array2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsAnagram2(string word1, string word2)
        {
            if (word1.ToLower().Equals(word2.ToLower())) return true;

            char[] chars1 = word1.Replace(" ", "").ToLower().ToCharArray();
            char[] chars2 = word2.Replace(" ", "").ToLower().ToCharArray();
            
            if (chars1.Length != chars2.Length) return false;

            Array.Sort(chars1);
            Array.Sort(chars2);

            var str1 = new string(chars1);
            var str2 = new string(chars2);
            
            return str1.Equals(str2);
        }

        public static bool IsAnagram3(string word1, string word2)
        {
            if (word1.ToLower().Equals(word2.ToLower())) return true;

            var updatedWord1 = word1.Replace(" ", "").ToLower().ToCharArray();
            var updatedWord2 = word2.Replace(" ", "").ToLower().ToCharArray();

            if (updatedWord1.Length != updatedWord2.Length) return false;

            int[] counter = new int[26];

            for (int i = 0; i < updatedWord1.Length; i++)
            {
                counter[updatedWord1[i] - 'a']++;
                counter[updatedWord2[i] - 'a']--;
            }

            foreach (int count in counter)
            {
                if (count != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
