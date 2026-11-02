using System;
using System.Collections.Generic;

namespace Task12_Statistics
{
    /*
     Задача 12: Клас Statistics<T> с шаблонни методи
     AddValue(T value), GetMax<T>() и GetAverage<U>().
     В C# не можем да обявим втори параметър T в GetMax<T>(),
     когато класът вече използва T. Затова тук методът е GetMax<U>().
     За да остане просто, извикваме GetMax<U>() с U = T.
    */
    class Statistics<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        public void AddValue(T value)
        {
            items.Add(value); // Съхраняваме следващата стойност.
        }

        public U GetMax<U>()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Списъкът е празен!");
            }

            T max = items[0]; // Начална максимална стойност.
            for (int i = 1; i < items.Count; i++)
            {
                if (items[i].CompareTo(max) > 0)
                {
                    max = items[i]; // Намерили сме по-голям елемент.
                }
            }

            // U трябва да е съвместим с T; в Main използваме същия тип.
            return (U)(object)max!;
        }

        public double GetAverage<U>()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Списъкът е празен!");
            }

            double sum = 0;
            foreach (T item in items)
            {
                // Работи с int, double и decimal, но не с обикновен текст.
                sum += Convert.ToDouble(item);
            }
            return sum / items.Count; // Средно = сбор / брой.
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Statistics<int> numbers = new Statistics<int>();
            numbers.AddValue(10);
            numbers.AddValue(20);
            numbers.AddValue(30);
            Console.WriteLine("Максимум: " + numbers.GetMax<int>());
            Console.WriteLine("Средно: " + numbers.GetAverage<int>());

            Statistics<double> decimals = new Statistics<double>();
            decimals.AddValue(1.5);
            decimals.AddValue(2.5);
            Console.WriteLine("Средно double: " + decimals.GetAverage<double>());

            Statistics<string> words = new Statistics<string>();
            words.AddValue("Apple");
            words.AddValue("Orange");
            words.AddValue("Banana");
            // За string максимумът е по реда на сравняване на низове.
            Console.WriteLine("Максимален текст: " + words.GetMax<string>());
            // Не извикваме GetAverage за думи - няма смисъл да ги събираме.
        }
    }
}
