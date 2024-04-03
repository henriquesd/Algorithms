namespace Algorithms.Strings
{
    public static class Anagram
    {
        public static bool AreAnagram(string text1, string text2)
        {
            if (text1.ToLower().Equals(text2.ToLower())) return true;

            var array1 = text1.Replace(" ", "").ToLower().ToCharArray();
            var array2 = text2.Replace(" ", "").ToLower().ToCharArray();

            Array.Sort(array1);
            Array.Sort(array2);

            if (array1.Length != array2.Length) return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
