namespace Algorithms
{
    public class Staircase
    {
        // Starcase - it will print in new lines, n times the "#" sign, with spaces on the left side

        public static void ExecuteExample1(int n)
        {
            string sign = "#";

            for (int i = 0; i < n; i++)
            {
                string stringToAdd = "";
                for (int z = 0; z <= i; z++)
                {
                    stringToAdd += sign;
                }

                string toBePrinted = stringToAdd.PadLeft(n);
                Console.WriteLine(toBePrinted);
            }
        }

        public static void ExecuteExample2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
