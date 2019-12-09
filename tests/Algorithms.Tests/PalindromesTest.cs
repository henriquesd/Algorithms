using Xunit;

namespace Algorithms.Tests
{
    public class PalindromesTest
    {
        [Theory]
        [InlineData("abba", true)]
        [InlineData("abcdefg", false)]
        public void IsPalindrome_ShouldReturnTrueOrFalse_IfWordIsPalindrome(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindrome(str);

            Assert.Equal(result, expectedValue);
        }

        [Theory]
        [InlineData("abba", true)]
        [InlineData("abcdefg", false)]
        public void IsPalindromeUsingLinq_ShouldReturnTrueOrFalse_IfWordIsPalindrome(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindromeUsingLinq(str);

            Assert.Equal(result, expectedValue);
        }
    }
}
