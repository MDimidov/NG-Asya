
using System;

namespace GenericsTask2
{
    internal class Program
    {
        /*
         * Задача 2
         *
         * Условие:
         * Създайте шаблонен метод CompareValues<T>(T a, T b)
         * с ограничение where T : IComparable<T>.
         *
         * Методът трябва:
         * 1. Да приема две стойности от един и същи тип.
         * 2. Да сравнява двете стойности.
         * 3. Да отпечатва коя стойност е по-голяма,
         *    по-малка или дали са равни.
         *
         * Пример:
         * CompareValues(5, 8);
         * CompareValues("a", "z");
         */

        static void Main(string[] args)
        {
            // Сравняваме две цели числа.
            // T автоматично става int.

            CompareValues<int>(5, 8);

            Console.WriteLine();

            // Сравняваме два текста.
            // T автоматично става string.

            CompareValues<string>("a", "z");

            Console.WriteLine();

            CompareValues<string>("logic", "lesson");

            Console.WriteLine();

            // Сравняваме две еднакви числа.

            CompareValues<int>(10, 10);
        }

        // Какво означава <T>?
        //
        // T е заместител на тип данни.
        //
        // Например:
        // CompareValues(5, 8)     -> T е int
        // CompareValues("a", "z") -> T е string
        //
        // Така използваме един метод за различни типове.

        // Какво означава where T : IComparable<T>?
        //
        // Това е ограничение за Generic типа T.
        //
        // То казва:
        // "Позволяваме само типове, чиито стойности
        // могат да бъдат сравнявани."
        //
        // Например int, double и string поддържат
        // сравнение чрез IComparable<T>.
        //
        // IComparable<T> е интерфейс, който
        // предоставя метода CompareTo().

        static void CompareValues<T>(T a, T b)
            where T : IComparable<T>
        {
            // Стъпка 1:
            // Сравняваме двете стойности.
            //
            // CompareTo() връща цяло число:
            //
            // Отрицателно число -> a е по-малко от b
            // 0                 -> a и b са равни
            // Положително число -> a е по-голямо от b
            //
            // Например:
            // 5.CompareTo(8)  -> отрицателно число
            // 8.CompareTo(5)  -> положително число
            // 5.CompareTo(5)  -> 0

            int result = a.CompareTo(b);

            // Стъпка 2:
            // Проверяваме резултата от сравнението.

            if (result > 0)
            {
                // Ако резултатът е положителен,
                // първата стойност е по-голяма.

                Console.WriteLine($"{a} е по-голямо от {b}");
            }
            else if (result < 0)
            {
                // Ако резултатът е отрицателен,
                // първата стойност е по-малка.

                Console.WriteLine($"{a} е по-малко от {b}");
            }
            else
            {
                // Ако резултатът е 0,
                // двете стойности са равни.

                Console.WriteLine($"{a} и {b} са равни");
            }
        }
    }
}
