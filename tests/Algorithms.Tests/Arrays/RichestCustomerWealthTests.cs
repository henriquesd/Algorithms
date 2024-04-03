using System.Collections.Generic;
using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class RichestCustomerWealthTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MaximumWealthExample1_ShouldReturnRichestCustomerWealth(int[][] accounts, int expectedResult)
        {
            var result = RichestCustomerWealth.MaximumWealthExample1(accounts);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MaximumWealthExample2_ShouldReturnRichestCustomerWealth(int[][] accounts, int expectedResult)
        {
            var result = RichestCustomerWealth.MaximumWealthExample2(accounts);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MaximumWealthWithLinq_ShouldReturnRichestCustomerWealth(int[][] accounts, int expectedResult)
        {
            var result = RichestCustomerWealth.MaximumWealthWithLinq(accounts);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } }, 6 };
            yield return new object[] { new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } }, 10 };
            yield return new object[] { new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } }, 17 };
            yield return new object[] { new int[][] { new int[] { 2, 8, 7 }, new int[] { 1, 1, 3 }, new int[] { 1, 9, 10 } }, 20 };
            yield return new object[] { new int[][] { new int[] { 1, 2, 3, 8, 9 }, new int[] { 3, 2, 1, 1, 2 } }, 23 };
            yield return new object[] { new int[][] { new int[] { 2, 8, 7 }, new int[] { 1, 1, 3 }, new int[] { 1, 9, 10 }, new int[] { 1, 2, 3 }, new int[] { 1, 20, 10 }, new int[] { 1, 1, 2 } }, 31 };
        }
    }
}
