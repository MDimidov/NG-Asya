namespace _261020_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            CompareValues("nuz1", "num5");
        }

        public static void CompareValues<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) < 0)
            {
                Console.WriteLine(a + " < " + b);
            }
            else if (a.CompareTo(b) > 0)
            {
                Console.WriteLine(a + " > " + b);
            }
            else
            {
                Console.WriteLine(a + " = " + b);
            }
        }
    }
}
