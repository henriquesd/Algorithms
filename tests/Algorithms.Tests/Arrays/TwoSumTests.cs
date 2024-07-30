using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { -3, 4, 3, 90 }, 0, new int[] { 0, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 10, null)]
        public void TwoSumTests_ShouldReturnExpectedValue(int[] inputArray, int target, int[] expectedResult)
        {
            var result = TwoSum.Execute(inputArray, target);

            Assert.Equal(expectedResult, result);
        }
    }
}