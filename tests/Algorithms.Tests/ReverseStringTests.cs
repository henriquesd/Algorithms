using Xunit;

namespace Algorithms.Tests
{
    public class ReverseStringTests
    {
        [Theory]
        [InlineData("apple", "elppa")]
        [InlineData("hello", "olleh")]
        [InlineData("  abc", "cba  ")]
        public void Reverse_ShouldReverseString(string text, string expectedText)
        {
            var result = ReverseString.Reverse(text);

            Assert.Equal(expectedText, result);
        }

        [Theory]
        [InlineData("apple", "elppa")]
        [InlineData("hello", "olleh")]
        [InlineData("  abc", "cba  ")]
        public void ReverseUsingLinq_ShouldReverseString(string text, string expectedText)
        {
            var result = ReverseString.ReverseUsingLinq(text);

            Assert.Equal(expectedText, result);
        }

        [Theory]
        [InlineData("apple", "elppa")]
        [InlineData("hello", "olleh")]
        [InlineData(" abc", "cba ")]
        [InlineData("  abc", "cba  ")]
        [InlineData(" abc ", " cba ")]
        [InlineData("reverse string", "gnirts esrever")]
        [InlineData("test ", " tset")]
        [InlineData(" test ", " tset ")]
        [InlineData("", null)]
        [InlineData(" ", null)]
        [InlineData(null, null)]
        public void ReverseWithStringBuilder_ShouldReverseString(string text, string expectedText)
        {
            var result = ReverseString.ReverseWithStringBuilder(text);

            Assert.Equal(expectedText, result);
        }

        [Theory]
        [InlineData("hello reverse", "olleh esrever")]
        [InlineData("hello reverse string", "olleh esrever gnirts")]
        [InlineData("level wow", "level wow")]
        [InlineData("a ?", "a ?")]
        [InlineData("", null)]
        [InlineData(" ", null)]
        [InlineData(null, null)]
        public void ReverseEachWord_ShouldReverseWords(string text, string expectedText)
        {
            var result = ReverseString.ReverseEachWord(text);

            Assert.Equal(expectedText, result);
        }
    }
}
