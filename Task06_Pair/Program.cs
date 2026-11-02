using System;

namespace Task06_Pair
{
    /*
     Задача 6: Клас Pair<T1, T2>
     Съхранявайте две стойности от (възможно) различни типове.
     Добавете метод PrintPair() за отпечатване на двойката.
    */

    // Създаваме шаблонен клас с два типа T1 и T2.
    class Pair<T1, T2>
    {
        public T1 First;
        public T2 Second;

        // Конструкторът се изпълнява, когато създаваме нов обект.
        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public void PrintPair()
        {
            Console.WriteLine($"{First} - {Second}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // T1 е string (име), а T2 е int (възраст).
            Pair<string, int> student = new Pair<string, int>("Ivan", 18);
            student.PrintPair();

            // Можем да зададем и други два типа.
            Pair<int, double> numbers = new Pair<int, double>(10, 5.5);
            numbers.PrintPair();
        }
    }
}
