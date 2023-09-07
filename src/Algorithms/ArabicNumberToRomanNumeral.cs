using System.Text;

namespace Algorithms
{
    public static class ArabicNumberToRomanNumeral
    {
        private static readonly Dictionary<int, string> RomanLetters = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public static string ConvertExample1(int arabicNumber)
        {
            if (arabicNumber == 0) return "";
            if (arabicNumber < 1 || arabicNumber > 3999) return "";

            var romanNumeral = new StringBuilder();

            while (arabicNumber > 0)
            {
                foreach (var key in RomanLetters.Keys)
                {
                    if (arabicNumber >= key)
                    {
                        arabicNumber -= key;
                        romanNumeral.Append(RomanLetters[key]);
                        break;
                    }
                }
            }
            return romanNumeral.ToString();
        }

        public static string ConvertExample2(int arabicNumber)
        {
            if (arabicNumber == 0) return "";
            if (arabicNumber < 1 || arabicNumber > 3999) return "";

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string romanNumeral =
                thousands[arabicNumber / 1000] +
                hundreds[(arabicNumber % 1000) / 100] +
                tens[(arabicNumber % 100) / 10] +
                ones[arabicNumber % 10];

            return romanNumeral;
        }
    }
}
