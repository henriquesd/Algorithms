using Algorithms.Arrays;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class IntersectionTwoArraysIITests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
        [InlineData(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 9, 4 })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { })]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        public void Intersect_ShouldReturnIntersection(int[] nums1, int[] nums2, int[] expectedResult)
        {
            var result = IntersectionTwoArraysII.Intersect(nums1, nums2);

            Assert.Equal(expectedResult, result);
        }
    }
}