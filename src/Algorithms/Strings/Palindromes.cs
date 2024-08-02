using System.Text;

namespace Algorithms.Strings
{
    // A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward.
    // Alphanumeric characters include letters and numbers.
    // Given a string s, return true if it is a palindrome, or false otherwise;
    public static class Palindromes
    {
        public static bool IsPalindrome(string str)
        {
            // Preprocess the string to remove non-alphanumeric characters and convert to lowercase;
            string cleaned = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Convert the cleaned string to a character array;
            char[] ch = cleaned.ToCharArray();

            // Reverse the character array
            Array.Reverse(ch);

            // Convert the reversed character array back to a string
            string reversed = new string(ch);

            // Compare the cleaned string with the reversed string
            return cleaned.Equals(reversed, StringComparison.OrdinalIgnoreCase);
        }

        public static bool IsPalindromeUsingLinq(string str)
        {
            // Preprocess the string to remove non-alphanumeric characters and convert to lowercase;
            var cleanedStr = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Check if the cleaned string is equal to its reverse;
            return cleanedStr.SequenceEqual(cleanedStr.Reverse());
        }

        public static bool IsPalindromeCompareWithReverse(string s)
        {
            string cleanedString = String.Empty;

            // Iterate over each character in the input string;
            foreach (char ch in s)
            {
                // Check if the character is alphanumeric;
                if (char.IsLetterOrDigit(ch))
                {
                    // Convert the character to lowercase and added it to the cleaned string;
                    cleanedString += char.ToLower(ch);
                }
            }

            char[] reversedChars = cleanedString.ToCharArray();
            
            Array.Reverse(reversedChars);
            
            string reversedString = new string(reversedChars);

            return cleanedString == reversedString;
        }

        public static bool IsPalindromeWithTwoPointers(string s)
        {
            // Initialize two pointers, one at the beginning and one at the end of the string;
            int i = 0;
            int j = s.Length - 1;

            // Iterate until the two pointers meet in the middle;
            while (i < j)
            {
                // Move the left pointer to the right while it points to a non-alphanumeric character;
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }

                // Move the right pointer to the left while it points to a non-alphanumeric character;
                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }

                // Compare the characters at the two pointers;
                // Convert both characters to lowercase to ensure the comparison is case-insensitive;
                if (char.ToLower(s[i]) != char.ToLower(s[j]))
                    return false; // If characters do not match, the string is not a palindrome;

                // Move the left pointer to the right and the right pointer to the left;
                i++;
                j--;
            }

            // If the loop completes without finding any mismatched characters, the string is a palindrome;
            return true;
        }

        public static bool IsPalindromeWithStringBuilder(string s)
        {
            // Use a StringBuilder to efficiently build the cleaned string;
            StringBuilder cleanedString = new StringBuilder();

            // Iterate over each character in the input string;
            foreach (char c in s)
            {
                // Check if the character is alphanumeric;
                if (char.IsLetterOrDigit(c))
                {
                    // Convert the character to lowercase and append to the cleaned string;
                    cleanedString.Append(char.ToLower(c));
                }
            }

            // Convert the cleaned StringBuilder to a string;
            string cleaned = cleanedString.ToString();

            // Get the reverse of the cleaned string;
            string reversed = Reverse(cleaned);

            // Compare the cleaned string with its reverse;
            return cleaned == reversed;
        }

        private static string Reverse(string s)
        {
            // Convert the string to a character array;
            char[] charArray = s.ToCharArray();
            
            // Reverse the character array;
            Array.Reverse(charArray);
            
            // Convert the reversed character array back to a string;
            return new string(charArray);
        }
    }
}