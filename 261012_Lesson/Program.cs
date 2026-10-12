namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArry = new int[10_000_000];

            for (int i = 0; i < numbersArry.Length; i++)
            {
                numbersArry[i] = i % 1000 + 1;
            }

            int maxNum = numbersArry[0];

            for (int i = 0; i < numbersArry.Length; i++)
            {
                if (maxNum < numbersArry[i])
                {
                    maxNum = numbersArry[i];
                }
            }

            Print(maxNum);
        }

        static void Print(int maxNum)
        {
            Console.WriteLine(maxNum);

        }
    }
}

