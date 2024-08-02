using Algorithms.Strings;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class PalindromesTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void IsPalindrome_ShouldReturnTrueOrFalse_IfWordIsPalindrome(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindrome(str);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void IsPalindromeUsingLinq_ShouldReturnTrueOrFalse_IfWordIsPalindrome(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindromeUsingLinq(str);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void IsPalindromeCompareWithReverse_ShouldReturnTrueOrFalse(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindromeCompareWithReverse(str);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void IsPalindromeWithTwoPointers_ShouldReturnTrueOrFalse(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindromeWithTwoPointers(str);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void IsPalindromeWithStringBuilder_ShouldReturnTrueOrFalse(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindromeWithStringBuilder(str);

            Assert.Equal(expectedValue, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { "A man, a plan, a canal: Panama", true }; // Test case 1: Palindrome with special characters and mixed case;
            yield return new object[] { "race a car", false }; // Test case 2: Not a palindrome;
            yield return new object[] { "", true }; // Test case 3: Empty string (considered a palindrome);
            yield return new object[] { "a", true }; // Test case 4: Single character string (considered a palindrome);
            yield return new object[] { " ", true }; // Test case 5: String with spaces only (considered a palindrome);
            yield return new object[] { "12321", true }; // Test case 6: String with alphanumeric characters only;
            yield return new object[] { "1a2", false }; // Test case 7: String with mixed characters and spaces;
            yield return new object[] { "abba", true };  // Test case 8: Simple palindrome with only letters;
            yield return new object[] { "abcdefg", false }; // Test case 9: String that is not a palindrome;
        }
    }
}