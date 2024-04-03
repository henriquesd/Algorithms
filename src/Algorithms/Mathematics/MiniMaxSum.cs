namespace Algorithms.Mathematics
{
    public static class MiniMaxSum
    {
        // Given X positive integers, find the minimum and maximum values that can be calculated by:
        // summing all numbers except the smallest
        // and summing all numbers except the biggest 
        // Then print the respective minimum and maximum values as a single line of two space-separated integers.

        public static string ExecuteMiniMaxSumList(List<int> listOfValues)
        {
            if (!listOfValues.Any()) return "";
            if (listOfValues.Count() == 1) return listOfValues.First().ToString();

            listOfValues.Sort();

            var minSum = 0;
            var maxSum = 0;
            var result = "";

            for (int i = 0; i < listOfValues.Count; i++)
            {
                if (i < listOfValues.Count - 1)
                {
                    minSum += listOfValues[i];
                }

                if (i > 0)
                {
                    maxSum += listOfValues[i];
                }
            }

            result = $"{minSum.ToString()} {maxSum.ToString()}";

            return result;
        }

        public static string ExecuteMiniMaxSumArray(int[] arrayOfValues)
        {
            if (arrayOfValues.Length == 0) return "";
            if (arrayOfValues.Length == 1) return arrayOfValues[0].ToString();

            Array.Sort(arrayOfValues);

            var minSum = 0;
            var maxSum = 0;
            var result = "";

            for (int i = 0; i < arrayOfValues.Count(); i++)
            {
                if (i < arrayOfValues.Count() - 1)
                {
                    minSum += arrayOfValues[i];
                }

                if (i > 0)
                {
                    maxSum += arrayOfValues[i];
                }
            }

            result = $"{minSum.ToString()} {maxSum.ToString()}";

            return result;
        }


        public static string ExecuteMiniMaxSumWithLinq(List<int> listOfValues)
        {
            if (!listOfValues.Any()) return "";
            if (listOfValues.Count() == 1) return listOfValues.First().ToString();

            listOfValues.Sort();

            // Sum all elements except the last one;
            var minSum = listOfValues.Take(listOfValues.Count - 1).Sum();

            // Sum all elements except the first one;
            var maxSum = listOfValues.Skip(1).Sum();

            return $"{minSum} {maxSum}";
        }
    }
}
