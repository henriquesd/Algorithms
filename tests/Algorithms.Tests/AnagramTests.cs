using Xunit;

namespace Algorithms.Tests
{
    public class AnagramTests
    {
        [Theory]
        [InlineData("abc", "cba", true)]
        [InlineData("Abc", "cba", true)]
        [InlineData("abc", "Cba", true)]
        [InlineData("aBc", "cba", true)]
        [InlineData("abc", "cbA", true)]
        [InlineData("a bc", "cba", true)]
        [InlineData("abc", "c ba", true)]
        [InlineData(" abc", "cba", true)]
        [InlineData("abc ", "cba", true)]
        [InlineData("abc", " cba", true)]
        [InlineData("abc", "cba ", true)]
        [InlineData("abc", "cbd", false)]
        [InlineData("aabc", "abc", false)]
        [InlineData("abc", "aabc", false)]
        [InlineData("abbc", "cbd", false)]
        [InlineData("abc", "cbbd", false)]
        [InlineData("Abc", "cbd", false)]
        [InlineData("abc", "Cbd", false)]
        [InlineData("abc", "cb", false)]
        [InlineData("ab", "cbd", false)]
        public void AreAnagram_ShouldReturnExpectedValue(string text1, string text2, bool expectedValue)
        {
            var result = Anagram.AreAnagram(text1, text2);

            Assert.Equal(expectedValue, result);
        }
    }
}
