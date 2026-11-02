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
        static void ReverseList<T>(List<T> list)
        {
            // i започва от първия елемент, а j - от последния.
            // Разменяме срещуположните елементи, докато стигнем средата.
            for (int i = 0, j = list.Count - 1; i < j; i++, j--)
            {
                T temp = list[i]; // Запазваме временно първата стойност.
                list[i] = list[j]; // Поставяме последната отпред.
                list[j] = temp;    // Поставяме запазената стойност отзад.
            }
        }

        static void PrintAll<T>(List<T> list)
        {
            // С for обхождаме всички елементи по индекс.
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
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
