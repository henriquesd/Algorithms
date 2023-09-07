namespace Algorithms
{
    public static class RomanToInteger
    {
        private static readonly Dictionary<string, int> RomanToIntegerDictionary = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };

        public static int Convert(string romanNumber)
        {
            if (string.IsNullOrEmpty(romanNumber)) return 0;

            int result = 0;
            int prevValue = 0;

            for (int i = romanNumber.Length - 1; i >= 0; i--)
            {
                char currentChar = romanNumber[i];
                int currentValue = RomanToIntegerDictionary[currentChar.ToString()];

                if (currentValue < prevValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }

                prevValue = currentValue;
            }

            return result;
        }
    }
}
