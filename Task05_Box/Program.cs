using System;

namespace Task05_Box
{
    /*
     Задача 5: Клас Box<T>
     Създайте шаблонен клас с поле Value от тип T и методи
     SetValue(T value) и GetValue(). Тествайте с int, string, double.
    */
    class Box<T>
    {
        // Полето пази една стойност от типа, избран при създаване на Box.
        public T Value = default!;

        public void SetValue(T value)
        {
            Value = value; // Записваме получената стойност.
        }

        public T GetValue()
        {
            return Value; // Връщаме вече записаната стойност.
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> intBox = new Box<int>();
            intBox.SetValue(100);

            Box<string> stringBox = new Box<string>();
            stringBox.SetValue("Hello");

            Box<double> doubleBox = new Box<double>();
            doubleBox.SetValue(3.14);

            // Един и същ клас работи с различни типове.
            Console.WriteLine(intBox.GetValue());
            Console.WriteLine(stringBox.GetValue());
            Console.WriteLine(doubleBox.GetValue());
        }
    }
}
