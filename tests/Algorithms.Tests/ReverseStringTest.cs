using Xunit;

namespace Algorithms.Tests
{
    public class ReverseStringTest
    {
        [Theory]
        [InlineData("apple", "elppa")]
        [InlineData("hello", "olleh")]
        [InlineData("  abc", "cba  ")]
        public void Reverse_ShouldReverseString(string str, string strExpected)
        {
            var result = ReverseString.Reverse(str);

            Assert.Equal(result, strExpected);
        }

        [Theory]
        [InlineData("apple", "elppa")]
        [InlineData("hello", "olleh")]
        [InlineData("  abc", "cba  ")]
        public void ReverseUsingLinq_ShouldReverseString(string str, string strExpected)
        {
            var result = ReverseString.ReverseUsingLinq(str);

            Assert.Equal(result, strExpected);
        }
    }
}
