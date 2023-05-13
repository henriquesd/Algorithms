namespace Algorithms
{
    public static class RemoveRepeatedValuesFromArray
    {
        public static int[] RemoveDuplicatesFromSortedArray(int[] nums)
        {
            if (nums is null || nums.Length == 0) return new int[0];
            // Array.Sort(nums);

            int n = nums.Length;

            // pointer to last non-duplicate element;
            int pointer = 0;

            // Iterates over the input array from the second element to the last one.
            // For each element, it compares it to the element at the pointer position in the modified array.
            // If the two elements are different, it increments the pointer and assigns the current element to
            //  the position pointed by the pointer in the modified array.
            // This way, the modified array contains only the unique elements of the input array.
            for (int i = 1; i < n; i++)
            {
                if (nums[i] != nums[pointer])
                {
                    pointer++;
                    nums[pointer] = nums[i];
                }
            }

            int[] result = new int[pointer + 1];
            Array.Copy(nums, result, pointer + 1);

            return result;
        }

        public static int[] RemoveRepeatedValues(int[] nums)
        {
            if (nums == null || nums.Length == 0) return new int[0];

            // HashSet is an efficient data structure in C# for checking for duplicates;
            HashSet<int> set = new HashSet<int>();
            foreach (int num in nums)
            {
                set.Add(num);
            }

            List<int> uniqueList = new List<int>(set);
            uniqueList.Sort();

            return uniqueList.ToArray();
        }

        public static int[] RemoveRepeatedValuesWithLinq(int[] nums)
        {
            if (nums is null || nums.Length == 0) return new int[0];

            int[] distinctList = nums.Distinct().ToArray();

            return distinctList;
        }
    }
}
