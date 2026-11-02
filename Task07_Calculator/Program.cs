using System;

namespace Task07_Calculator
{
    /*
     Задача 7: Клас Calculator<T>
     Реализирайте Add, Subtract, Multiply, Divide за числови типове,
     като използвате Convert.ToDouble(). Тествайте int, double, decimal.
     Важно: преобразуването на decimal към double може да загуби точност.
    */
    class Calculator<T>
    {
        public double Add(T a, T b)
        {
            // Преобразуваме двете стойности до double и ги събираме.
            return Convert.ToDouble(a) + Convert.ToDouble(b);
        }

        public double Subtract(T a, T b)
        {
            return Convert.ToDouble(a) - Convert.ToDouble(b);
        }

        public double Multiply(T a, T b)
        {
            return Convert.ToDouble(a) * Convert.ToDouble(b);
        }

        public double Divide(T a, T b)
        {
            double divisor = Convert.ToDouble(b);
            // Делението на нула не е позволено в тази задача.
            if (divisor == 0)
            {
                throw new DivideByZeroException("Не може да се дели на нула!");
            }
            return Convert.ToDouble(a) / divisor;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator<int> wholeNumbers = new Calculator<int>();
            Console.WriteLine("Събиране: " + wholeNumbers.Add(10, 5));
            Console.WriteLine("Изваждане: " + wholeNumbers.Subtract(10, 5));
            Console.WriteLine("Умножение: " + wholeNumbers.Multiply(10, 5));
            Console.WriteLine("Деление: " + wholeNumbers.Divide(10, 5));

            Calculator<double> doubles = new Calculator<double>();
            Console.WriteLine("double: " + doubles.Add(2.5, 3.5));

            Calculator<decimal> decimals = new Calculator<decimal>();
            Console.WriteLine("decimal: " + decimals.Multiply(2.5m, 4m));
            // Суфиксът m означава, че числото е от тип decimal.
        }
    }
}
