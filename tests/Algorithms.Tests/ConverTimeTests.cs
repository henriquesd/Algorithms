using Xunit;

namespace Algorithms.Tests
{
    public class ConverTimeTests
    {
        [Theory]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("00:00:00AM", "00:00:00")]
        [InlineData("12:00:00AM", "00:00:00")] // Midnight
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("11:59:59PM", "23:59:59")]
        [InlineData("12:00:00PM", "12:00:00")] // Noon
        [InlineData("12:00:01PM", "12:00:01")]
        [InlineData("01:30:45AM", "01:30:45")]
        [InlineData("12:59:59AM", "00:59:59")]
        [InlineData("03:45:00PM", "15:45:00")]
        [InlineData("06:15:30AM", "06:15:30")]
        [InlineData("10:30:15PM", "22:30:15")]
        [InlineData("10:30:15XX", "")]
        [InlineData("", "")]
        [InlineData("11", "")]
        public void Convert_ShouldReturnCorrectedValue(string timeToConvert, string expectedResult)
        {
            // Arrange

            // Act
            var result = ConverTime.Convert(timeToConvert);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("07:05:45PM", "19:05:45")]
        [InlineData("00:00:00AM", "00:00:00")]
        [InlineData("12:00:00AM", "00:00:00")] // Midnight
        [InlineData("12:01:00AM", "00:01:00")]
        [InlineData("11:59:59PM", "23:59:59")]
        [InlineData("12:00:00PM", "12:00:00")] // Noon
        [InlineData("12:00:01PM", "12:00:01")]
        [InlineData("01:30:45AM", "01:30:45")]
        [InlineData("12:59:59AM", "00:59:59")]
        [InlineData("03:45:00PM", "15:45:00")]
        [InlineData("06:15:30AM", "06:15:30")]
        [InlineData("10:30:15PM", "22:30:15")]
        [InlineData("10:30:15XX", "")]
        [InlineData("", "")]
        [InlineData("11", "")]
        public void ConvertToMilitaryTime_ShouldReturnCorrectedValue(string timeToConvert, string expectedResult)
        {
            // Arrange

            // Act
            var result = ConverTime.ConvertToMilitaryTime(timeToConvert);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
