using Xunit;

namespace Algorithms.Tests
{
    public class ReverseArrayTests
    {
        [Theory]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(new int[] { 1 }, new int[] { 1 })]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [InlineData(new int[] { 2, 5, 8 }, new int[] { 8, 5, 2 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [InlineData(new int[] { 1, 7, 15, 25, 32, 39, 50, 54 }, new int[] { 54, 50, 39, 32, 25, 15, 7, 1 })]
        [InlineData(new int[] { 7, 19, 14, 3, 54 }, new int[] { 54, 3, 14, 19, 7 })]
        public void ReverseArrayIntoNewArray_ShouldReturnReversedArray(int[] inputArray, int[] expectedArray)
        {
            var result = ReverseArray.ReverseArrayIntoNewArray(inputArray);

            Assert.Equal(expectedArray, result);
        }
    }
}