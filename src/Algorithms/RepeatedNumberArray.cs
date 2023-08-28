namespace Algorithms
{
    public static class RepeatedNumberArray
    {
        // This method returns the amount of times that the most repeated number appears in the array;

        public static int CountMostRepeatedNumberWithTuple(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            // If there are no repeated number in the array, return 0;
            var containsOnlyUniqueNumbers = new HashSet<int>(numbers).Count() == numbers.Length;

            // Other possible ways to achieve the same result:
            //var containsOnlyUniqueNumbers = !numbers.Any(x => numbers.Count(y => x == y) > 1);
            //var containsOnlyUniqueNumbers = numbers.All(x => numbers.Count(y => x == y) == 1);

            if (containsOnlyUniqueNumbers) return 0;

            var listOfNumbers = new List<(int, int)>();

            for (int i = 0; i < numbers.Length; i++)
            {
                // if value of numbers[i] already exist in list of numbers, update the quantity;
                if (listOfNumbers.Count > 0 && listOfNumbers.Exists(tuple => tuple.Item1 == numbers[i]))
                {
                    // update the quantity;
                    var updatedListOfNumbers = listOfNumbers.Find(tuple => tuple.Item1 == numbers[i]);

                    var number = updatedListOfNumbers.Item1;
                    var qtd = updatedListOfNumbers.Item2;
                    var index = listOfNumbers.FindIndex(tuple => tuple.Item1 == numbers[i]);

                    var updatedTuple = (number, qtd + 1);
                    listOfNumbers[index] = updatedTuple;
                }
                else
                {
                    listOfNumbers.Add((numbers[i], 1));
                }
            }

            var numberMostRepeated = listOfNumbers.MaxBy(x => x.Item2);

            return numberMostRepeated.Item2;
        }

        public static int CountMostRepeatedNumberWithDictionary(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            var containsOnlyUniqueNumbers = new HashSet<int>(numbers).Count() == numbers.Length;
            if (containsOnlyUniqueNumbers) return 0;

            Dictionary<int, int> numberCount = new Dictionary<int, int>();

            foreach (int num in numbers)
            {
                if (numberCount.ContainsKey(num))
                {
                    numberCount[num]++;
                }
                else
                {
                    numberCount[num] = 1;
                }
            }

            int maxCount = numberCount.Values.Max();

            return maxCount;
        }
    }
}
