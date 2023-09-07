using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class RomanToIntegerTests
    {
        [Theory]
        [MemberData(nameof(RomanNumberToIntegerData))]
        public void ConvertWithDictionary_ShouldReturnCorrectNumber(string romanNumber, int expectedResult)
        {
            var result = RomanToInteger.ConvertWithDictionary(romanNumber);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(RomanNumberToIntegerData))]
        public void ConvertWithoutDictionary_ShouldReturnCorrectNumber(string romanNumber, int expectedResult)
        {
            var result = RomanToInteger.ConvertWithoutDictionary(romanNumber);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(RomanNumberToIntegerData))]
        public void ConvertWithoutDictionaryAndUsingSwitch_ShouldReturnCorrectNumber(string romanNumber, int expectedResult)
        {
            var result = RomanToInteger.ConvertWithoutDictionaryAndUsingSwitch(romanNumber);

            Assert.Equal(expectedResult, result);
        }

        public static IEnumerable<object[]> RomanNumberToIntegerData()
        {
            yield return new object[] { "", 0 };
            yield return new object[] { "I", 1 };
            yield return new object[] { "II", 2 };
            yield return new object[] { "III", 3 };
            yield return new object[] { "IV", 4 };
            yield return new object[] { "V", 5 };
            yield return new object[] { "VI", 6 };
            yield return new object[] { "VII", 7 };
            yield return new object[] { "VIII", 8 };
            yield return new object[] { "IX", 9 };
            yield return new object[] { "X", 10 };
            yield return new object[] { "XI", 11 };
            yield return new object[] { "XII", 12 };
            yield return new object[] { "XIII", 13 };
            yield return new object[] { "XIV", 14 };
            yield return new object[] { "XV", 15 };
            yield return new object[] { "XVI", 16 };
            yield return new object[] { "XVII", 17 };
            yield return new object[] { "XVIII", 18 };
            yield return new object[] { "XIX", 19 };
            yield return new object[] { "XX", 20 };
            yield return new object[] { "XXI", 21 };
            yield return new object[] { "XXII", 22 };
            yield return new object[] { "XXIII", 23 };
            yield return new object[] { "XXIV", 24 };
            yield return new object[] { "XXV", 25 };
            yield return new object[] { "XXVI", 26 };
            yield return new object[] { "XXVII", 27 };
            yield return new object[] { "XXVIII", 28 };
            yield return new object[] { "XXIX", 29 };
            yield return new object[] { "XXX", 30 };
            yield return new object[] { "XXXI", 31 };
            yield return new object[] { "XXXII", 32 };
            yield return new object[] { "XXXIII", 33 };
            yield return new object[] { "XXXIV", 34 };
            yield return new object[] { "XXXV", 35 };
            yield return new object[] { "XXXVI", 36 };
            yield return new object[] { "XXXVII", 37 };
            yield return new object[] { "XXXVIII", 38 };
            yield return new object[] { "XXXIX", 39 };
            yield return new object[] { "XL", 40 };
            yield return new object[] { "XLI", 41 };
            yield return new object[] { "XLII", 42 };
            yield return new object[] { "XLIII", 43 };
            yield return new object[] { "XLIV", 44 };
            yield return new object[] { "XLV", 45 };
            yield return new object[] { "XLVI", 46 };
            yield return new object[] { "XLVII", 47 };
            yield return new object[] { "XLVIII", 48 };
            yield return new object[] { "XLIX", 49 };
            yield return new object[] { "L", 50 };
            yield return new object[] { "LI", 51 };
            yield return new object[] { "LII", 52 };
            yield return new object[] { "LIII", 53 };
            yield return new object[] { "LIV", 54 };
            yield return new object[] { "LV", 55 };
            yield return new object[] { "LVI", 56 };
            yield return new object[] { "LVII", 57 };
            yield return new object[] { "LVIII", 58 };
            yield return new object[] { "LIX", 59 };
            yield return new object[] { "LX", 60 };
            yield return new object[] { "LXI", 61 };
            yield return new object[] { "LXII", 62 };
            yield return new object[] { "LXIII", 63 };
            yield return new object[] { "LXIV", 64 };
            yield return new object[] { "LXV", 65 };
            yield return new object[] { "LXVI", 66 };
            yield return new object[] { "LXVII", 67 };
            yield return new object[] { "LXVIII", 68 };
            yield return new object[] { "LXIX", 69 };
            yield return new object[] { "LXX", 70 };
            yield return new object[] { "LXXI", 71 };
            yield return new object[] { "LXXII", 72 };
            yield return new object[] { "LXXIII", 73 };
            yield return new object[] { "LXXIV", 74 };
            yield return new object[] { "LXXV", 75 };
            yield return new object[] { "LXXVI", 76 };
            yield return new object[] { "LXXVII", 77 };
            yield return new object[] { "LXXVIII", 78 };
            yield return new object[] { "LXXIX", 79 };
            yield return new object[] { "LXXX", 80 };
            yield return new object[] { "LXXXI", 81 };
            yield return new object[] { "LXXXII", 82 };
            yield return new object[] { "LXXXIII", 83 };
            yield return new object[] { "LXXXIV", 84 };
            yield return new object[] { "LXXXV", 85 };
            yield return new object[] { "LXXXVI", 86 };
            yield return new object[] { "LXXXVII", 87 };
            yield return new object[] { "LXXXVIII", 88 };
            yield return new object[] { "LXXXIX", 89 };
            yield return new object[] { "XC", 90 };
            yield return new object[] { "XCI", 91 };
            yield return new object[] { "XCII", 92 };
            yield return new object[] { "XCIII", 93 };
            yield return new object[] { "XCIV", 94 };
            yield return new object[] { "XCV", 95 };
            yield return new object[] { "XCVI", 96 };
            yield return new object[] { "XCVII", 97 };
            yield return new object[] { "XCVIII", 98 };
            yield return new object[] { "XCIX", 99 };
            yield return new object[] { "C", 100 };
            yield return new object[] { "CI", 101 };
            yield return new object[] { "CD", 400 };
            yield return new object[] { "CM", 900 };
            yield return new object[] { "M", 1000 };
            yield return new object[] { "MI", 1001 };
            yield return new object[] { "MCMXCIV", 1994 };
            yield return new object[] { "MM", 2000 };
            yield return new object[] { "MMIV", 2004 };
            yield return new object[] { "MMMCMXCIX", 3999 };
        }
    }
}
