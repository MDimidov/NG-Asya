
using System;
using System.Collections.Generic;

namespace Task12_Statistics
{
    /*
     Задача 3: Клас Statistics<T>

     Условие:
     Създайте шаблонен клас Statistics<T>,
     който съдържа списък от елементи.

     Създайте следните методи:

     1. AddValue(T value)
        Добавя нов елемент в списъка.

     2. GetMax<U>()
        Намира най-големия елемент в списъка.

     3. GetAverage<U>()
        Изчислява средно аритметично.

     Тествайте с int, double, decimal и string.
    */

    class Statistics<T>
    {
        // Създаваме празен списък.
        // T определя какъв тип стойности ще съхраняваме.
        private List<T> items = new List<T>();


        // Метод за добавяне на нова стойност.
        public void AddValue(T value)
        {
            items.Add(value);
        }


        // Метод за намиране на най-голямата стойност.

        public T GetMax<U>()
        {
            // Приемаме, че първият елемент е най-голям.
            T max = items[0];

            // Обхождаме останалите елементи.
            for (int i = 1; i < items.Count; i++)
            {
                // Проверяваме дали типът на елементите е string.
                if (typeof(T) == typeof(string))
                {
                    // Ако имаме текст, сравняваме думите
                    // според азбучния им ред.
                    if (string.Compare(items[i]?.ToString(), max?.ToString()) > 0)
                    {
                        max = items[i];
                    }
                }
                else
                {
                    // Ако имаме числа, ги преобразуваме в double.
                    double current = Convert.ToDouble(items[i]);
                    double maximum = Convert.ToDouble(max);

                    // Проверяваме кое число е по-голямо.
                    if (current > maximum)
                    {
                        max = items[i];
                    }
                }
            }

            // Връщаме най-големия елемент.
            return max;
        }


        // Метод за изчисляване на средно аритметично.
        public double GetAverage<U>()
        {
            // Променлива, която пази сбора.
            double sum = 0;

            // Обхождаме всички елементи.
            for (int i = 0; i < items.Count; i++)
            {
                // Превръщаме текущата стойност в double.
                double number = Convert.ToDouble(items[i]);

                // Добавяме числото към общия сбор.
                sum = sum + number;
            }

            // Делим сбора на броя елементи.
            double average = sum / items.Count;

            // Връщаме средното аритметично.
            return average;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // ==================================
            // ПРИМЕР 1: Цели числа (int)
            // ==================================

            Statistics<int> numbers = new Statistics<int>();

            numbers.AddValue(10);
            numbers.AddValue(20);
            numbers.AddValue(30);

            Console.WriteLine("Цели числа:");

            Console.WriteLine("Най-голямо: " + numbers.GetMax<int>());
            Console.WriteLine("Средно: " + numbers.GetAverage<int>());


            // ==================================
            // ПРИМЕР 2: Дробни числа (double)
            // ==================================

            Statistics<double> decimals = new Statistics<double>();

            decimals.AddValue(2.5);
            decimals.AddValue(3.5);
            decimals.AddValue(6.0);

            Console.WriteLine("Дробни числа:");

            Console.WriteLine("Най-голямо: " + decimals.GetMax<double>());
            Console.WriteLine("Средно: " + decimals.GetAverage<double>());


            // ==================================
            // ПРИМЕР 3: Числа от тип decimal
            // ==================================

            Statistics<decimal> prices = new Statistics<decimal>();

            prices.AddValue(10m);
            prices.AddValue(20m);
            prices.AddValue(30m);

            Console.WriteLine("Decimal числа:");

            Console.WriteLine("Най-голямо: " + prices.GetMax<decimal>());
            Console.WriteLine("Средно: " + prices.GetAverage<decimal>());


            // ==================================
            // ПРИМЕР 4: Текст (string)
            // ==================================

            Statistics<string> words = new Statistics<string>();

            words.AddValue("Apple");
            words.AddValue("Orange");
            words.AddValue("Banana");

            Console.WriteLine("Текстови стойности:");

            // При текст търсим най-голямата
            // стойност според азбучното сравнение.
            Console.WriteLine("Най-голямо: " + words.GetMax<string>());

            // Не изчисляваме средно аритметично
            // на думи, защото те не са числа.
        }
    }
}
