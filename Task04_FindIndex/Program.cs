using System;
using System.Collections.Generic;

namespace Task04_FindIndex
{
    internal class Program
    {
        /*
         Задача 4: Намиране на индекс
         Създайте FindIndex<T>(List<T> list, T value), който връща
         индекса на първия намерен елемент или -1, ако липсва.
        */
        static int FindIndex<T>(List<T> list, T value)
        {
            // Индексите започват от 0, а не от 1.
            for (int i = 0; i < list.Count; i++)
            {
                // object.Equals сравнява две стойности от един и същ тип.
                if (object.Equals(list[i], value))
                {
                    return i; // Намерихме елемента - връщаме индекса.
                }
            }
            return -1; // Стигнахме края, без да намерим стойността.
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Ivan", "Maria", "Peter", "Georgi" };
            Console.WriteLine("Peter: " + FindIndex(names, "Peter"));     // 2
            Console.WriteLine("Nikolay: " + FindIndex(names, "Nikolay")); // -1
        }
    }
}
