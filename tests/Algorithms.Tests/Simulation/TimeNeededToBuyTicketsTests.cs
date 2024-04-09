using Algorithms.Simulation;
using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests.Simulation
{
    public class TimeNeededToBuyTicketsTests
    {
        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void TimeRequiredToBuyExample0_ShouldReturnExpectedSeconds(int[] tickets, int k, int expectedSeconds)
        {
            var result = TimeNeededToBuyTickets.TimeRequiredToBuyExample0(tickets, k);

            Assert.Equal(expectedSeconds, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void TimeRequiredToBuyExample1_ShouldReturnExpectedSeconds(int[] tickets, int k, int expectedSeconds)
        {
            var result = TimeNeededToBuyTickets.TimeRequiredToBuyExample1(tickets, k);

            Assert.Equal(expectedSeconds, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void TimeRequiredToBuyExample2_ShouldReturnExpectedSeconds(int[] tickets, int k, int expectedSeconds)
        {
            var result = TimeNeededToBuyTickets.TimeRequiredToBuyExample2(tickets, k);

            Assert.Equal(expectedSeconds, result);
        }

        [Theory]
        [MemberData(nameof(ValuesToTest))]
        public void TimeRequiredToBuyExample3_ShouldReturnExpectedSeconds(int[] tickets, int k, int expectedSeconds)
        {
            var result = TimeNeededToBuyTickets.TimeRequiredToBuyExample3(tickets, k);

            Assert.Equal(expectedSeconds, result);
        }

        public static IEnumerable<object[]> ValuesToTest()
        {
            yield return new object[] { new int[] { 2, 3, 2 }, 2, 6 };
            yield return new object[] { new int[] { 5, 1, 1, 1 }, 0, 8 };
            yield return new object[] { new int[] { 1, 0, 1 }, 0, 1 };
        }
    }
}