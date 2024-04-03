using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MajorityElementTests
    {
        [Theory]
        [InlineData(null, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void Find_ShouldReturnExpectedValue(int[] inputArray, int expectedResult)
        {
            // Act
            var result = MajorityElement.Find(inputArray);

            // Assert
            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData(null, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void FindMajorityElement_ShouldReturnExpectedValue(int[] inputArray, int expectedResult)
        {
            // Act
            var result = MajorityElement.FindMajorityElement(inputArray);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
