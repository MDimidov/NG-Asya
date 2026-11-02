using System;

namespace Task11_DataPair
{
    /*
     Задача 11: Клас DataPair<T1, T2> с метод Swap<T>
     Класът пази две стойности. Методът може да разменя
     стойности от произволен тип с помощта на ref.
    */
    class DataPair<T1, T2>
    {
        public T1 First;
        public T2 Second;

        public DataPair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void Swap<T>(ref T x, ref T y)
        {
            // T е независим от T1 и T2 и се определя при извикване.
            T temp = x;
            x = y;
            y = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DataPair<string, int> pair = new DataPair<string, int>("Ivan", 18);
            Console.WriteLine($"{pair.First} - {pair.Second}");

            int a = 10, b = 20;
            pair.Swap(ref a, ref b); // Тук T = int.
            Console.WriteLine($"int: {a}, {b}");

            string x = "Hello", y = "World";
            pair.Swap(ref x, ref y); // Тук T = string.
            Console.WriteLine($"string: {x}, {y}");
        }
    }
}
