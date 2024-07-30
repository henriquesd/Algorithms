using Algorithms.Arrays;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Arrays
{
    public class MoveZeroesTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MoveZeroesExample1_ShouldReturnArrayWithZerosAtTheEnd(int[] nums, int[] expectedResult)
        {
            var result = MoveZeroes.MoveZeroesExample1(nums);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MoveZeroesExample2_ShouldReturnArrayWithZerosAtTheEnd(int[] nums, int[] expectedResult)
        {
            var result = MoveZeroes.MoveZeroesExample2(nums);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MoveZeroesExample3_ShouldReturnArrayWithZerosAtTheEnd(int[] nums, int[] expectedResult)
        {
            var result = MoveZeroes.MoveZeroesExample3(nums);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MoveZeroesExample4_ShouldReturnArrayWithZerosAtTheEnd(int[] nums, int[] expectedResult)
        {
            var result = MoveZeroes.MoveZeroesExample4(nums);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void MoveZeroesExample5_ShouldReturnArrayWithZerosAtTheEnd(int[] nums, int[] expectedResult)
        {
            var result = MoveZeroes.MoveZeroesExample5(nums);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { new int[] { 1, 2, 3, 0, 0 }, new int[] { 1, 2, 3, 0, 0 } };
            yield return new object[] { new int[] { 0, 0, 1, 2, 3 }, new int[] { 1, 2, 3, 0, 0 } };
            yield return new object[] { new int[] { 1, 0, 2, 0, 3 }, new int[] { 1, 2, 3, 0, 0 } };
            yield return new object[] { new int[] { 0 }, new int[] { 0 } };
            yield return new object[] { new int[] { 1 }, new int[] { 1 } };
            yield return new object[] { new int[] { 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0 } };
            yield return new object[] { new int[] {  }, new int[] { } };
        }
    }
}