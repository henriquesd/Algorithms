using Xunit;

namespace Algorithms.Tests
{
    public class RemoveRepeatedValuesFromArrayTest
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 2, 3, 4, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, new int[] { })]
        public void RemoveDuplicatesFromSortedArray_ShouldReturnArrayWithoutDuplicatedValues(int[] arrayWithDuplicatedValues, int[] expectedArrayWithoutDuplicatedValues)
        {
            var result = RemoveRepeatedValuesFromArray.RemoveDuplicatesFromSortedArray(arrayWithDuplicatedValues);

            Assert.Equal(expectedArrayWithoutDuplicatedValues, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 2, 2, 4, 2, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, new int[] { })]
        public void RemoveRepeatedValues_ShouldReturnArrayWithoutRepeatedValues(int[] arrayWithDuplicatedValues, int[] expectedArrayWithoutDuplicatedValues)
        {
            var result = RemoveRepeatedValuesFromArray.RemoveRepeatedValues(arrayWithDuplicatedValues);

            Assert.Equal(expectedArrayWithoutDuplicatedValues, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 2, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3, 2, 2, 4, 2, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { }, new int[] { })]
        [InlineData(null, new int[] { })]
        public void RemoveRepeatedValuesWithLinq_ShouldReturnArrayWithoutRepeatedValues(int[] arrayWithDuplicatedValues, int[] expectedArrayWithoutDuplicatedValues)
        {
            var result = RemoveRepeatedValuesFromArray.RemoveRepeatedValuesWithLinq(arrayWithDuplicatedValues);

            Assert.Equal(expectedArrayWithoutDuplicatedValues, result);
        }
    }
}
