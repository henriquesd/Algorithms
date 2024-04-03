using Algorithms.Strings;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class IsomorphicStringsTests
    {
        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        public void IsIsomorphic_ShouldReturnExpectedValue(string s, string t, bool expectedValue)
        {
            var result = IsomorphicStrings.IsIsomorphic(s, t);

            Assert.Equivalent(expectedValue, result);
        }
    }
}