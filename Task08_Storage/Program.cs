using System;
using System.Collections.Generic;

namespace Task08_Storage
{
    /*
     Задача 8: Клас Storage<T>
     Създайте List<T> items и методи AddItem, RemoveItem, PrintAll.
    */

    // Създаваме шаблонен клас с един тип T
    class Storage<T>
    {
        // private означава, че списъкът е достъпен само вътре в класа.
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item); // Добавяме новия елемент накрая.
        }

        public void RemoveItem(T item)
        {
            items.Remove(item); // Премахваме първото съвпадение, ако има такова.
        }

        public void PrintAll()
        {
            foreach (T item in items)
            {
                Console.WriteLine(item); // Отпечатваме всеки елемент на нов ред.
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<string> storage = new Storage<string>();
            storage.AddItem("Ivan");
            storage.AddItem("Maria");
            storage.AddItem("Peter");

            Console.WriteLine("Преди премахване:");
            storage.PrintAll();

            storage.RemoveItem("Maria");
            
            Console.WriteLine("След премахване:");
            storage.PrintAll();
        }
    }
}
