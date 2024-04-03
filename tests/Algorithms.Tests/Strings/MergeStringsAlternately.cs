using Algorithms.Strings;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class MergeStringsAlternatelyTests
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("abcd", "pq", "apbqcd")]
        public void MergeStringsAlternately_ShouldReturnMergedString(string word1, string word2, string expectedMergedString)
        {
            var result = MergeStringsAlternately.MergeAlternately(word1, word2);

            Assert.Equivalent(expectedMergedString, result);
        }
    }
}