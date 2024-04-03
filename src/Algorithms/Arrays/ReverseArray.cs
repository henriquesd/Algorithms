namespace Algorithms.Arrays
{
    public static class ReverseArray
    {
        public static int[] ReverseArrayIntoNewArray(int[] inputArray)
        {
            int[] reversedArray = new int[inputArray.Length];

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = inputArray[inputArray.Length - i - 1];
            }

            return reversedArray;
        }
    }
}