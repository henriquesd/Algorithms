using Algorithms.Strings;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Strings
{
    public class ValidParenthesisStringTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void CheckValidStringExample1_ShouldReturnExpectedValue(string text, bool expectedValue)
        {
            var result = ValidParenthesisString.CheckValidStringExample1(text);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void CheckValidStringExample2_ShouldReturnExpectedValue(string text, bool expectedValue)
        {
            var result = ValidParenthesisString.CheckValidStringExample2(text);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void CheckValidStringExample3_ShouldReturnExpectedValue(string text, bool expectedValue)
        {
            var result = ValidParenthesisString.CheckValidStringExample3(text);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void CheckValidStringExample4_ShouldReturnExpectedValue(string text, bool expectedValue)
        {
            var result = ValidParenthesisString.CheckValidStringExample4(text);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void CheckValidStringExample5_ShouldReturnExpectedValue(string text, bool expectedValue)
        {
            var result = ValidParenthesisString.CheckValidStringExample5(text);

            Assert.Equal(expectedValue, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { "()", true };
            yield return new object[] { "(*", true };
            yield return new object[] { "*)", true };
            yield return new object[] { "()()", true };
            yield return new object[] { "()*()", true };
            yield return new object[] { "*()", true };
            yield return new object[] { "()*", true };
            yield return new object[] { "*()*", true };
            yield return new object[] { "(*", true };
            yield return new object[] { "*)", true };
            yield return new object[] { "*", true };
            yield return new object[] { "**", true };
            yield return new object[] { "(*)", true };
            yield return new object[] { "(((((*)))**", true };
            yield return new object[] { "())", false };
            yield return new object[] { "(()", false };
            yield return new object[] { "())", false };
            yield return new object[] { "(*(", false };
            yield return new object[] { ")*)", false };
            yield return new object[] { ")*", false };
            yield return new object[] { "*(", false };
            yield return new object[] { "((()((()))(())()())*)(()(())()))()))))(((*(()(((()()(())()))*(())*)(()(()(()()()))()(()()()", false };
        }
    }
}