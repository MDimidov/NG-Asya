using System;

namespace Task09_Range
{
    /*
     Задача 9: Клас Range<T>
     Класът има Start, End и Contains(T value).
     Проверете дали стойността е в затворения диапазон [Start, End].
     Тествайте int и double.
    */

    // Ограничението where T : IComparable<T> позволява да сравняваме стойности.
    class Range<T> where T : IComparable<T>
    {
        public T Start;
        public T End;

        public Range(T start, T end)
        {
            Start = start;
            End = end;
        }

        public bool Contains(T value)
        {
            // CompareTo връща 0 за равни и знак според подредбата.
            // >= 0 означава value >= Start; <= 0 означава value <= End.
            return value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // За правилен диапазон приемаме Start <= End.
            Range<int> ints = new Range<int>(1, 10);
            Console.WriteLine(ints.Contains(5));    // True
            Console.WriteLine(ints.Contains(15));   // False

            Range<double> doubles = new Range<double>(1.5, 5.5);
            Console.WriteLine(doubles.Contains(3.5)); // True
            Console.WriteLine(doubles.Contains(7.5)); // False
        }
    }
}
