
using System;

namespace GenericsTask4
{
    internal class Program
    {
        /*
         * Задача 4
         *
         * Условие:
         * Създайте шаблонен метод CheckAndPrint<T>(T obj)
         * с ограничение where T : class
         *
         * Методът трябва:
         * 1. Да проверява дали обектът е null.
         * 2. Ако не е null, да отпечата:
         *    - Името на типа
         *    - Стойността чрез ToString()
         *
         * Пример:
         * string text = "C# Generics";
         * CheckAndPrint(text);
         * CheckAndPrint<string>(null);
         */

        static void Main(string[] args)
        {
            // Създаваме променлива от тип string.

            string text = "C# Generics";

            // Извикваме метода с нашия текст.
            // T автоматично става string.

            CheckAndPrint<string>(text);

            Console.WriteLine();

            // Извикваме метода с null.
            //
            // null означава, че няма обект.
            //
            // Посочваме <string>, защото компилаторът
            // не може сам да разбере типа само от null.

            CheckAndPrint<string>(null);
        }

        // Какво означава <T>
        //
        // T е заместител на тип данни.
        //
        // Например:
        // CheckAndPrint("Hello") -> T е string
        //
        // Това ни позволява да използваме
        // един метод за различни типове.

        // Какво означава where T : class
        //
        // Това е ограничение.
        //
        // То казва, че T трябва да бъде
        // референтен тип.
        //
        // Например:
        // string -> позволен
        // int    -> не е позволен
        //
        // Референтните типове могат да имат
        // стойност null.

        static void CheckAndPrint<T>(T obj) where T : class
        {
            // Стъпка 1:
            // Проверяваме дали обектът е null.
            //
            // Ако е null, няма стойност,
            // която да отпечатаме.

            if (obj == null)
            {
                Console.WriteLine("Обектът е null!");

                // return прекратява метода,
                // за да не изпълняваме кода отдолу.

                return;
            }

            // Стъпка 2:
            // GetType() намира типа на обекта.
            //
            // .Name взема името на този тип.
            //
            // Например:
            // "C# Generics" -> String

            Console.WriteLine($"Тип: {obj.GetType().Name}");

            // Стъпка 3:
            // ToString() превръща стойността в текст.
            //
            // При string връща самия текст.

            Console.WriteLine($"Стойност: {obj.ToString()}");
        }
    }
}
