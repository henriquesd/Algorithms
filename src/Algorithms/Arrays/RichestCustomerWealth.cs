namespace Algorithms.Arrays
{
    /// <summary>
    /// Given an m x n integer grid accounts where accounts[i][j] is the amount of money the i-th customer has in the j-th bank,
    /// it calculates and returns the wealth that the richest customer has.
    /// A customer's wealth is the amount of money they have in all their bank accounts,
    /// the richest customer is the customer that has the maximum wealth.
    /// </summary>
    public static class RichestCustomerWealth
    {
        public static int MaximumWealthExample1(int[][] accounts)
        {
            int numberOfAccounts = accounts.Length;
            int[] sumPerAccount = new int[accounts.Length];

            for (int i = 0; i < numberOfAccounts; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                {
                    sumPerAccount[i] += accounts[i][j];
                }
            }

            int maxValue = 0;

            for (int i = 0; i < numberOfAccounts; i++)
            {
                if (sumPerAccount[i] > maxValue)
                {
                    maxValue = sumPerAccount[i];
                }
            }

            return maxValue;
        }

        public static int MaximumWealthExample2(int[][] accounts)
        {
            int numberOfAccounts = accounts.Length;
            int maxValue = 0;

            for (int i = 0; i < numberOfAccounts; i++)
            {
                int currentSum = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {
                    currentSum += accounts[i][j];
                }

                if (currentSum > maxValue)
                {
                    maxValue = currentSum;
                }
            }

            return maxValue;
        }

        public static int MaximumWealthWithLinq(int[][] accounts)
        {
            return accounts.Select(customerAccounts => customerAccounts.Sum()).Max();
        }
    }
}
