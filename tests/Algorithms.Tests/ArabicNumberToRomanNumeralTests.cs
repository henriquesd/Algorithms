using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
     public class ArabicNumberToRomanNumeralTests
    {
        [Theory]
        [MemberData(nameof(ArabicToRomanTestData))]
        public void ConvertExample1_ShouldReturnCorrectRomanNumeral(int number, string expectedResult)
        {
            var result = ArabicNumberToRomanNumeral.ConvertExample1(number);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ArabicToRomanTestData))]
        public void ConvertExample2_ShouldReturnCorrectRomanNumeral(int number, string expectedResult)
        {
            var result = ArabicNumberToRomanNumeral.ConvertExample2(number);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> ArabicToRomanTestData()
        {
            yield return new object[] { 0, "" };
            yield return new object[] { 1, "I" };
            yield return new object[] { 2, "II" };
            yield return new object[] { 3, "III" };
            yield return new object[] { 4, "IV" };
            yield return new object[] { 5, "V" };
            yield return new object[] { 6, "VI" };
            yield return new object[] { 7, "VII" };
            yield return new object[] { 8, "VIII" };
            yield return new object[] { 9, "IX" };
            yield return new object[] { 10, "X" };
            yield return new object[] { 11, "XI" };
            yield return new object[] { 12, "XII" };
            yield return new object[] { 13, "XIII" };
            yield return new object[] { 14, "XIV" };
            yield return new object[] { 15, "XV" };
            yield return new object[] { 16, "XVI" };
            yield return new object[] { 17, "XVII" };
            yield return new object[] { 18, "XVIII" };
            yield return new object[] { 19, "XIX" };
            yield return new object[] { 20, "XX" };
            yield return new object[] { 21, "XXI" };
            yield return new object[] { 22, "XXII" };
            yield return new object[] { 23, "XXIII" };
            yield return new object[] { 24, "XXIV" };
            yield return new object[] { 25, "XXV" };
            yield return new object[] { 26, "XXVI" };
            yield return new object[] { 27, "XXVII" };
            yield return new object[] { 28, "XXVIII" };
            yield return new object[] { 29, "XXIX" };
            yield return new object[] { 30, "XXX" };
            yield return new object[] { 31, "XXXI" };
            yield return new object[] { 32, "XXXII" };
            yield return new object[] { 33, "XXXIII" };
            yield return new object[] { 34, "XXXIV" };
            yield return new object[] { 35, "XXXV" };
            yield return new object[] { 36, "XXXVI" };
            yield return new object[] { 37, "XXXVII" };
            yield return new object[] { 38, "XXXVIII" };
            yield return new object[] { 39, "XXXIX" };
            yield return new object[] { 40, "XL" };
            yield return new object[] { 41, "XLI" };
            yield return new object[] { 42, "XLII" };
            yield return new object[] { 43, "XLIII" };
            yield return new object[] { 44, "XLIV" };
            yield return new object[] { 45, "XLV" };
            yield return new object[] { 46, "XLVI" };
            yield return new object[] { 47, "XLVII" };
            yield return new object[] { 48, "XLVIII" };
            yield return new object[] { 49, "XLIX" };
            yield return new object[] { 50, "L" };
            yield return new object[] { 51, "LI" };
            yield return new object[] { 52, "LII" };
            yield return new object[] { 53, "LIII" };
            yield return new object[] { 54, "LIV" };
            yield return new object[] { 55, "LV" };
            yield return new object[] { 56, "LVI" };
            yield return new object[] { 57, "LVII" };
            yield return new object[] { 58, "LVIII" };
            yield return new object[] { 59, "LIX" };
            yield return new object[] { 60, "LX" };
            yield return new object[] { 61, "LXI" };
            yield return new object[] { 62, "LXII" };
            yield return new object[] { 63, "LXIII" };
            yield return new object[] { 64, "LXIV" };
            yield return new object[] { 65, "LXV" };
            yield return new object[] { 66, "LXVI" };
            yield return new object[] { 67, "LXVII" };
            yield return new object[] { 68, "LXVIII" };
            yield return new object[] { 69, "LXIX" };
            yield return new object[] { 70, "LXX" };
            yield return new object[] { 71, "LXXI" };
            yield return new object[] { 72, "LXXII" };
            yield return new object[] { 73, "LXXIII" };
            yield return new object[] { 74, "LXXIV" };
            yield return new object[] { 75, "LXXV" };
            yield return new object[] { 76, "LXXVI" };
            yield return new object[] { 77, "LXXVII" };
            yield return new object[] { 78, "LXXVIII" };
            yield return new object[] { 79, "LXXIX" };
            yield return new object[] { 80, "LXXX" };
            yield return new object[] { 81, "LXXXI" };
            yield return new object[] { 82, "LXXXII" };
            yield return new object[] { 83, "LXXXIII" };
            yield return new object[] { 84, "LXXXIV" };
            yield return new object[] { 85, "LXXXV" };
            yield return new object[] { 86, "LXXXVI" };
            yield return new object[] { 87, "LXXXVII" };
            yield return new object[] { 88, "LXXXVIII" };
            yield return new object[] { 89, "LXXXIX" };
            yield return new object[] { 90, "XC" };
            yield return new object[] { 91, "XCI" };
            yield return new object[] { 92, "XCII" };
            yield return new object[] { 93, "XCIII" };
            yield return new object[] { 94, "XCIV" };
            yield return new object[] { 95, "XCV" };
            yield return new object[] { 96, "XCVI" };
            yield return new object[] { 97, "XCVII" };
            yield return new object[] { 98, "XCVIII" };
            yield return new object[] { 99, "XCIX" };
            yield return new object[] { 100, "C" };
            yield return new object[] { 101, "CI" };
            yield return new object[] { 1000, "M" };
            yield return new object[] { 1001, "MI" };
            yield return new object[] { 2000, "MM" };
            yield return new object[] { 2004, "MMIV" };
            yield return new object[] { 3999, "MMMCMXCIX" };
            yield return new object[] { 4000, "" };
            yield return new object[] { 8548, "" };
        }
    }
}
