using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Исходные данные
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);
            Fraction fraction3 = new Fraction(5, 6);
            Fraction fraction4 = new Fraction(7, 8);
            Fraction fraction5 = new Fraction(9, 10);

            // Вычисление выражения
            Fraction result = (((fraction1 + fraction2) / fraction3) * (fraction4 - fraction5));

            // Вывод несокращенной дроби
            Console.WriteLine("Несокращенная дробь:");
            result.PrintFraction();

            // Сокращение дроби и вывод
            result.Reduce();
            Console.WriteLine("Сокращенная дробь:");
            result.PrintFraction();
        }
    }
}
