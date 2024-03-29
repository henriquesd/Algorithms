namespace Algorithms
{
    /// <summary>
    /// Given an array of numbers, it calculates the cumulative sum of the elements in the array
    /// where each element at index i contains the sum of all elements up to index i;
    /// </summary>
    public static class SumOneDimensionArray
    {
        public static int[] SumDemo1(int[] arrayOfNumbers)
        {
            int[] output = new int[arrayOfNumbers.Length];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (i == 0)
                {
                    output[i] = arrayOfNumbers[i];
                }
                else
                {
                    output[i] = output[i - 1] + arrayOfNumbers[i];
                }
            }

            return output;
        }

        public static int[] SumDemo2(int[] arrayOfNumbers)
        {
            int[] output = new int[arrayOfNumbers.Length];
            output[0] = arrayOfNumbers[0];

            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                output[i] = output[i - 1] + arrayOfNumbers[i];
            }

            return output;
        }

        public static int[] SumDemo3(int[] arrayOfNumbers)
        {
            for (int i = 1; i < arrayOfNumbers.Length; i++)
            {
                //arrayOfNumbers[i] = arrayOfNumbers[i - 1] + arrayOfNumbers[i];
                arrayOfNumbers[i] += arrayOfNumbers[i - 1];
            }

            return arrayOfNumbers;
        }

        public static int[] SumDemoWithLinq(int[] arrayOfNumbers)
        {
            return arrayOfNumbers.Select((x, i) => arrayOfNumbers.Take(i + 1).Sum()).ToArray();
        }
    }
}
