
using System;
using System.Collections.Generic;

namespace GenericsTask3
{
    internal class Program
    {
        /*
         * Задача 3
         *
         * Условие:
         * Създайте клас ObjectCollection с шаблонен метод
         * CreateList<T>(int count), който създава и връща
         * списък (List<T>) от count нови обекта от тип T.
         *
         * Добавете ограничението where T : new().
         *
         * Пример:
         * List<Item> items = ObjectCollection.CreateList<Item>(3);
         * Console.WriteLine(items.Count); // 3
         */

        static void Main(string[] args)
        {
            // Стъпка 1:
            // Извикваме Generic метода CreateList<T>.
            //
            // Вместо T записваме Item.
            // Това означава, че искаме списък
            // с обекти от класа Item.
            //
            // Числото 3 означава, че искаме
            // да бъдат създадени 3 нови обекта.

            List<Item> items = ObjectCollection.CreateList<Item>(3);

            // Стъпка 2:
            // Count показва колко елемента има списъкът.
            //
            // Тъй като създадохме 3 обекта,
            // резултатът трябва да бъде 3.

            Console.WriteLine($"Брой обекти: {items.Count}");

            Console.WriteLine();

            // Стъпка 3:
            // Обхождаме списъка с for.
            //
            // При всяко завъртане на цикъла
            // принтираме един елеммент от масива.

            for (int i = 0; i < items.Count; i++)
            {
                // Отпечатваме информацията за обекта.
                // Извиква се ToString() от класа Item.

                Console.WriteLine(items[i].ToString());
            }
        }
    }
}
