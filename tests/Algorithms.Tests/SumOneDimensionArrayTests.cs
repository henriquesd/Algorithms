using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class SumOneDimensionArrayTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SumDemo1_ShouldReturnSumOfArray(int[] inputArray, int[] expectedArray)
        {
            var result = SumOneDimensionArray.SumDemo1(inputArray);

            Assert.Equal(expectedArray, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SumDemo2_ShouldReturnSumOfArray(int[] inputArray, int[] expectedArray)
        {
            var result = SumOneDimensionArray.SumDemo2(inputArray);

            Assert.Equal(expectedArray, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SumDemo3_ShouldReturnSumOfArray(int[] inputArray, int[] expectedArray)
        {
            var result = SumOneDimensionArray.SumDemo3(inputArray);

            Assert.Equal(expectedArray, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void SumDemoWithLinq_ShouldReturnSumOfArray(int[] inputArray, int[] expectedArray)
        {
            var result = SumOneDimensionArray.SumDemoWithLinq(inputArray);

            Assert.Equal(expectedArray, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 1 }, new int[] { 1 } };
            yield return new object[] { new int[] { 1, 2 }, new int[] { 1, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 } };
            yield return new object[] { new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 } };
        }
    }
}