namespace Algorithms.Arrays
{
    public static class RemoveRepeatedValues
    {
        public static int[] RemoveDuplicatesFromSortedArray(int[] arrayWithDuplicatedValues)
        {
            if (arrayWithDuplicatedValues is null || arrayWithDuplicatedValues.Length == 0) return new int[0];
            // Array.Sort(nums);

            int arrayLength = arrayWithDuplicatedValues.Length;

            // pointer to last non-duplicate element;
            int pointer = 0;

            // Iterates over the input array from the second element to the last one.
            // For each element, it compares it to the element at the pointer position in the modified array.
            // If the two elements are different, it increments the pointer and assigns the current element to
            //  the position pointed by the pointer in the modified array.
            // This way, the modified array contains only the unique elements of the input array.
            for (int i = 1; i < arrayLength; i++)
            {
                if (arrayWithDuplicatedValues[i] != arrayWithDuplicatedValues[pointer])
                {
                    pointer++;
                    arrayWithDuplicatedValues[pointer] = arrayWithDuplicatedValues[i];
                }
            }

            int[] result = new int[pointer + 1];
            Array.Copy(arrayWithDuplicatedValues, result, pointer + 1);

            return result;
        }

        public static int[] RemoveRepeatedValuesFromArray(int[] arrayWithRepeatedValues)
        {
            if (arrayWithRepeatedValues == null || arrayWithRepeatedValues.Length == 0) return new int[0];

            // HashSet is an efficient data structure in C# for checking for duplicates;
            HashSet<int> set = new HashSet<int>();
            foreach (int num in arrayWithRepeatedValues)
            {
                set.Add(num);
            }

            List<int> uniqueList = new List<int>(set);
            uniqueList.Sort();

            return uniqueList.ToArray();
        }

        public static int[] RemoveRepeatedValuesWithLinq(int[] arrayWithDuplicatedValues)
        {
            if (arrayWithDuplicatedValues is null || arrayWithDuplicatedValues.Length == 0) return new int[0];

            int[] distinctList = arrayWithDuplicatedValues.Distinct().ToArray();

            return distinctList;
        }
    }
}
