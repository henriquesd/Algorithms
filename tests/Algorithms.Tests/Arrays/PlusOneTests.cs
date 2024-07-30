using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class PlusOneTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 2 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [InlineData(new int[] { 1, 2, 9 }, new int[] { 1, 3, 0 })]
        [InlineData(new int[] { 9, 9, 9 }, new int[] { 1, 0, 0, 0 })]
        [InlineData(new int[] { 0,0,1 }, new int[] { 0,0,2 })]
        [InlineData(new int[] {  }, new int[] { 1 })]
        public void PlusOne_ShouldReturnExpectedValue(int[] inputArray, int[] expectedResult)
        {
            var result = PlusOne.Execute(inputArray);

            Assert.Equal(expectedResult, result);
        }
    }
}