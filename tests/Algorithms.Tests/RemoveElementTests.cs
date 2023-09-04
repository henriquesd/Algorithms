using Xunit;

namespace Algorithms.Tests
{
    public class RemoveElementTests
    {
        [Theory]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { }, 1, 0)]
        [InlineData(null, 1, 0)]
        public void Remove_ShouldReturnCorrectValues(int[] inputArray, int inputValue, int expectedResult)
        {
            var result = RemoveElement.Remove(inputArray, inputValue);

            Assert.Equal(expectedResult, result);
        }
    }
}
