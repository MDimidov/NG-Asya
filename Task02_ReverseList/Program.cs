using System;
using System.Collections.Generic;

namespace Task02_ReverseList
{
    internal class Program
    {
        /*
         Задача 2: Обръщане на списък
         Създайте ReverseList<T>(List<T> list), който обръща елементите.
         Отпечатайте резултата чрез PrintAll<T>(List<T> list).
        */

        // Шаблонният метод ReverseList<T> приема списък от тип T
        static void ReverseList<T>(List<T> list)
        {
            // Създаваме нов празен списък.
            List<T> reversed = new List<T>();

            // Започваме от последния елемент.
            // Движим се назад, докато стигнем до първия.
            for (int i = list.Count - 1; i >= 0; i--)
            {
                // Добавяме текущия елемент в новия списък.
                reversed.Add(list[i]);
            }

            // Изчистваме оригиналния списък.
            list.Clear();

            // Копираме обърнатите елементи обратно.
            for (int i = 0; i < reversed.Count; i++)
            {
                list.Add(reversed[i]);
            }
        }

        static void PrintAll<T>(List<T> list)
        {
            // С for обхождаме всички елементи по индекс.
            foreach (T item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); // Минаваме на нов ред.
        }

        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            Console.WriteLine("Преди обръщането:");
            PrintAll(numbers);

            ReverseList(numbers); // Променя самия списък.

            Console.WriteLine("След обръщането:");
            PrintAll(numbers);
        }
    }
}
