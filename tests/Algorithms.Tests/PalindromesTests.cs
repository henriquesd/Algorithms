using Xunit;

namespace Algorithms.Tests
{
    public class PalindromesTests
    {
        [Theory]
        [InlineData("abba", true)]
        [InlineData("abcdefg", false)]
        public void IsPalindrome_ShouldReturnTrueOrFalse_IfWordIsPalindrome(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindrome(str);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData("abba", true)]
        [InlineData("abcdefg", false)]
        public void IsPalindromeUsingLinq_ShouldReturnTrueOrFalse_IfWordIsPalindrome(string str, bool expectedValue)
        {
            var result = Palindromes.IsPalindromeUsingLinq(str);

            Assert.Equal(expectedValue, result);
        }
    }
}
