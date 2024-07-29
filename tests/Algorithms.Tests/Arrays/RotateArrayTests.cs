using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class RotateArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 10, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 0, new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        [InlineData(new int[] { 1, 2, 3 }, 0, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
        public void Rotate_ShouldRotateArray(int[] inputArray, int rotate, int[] expectedResult)
        {
            var result = RotateArray.Rotate(inputArray, rotate);

            Assert.Equal(expectedResult, result);
        }
    }
}