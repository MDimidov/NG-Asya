using System;

namespace Task03_Swap
{
    internal class Program
    {
        /*
         Задача 3: Универсален метод за размяна
         Създайте Swap<T>(ref T a, ref T b), който разменя две стойности.
         Тествайте с int, string и double.
        */
        static void Swap<T>(ref T a, ref T b)
        {
            // ref позволява да променим оригиналните променливи от Main.
            T temp = a; // Запазваме старата стойност на a.
            a = b;      // Копираме стойността на b в a.
            b = temp;   // Поставяме старата стойност на a в b.
        }

        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine($"int: {a}, {b}");

            string first = "Hello", second = "World";
            Swap(ref first, ref second);
            Console.WriteLine($"string: {first}, {second}");

            double x = 1.5, y = 2.5;
            Swap(ref x, ref y);
            Console.WriteLine($"double: {x}, {y}");
        }
    }
}
