using System;

namespace Task01_AreEqual
{
    internal class Program
    {
        /*
         Задача 1: Проверка за равенство
         Създайте шаблонен метод AreEqual<T>(T a, T b), който връща true,
         ако стойностите са равни. Тествайте с int, double и string.
        */

        // Шаблонният метод AreEqual<T> приема два параметъра от тип T
        static bool AreEqual<T>(T a, T b)
        {
            // object.Equals сравнява безопасно стойностите (включително null).
            // Equals е името на метода в C#.
            return object.Equals(a, b);
        }

        static void Main(string[] args)
        {
            // Типът T се определя от подадения тип в триъгълните скоби <T>.
            Console.WriteLine(AreEqual<int>(10, 10));                // True
            Console.WriteLine(AreEqual<double>(3.5, 4.5));           // False
            Console.WriteLine(AreEqual<string>("Hello", "Hello"));   // True
        }
    }
}
