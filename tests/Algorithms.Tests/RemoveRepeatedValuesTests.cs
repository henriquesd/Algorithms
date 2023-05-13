using Xunit;

namespace Algorithms.Tests
{
    public class RemoveRepeatedValuesTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, new int[] { })]
        public void RemoveDuplicatesFromSortedArray_ShouldReturnArrayWithoutDuplicatedValues(int[] arrayWithDuplicatedValues, int[] expectedResult)
        {
            var result = RemoveRepeatedValues.RemoveDuplicatesFromSortedArray(arrayWithDuplicatedValues);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 2, 2, 4, 2, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, new int[] { })]
        public void RemoveRepeatedValues_ShouldReturnArrayWithoutRepeatedValues(int[] arrayWithDuplicatedValues, int[] expectedResult)
        {
            var result = RemoveRepeatedValues.RemoveRepeatedValuesFromArray(arrayWithDuplicatedValues);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 2, 2, 4, 2, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, new int[] { })]
        public void RemoveRepeatedValuesWithLinq_ShouldReturnArrayWithoutRepeatedValues(int[] arrayWithDuplicatedValues, int[] expectedResult)
        {
            var result = RemoveRepeatedValues.RemoveRepeatedValuesWithLinq(arrayWithDuplicatedValues);

            Assert.Equal(expectedResult, result);
        }
    }
}
