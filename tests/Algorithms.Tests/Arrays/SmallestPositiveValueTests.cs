using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class SmallestPositiveValueTests
    {
        [Theory]
        [InlineData(new int[] { }, 1)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { 2, 3, 4 }, 1)]
        [InlineData(new int[] { 1, 3, 2 }, 4)]
        [InlineData(new int[] { 1, 3, 4, 6, 2 }, 5)]
        [InlineData(new int[] { 1, 3, 4, 2, 1, 6 }, 5)]
        [InlineData(new int[] { -1 }, 1)]
        [InlineData(new int[] { -1, 2, 3 }, 1)]
        [InlineData(new int[] { -1, -2, -3 }, 1)]
        public void Execute_ShouldReturnSmallestPositiveValue(int[] inputArray, int expectedValue)
        {
            var result = SmallestPositiveValue.Execute(inputArray);

            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(new int[] { }, 1)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 4)]
        [InlineData(new int[] { 2, 3, 4 }, 1)]
        [InlineData(new int[] { 1, 3, 2 }, 4)]
        [InlineData(new int[] { 1, 3, 4, 6, 2 }, 5)]
        [InlineData(new int[] { 1, 3, 4, 2, 1, 6 }, 5)]
        [InlineData(new int[] { -1 }, 1)]
        [InlineData(new int[] { -1, 2, 3 }, 1)]
        [InlineData(new int[] { -1, -2, -3 }, 1)]
        public void ExecuteWithSortedArray_ShouldReturnSmallestPositiveValue(int[] inputArray, int expectedValue)
        {
            var result = SmallestPositiveValue.ExecuteWithSortedArray(inputArray);

            Assert.Equal(expectedValue, result);
        }
    }
}