using Algorithms.Strings;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class IndexFirstOccurrenceTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void StrStrDemo1_ShouldReturnCorrectIndex(string haystack, string needle, int index)
        {
            var result = IndexFirstOccurrence.StrStrDemo1(haystack, needle);

            Assert.Equal(index, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void StrStrDemo2_ShouldReturnCorrectIndex(string haystack, string needle, int index)
        {
            var result = IndexFirstOccurrence.StrStrDemo2(haystack, needle);

            Assert.Equal(index, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void StrStrDemo3_ShouldReturnCorrectIndex(string haystack, string needle, int index)
        {
            var result = IndexFirstOccurrence.StrStrDemo3(haystack, needle);

            Assert.Equal(index, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void StrStrDemo4_ShouldReturnCorrectIndex(string haystack, string needle, int index)
        {
            var result = IndexFirstOccurrence.StrStrDemo4(haystack, needle);

            Assert.Equal(index, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { "sadbutsad", "sad", 0 };
            yield return new object[] { "leetcode", "leeto", -1 };
            yield return new object[] { "hello", "ll", 2 };
            yield return new object[] { "abc", "c", 2 };
        }
    }
}