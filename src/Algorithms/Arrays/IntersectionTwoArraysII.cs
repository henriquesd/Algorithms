namespace Algorithms.Arrays
{
    // Given two integer arrays nums1 and nums2, return an array of their intersection.
    // Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order;
    public static class IntersectionTwoArraysII
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            // Dictionary to store the count of each element in nums1;
            var counts = new Dictionary<int, int>();

            // Count each element in nums1 and store in the dictionary;
            foreach (int num in nums1)
            {
                if (counts.ContainsKey(num))
                {
                    // Increment the count if the element is already in the dictionary;
                    counts[num]++;
                }
                else
                {
                    // Add the element with count 1 if it is not in the dictionary
                    counts[num] = 1;
                }
            }

            // List to store the intersection result;
            var result = new List<int>();

            // Iterate through nums2 and add common elements to the result list;
            foreach (int num in nums2)
            {
                if (counts.ContainsKey(num) && counts[num] > 0)
                {
                    result.Add(num); // Add the element to the result list;
                    counts[num]--; // Decrement the count for the added element;
                }
            }

            var resultArray = result.ToArray();

            return resultArray;
        }
    }
}