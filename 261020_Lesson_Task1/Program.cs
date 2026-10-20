namespace _261020_Lesson_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Ela";

            Console.WriteLine(GetLength<string>("Програмиране"));
            Console.WriteLine(GetLength<string>(text));
            Console.WriteLine(GetLength<double>(000.12345));
        }


        static int GetLength<T>(T argument)
        {
            int result = 0;

            string input = argument.ToString();

            result = input.Length;

            Console.WriteLine(argument.GetType().Name);
            Console.WriteLine(argument);

            return result;
        }
    }
}
