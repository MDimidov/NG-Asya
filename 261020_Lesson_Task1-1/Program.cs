namespace _261020_Lesson_Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetLength("Тест"));
        }

        public static int GetLength<T>(T argument)
        {
            int result = 0;
            result = argument.ToString().Length;

            return result;
        }
    }
}
