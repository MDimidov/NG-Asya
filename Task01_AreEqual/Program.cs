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
        static bool AreEqual<T>(T a, T b)
        {
            // object.Equals сравнява безопасно стойностите (включително null).
            // Equals е името на метода в C#; няма стандартен метод Equal.
            return object.Equals(a, b);
        }

        static void Main(string[] args)
        {
            // Типът T се определя автоматично според аргументите.
            Console.WriteLine(AreEqual(10, 10));             // True
            Console.WriteLine(AreEqual(3.5, 4.5));           // False
            Console.WriteLine(AreEqual("Hello", "Hello"));   // True
        }
    }
}
