using Algorithms.Strings;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class ReverseStringIITests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void ReverseString_ShouldReverseString(char[] text, char[] expected)
        {
            var result = ReverseStringII.ReverseString(text);

            Assert.Equal(result, expected);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void ReverseStringWithRecursion_ShouldReverseString(char[] text, char[] expected)
        {
            var result = ReverseStringII.ReverseStringWithRecursion(text);

            Assert.Equal(result, expected);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new char[] { 'h', 'e', 'l', 'l', 'o' }, new char[] { 'o', 'l', 'l', 'e', 'h' } };
            yield return new object[] { new char[] { 'H', 'a', 'n', 'n', 'a', 'h' }, new char[] { 'h', 'a', 'n', 'n', 'a', 'H' } };
            yield return new object[] { new char[] { 'A', 'B', 'C' }, new char[] { 'C', 'B', 'A' } };
            yield return new object[] { new char[] { 'a', 'b' }, new char[] { 'b', 'a' } };
            yield return new object[] { new char[] { 'x' }, new char[] { 'x' } };
        }
    }
}