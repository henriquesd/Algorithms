using Xunit;

namespace Algorithms.Tests
{
    public class BinarySearchTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 0)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, 8)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 15, null)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4, 3)]
        [InlineData(new int[] { 4, 110, 180, 250, 340, 480, 590, 1050 }, 480, 5)]
        public void FindNumberPositionInSortedArray_ShouldReturnSearchedNumberPosition(int[] inputArray, int searchedNumber, int? expectedPosition)
        {
            var result = BinarySearch.FindNumberPositionInSortedArray(inputArray, searchedNumber);

            Assert.Equal(result, expectedPosition);
        }
    }
}
