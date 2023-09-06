namespace Algorithms
{
    public static class MajorityElement
    {
        // Given an array inputArray of size n, return the majority element;

        public static int Find(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0) return 0;

            var dictionaryOfValues = new Dictionary<int, int>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                // Check if key exists in a dictionary;
                if (dictionaryOfValues.ContainsKey(inputArray[i]))
                {
                    // Get a value from a Dictionary, searching by key;
                    if (dictionaryOfValues.TryGetValue(inputArray[i], out int currentQtd))
                    {
                        // Updating the value of a dictionary item;
                        dictionaryOfValues[inputArray[i]] = currentQtd + 1;
                    }
                }
                else
                {
                    // Adding new item in a dictionary;
                    dictionaryOfValues.Add(inputArray[i], 1);
                }
            }

            // Getting the key of the greatest value;
            var keyOfMaxValue = dictionaryOfValues.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            // Extra:
            //// Getting the greatest key;
            //var maxKey = dictionaryOfValues.Keys.Max();

            //// Getting the greatest value;
            //var maxValue = dictionaryOfValues.Values.Max();

            return keyOfMaxValue;
        }

        public static int FindMajorityElement(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0) return 0;

            int majorityElement = 0;
            int count = 0;

            foreach (int num in inputArray)
            {
                if (count == 0)
                {
                    majorityElement = num;
                    count = 1;
                }
                else if (num == majorityElement)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            // At this point, the majority element is stored in majorityElement.
            // You can optionally verify if it is indeed the majority element by counting its occurrences;

            int majorityCount = inputArray.Count(num => num == majorityElement);

            if (majorityCount > inputArray.Length / 2)
            {
                return majorityElement;
            }

            throw new InvalidOperationException("No majority element found.");
        }
    }
}
