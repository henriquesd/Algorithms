namespace Algorithms.Strings
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

        public static int ConvertWithDictionary(string romanNumber)
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

        public static int ConvertWithoutDictionary(string romanNumber)
        {
            if (string.IsNullOrEmpty(romanNumber)) return 0;

            int result = 0;
            int prevValue = 0;

            for (int i = romanNumber.Length - 1; i >= 0; i--)
            {
                char currentChar = romanNumber[i];

                int currentValue;
                if (currentChar == 'I') currentValue = 1;
                else if (currentChar == 'V') currentValue = 5;
                else if (currentChar == 'X') currentValue = 10;
                else if (currentChar == 'L') currentValue = 50;
                else if (currentChar == 'C') currentValue = 100;
                else if (currentChar == 'D') currentValue = 500;
                else if (currentChar == 'M') currentValue = 1000;
                else return 0; // Invalid Roman numeral;

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

        public static int ConvertWithoutDictionaryAndUsingSwitch(string romanNumber)
        {
            if (string.IsNullOrEmpty(romanNumber)) return 0;

            int result = 0;
            int prevValue = 0;

            for (int i = romanNumber.Length - 1; i >= 0; i--)
            {
                char currentChar = romanNumber[i];

                int currentValue = currentChar switch
                {
                    'I' => 1,
                    'V' => 5,
                    'X' => 10,
                    'L' => 50,
                    'C' => 100,
                    'D' => 500,
                    'M' => 1000,
                    _ => 0 // Invalid Roman numeral
                };

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
