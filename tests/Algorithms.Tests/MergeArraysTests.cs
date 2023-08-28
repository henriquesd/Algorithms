using Xunit;

namespace Algorithms.Tests
{
    public class MergeArraysTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 2, 5, 6 }, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, new int[] { }, new int[] { 1 })]
        [InlineData(new int[] { 0 }, new int[] { 1 }, new int[] { 1 })]
        public void MergeArrays_ShouldMergeArrays(int[] inputArray1, int[] inputArray2, int[] expectedResult)
        {
            var result = MergeArrays.Merge1(inputArray1, inputArray2);

            Assert.Equal(expectedResult, result);
        }
     
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        public void MergeSortedArray_ShouldMergeArrays2(int[] inputArray1, int m, int[] inputArray2, int n, int[] expectedResult)
        {
            var result = MergeArrays.Merge2(inputArray1, m, inputArray2, n);

            Assert.Equal(expectedResult, result);
        }
    }
}
