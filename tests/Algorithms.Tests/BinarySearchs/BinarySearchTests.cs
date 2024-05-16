using Algorithms.BinarySearchs;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.BinarySearchs
{
    public class BinarySearchTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void Search_ShouldReturnSearchedNumberPosition(int[] inputArray, int searchedNumber, int? expectedPosition)
        {
            var result = BinarySearch.Search(inputArray, searchedNumber);

            Assert.Equal(expectedPosition, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 0 }; // First element
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9, 8 }; // Last element
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 15, -1 }; // Element not found
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4, 3 }; // Middle element
            yield return new object[] { new int[] { -10, -5, 0, 5, 10 }, -10, 0 }; // Negative numbers
        }
    }
}