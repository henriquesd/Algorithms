using Algorithms.Arrays;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void RemoveDuplicatesFromSortedArrayTests_ShouldRemoveDuplicates(int[] nums, int expectedResult)
        {
            var result = RemoveDuplicatesFromSortedArray.RemoveDuplicates(nums);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 1, 1, 2 }, 2};
            yield return new object[] { new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5 };
            yield return new object[] { new int[] { }, 0 }; // Empty array
            yield return new object[] { new int[] { 1 }, 1 }; // Single element array
            yield return new object[] { new int[] { 1, 2, 3 }, 3 }; // No duplicates
            yield return new object[] { new int[] { 1, 1, 1, 1 }, 1 }; // All elements are duplicates
            yield return new object[] { new int[] { 1, 1, 2, 2, 3, 3, 4, 4 }, 4 }; // Alternating duplicates
        }
    }
}