namespace Algorithms
{
    public static class MergeArrays
    {
        // You are given two integer arrays, sorted in non-decreasing order;
        // Merge two arrays into a single array sorted in ascending order;

        public static int[] Merge1(int[] inputArray1, int[] inputArray2)
        {
            Array.Sort(inputArray1);
            Array.Sort(inputArray2);

            var result = inputArray1.Where(x => x != 0).Concat(inputArray2.Where(x => x != 0)).ToArray();
            Array.Sort(result);
            return result;
        }

        // You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n,
        //  representing the number of elements in nums1 and nums2 respectively.
        // Merge nums1 and nums2 into a single array sorted in non-decreasing order;
        public static int[] Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            // Initialize pointers for nums1, nums2, and the merged array;
            int p1 = m - 1; // Pointer for nums1;
            int p2 = n - 1; // Pointer for nums2;
            int p = m + n - 1; // Pointer for the merged array;

            // Merge nums1 and nums2 from the end to the beginning;
            while (p1 >= 0 && p2 >= 0)
            {
                if (nums1[p1] > nums2[p2])
                {
                    nums1[p] = nums1[p1];
                    p1--;
                }
                else
                {
                    nums1[p] = nums2[p2];
                    p2--;
                }
                p--;
            }

            // If there are remaining elements in nums2, copy them to nums1;
            while (p2 >= 0)
            {
                nums1[p] = nums2[p2];
                p2--;
                p--;
            }

            return nums1;
        }
    }
}
