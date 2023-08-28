using Xunit;

namespace Algorithms.Tests
{
    public class RepeatedNumberArrayTests
    {
        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 3, 2, 1, 7 }, 0)]
        [InlineData(new int[] { 4, 4, 1, 3 }, 2)]
        [InlineData(new int[] { 3, 2, 1, 3, 7, 3 }, 3)]
        [InlineData(new int[] { 3, 1, 2, 1, 3, 1, 7, 1, 3, 7, 1 }, 5)]
        public void CountMostRepeatedNumberWithTuple_ShouldReturnExpectedResult(int[] inputArray, int expectedResult)
        {
            var result = RepeatedNumberArray.CountMostRepeatedNumberWithTuple(inputArray);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 3, 2, 1, 7 }, 0)]
        [InlineData(new int[] { 4, 4, 1, 3 }, 2)]
        [InlineData(new int[] { 3, 2, 1, 3, 7, 3 }, 3)]
        [InlineData(new int[] { 3, 1, 2, 1, 3, 1, 7, 1, 3, 7, 1 }, 5)]
        public void CountMostRepeatedNumberWithDictionary_ShouldReturnExpectedResult(int[] inputArray, int expectedResult)
        {
            var result = RepeatedNumberArray.CountMostRepeatedNumberWithDictionary(inputArray);

            Assert.Equal(expectedResult, result);
        }
    }
}