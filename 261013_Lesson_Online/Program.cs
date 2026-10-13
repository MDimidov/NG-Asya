namespace _261013_Lesson_Online
{
    using System;

    public class Program
    {

        public static void Main()

        {

            int[] arry = new int[100];
            Random rand = new Random();

            for (int i = 0; i < arry.Length; i++)
            {
                int curuntnum = rand.Next();
                arry[i] = curuntnum;

            }


            FindMinMaxEvenNum(arry);

        }

        static void FindMinMaxEvenNum(int[] numbers)
        {
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }

                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}
