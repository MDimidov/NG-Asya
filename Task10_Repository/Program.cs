
using System;
using System.Collections.Generic;

namespace Task10_Repository
{
    /*
     Задача 1: Клас Repository<T> с шаблонен метод за търсене

     Условие:
     Създайте клас Repository<T>, който съдържа списък items.

     Добавете шаблонен метод Find<U>(U key), който може
     да приема ключ от различен тип.

     В нашия пример:
     - Ако ключът е string, търсим ученик по име.
     - Ако ключът е int, търсим ученик по индекс.
    */

    class Repository<T>
    {
        // Създаваме празен списък от тип T.
        // T означава, че можем да съхраняваме различни типове.
        private List<T> items = new List<T>();

        // Метод за добавяне на нов елемент в списъка.
        public void Add(T item)
        {
            items.Add(item);
        }

        // Шаблонен метод за търсене.
        // U е типът на ключа, по който търсим.
        public void Find<U>(U key)
        {
            // Проверяваме дали ключът е цяло число.
            // За това ни помага ключовата дума is, която проверява типа на обекта.
            if (key is int)
            {
                // Превръщаме ключа в int.
                int index = Convert.ToInt32(key);

                // Проверяваме дали индексът съществува.
                if (index >= 0 && index < items.Count)
                {
                    Console.WriteLine("Намерен: " + items[index]);
                }
                else
                {
                    Console.WriteLine("Няма ученик с този индекс!");
                }
            }
            else
            {
                // Ако ключът не е число, търсим по стойност.

                // Обхождаме всички елементи.
                for (int i = 0; i < items.Count; i++)
                {
                    // Сравняваме текста на елемента с ключа.
                    if (items[i]?.ToString() == key?.ToString())
                    {
                        Console.WriteLine("Намерен: " + items[i]);
                        return;
                    }
                }

                Console.WriteLine("Няма намерен ученик!");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаваме хранилище за имена на ученици.
            Repository<string> students = new Repository<string>();

            // Добавяме ученици.
            students.Add("Ivan");
            students.Add("Maria");
            students.Add("Peter");
            students.Add("Georgi");

            // Търсим по име (string).
            students.Find<string>("Maria");

            // Търсим по индекс (int).
            students.Find<int>(2);

            // Търсим несъществуващо име.
            students.Find<string>("Nikolay");

            // Търсим несъществуващ индекс.
            students.Find<int>(10);
        }
    }
}
