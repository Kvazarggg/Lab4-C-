using System;

namespace Lab4
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        // Метод для сокращения дроби
        public void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;
        }

        // Метод вывода дроби
        public void PrintFraction()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }

        // Операторы перегрузки для сложения, вычитания, умножения и деления дробей
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.numerator;
            int denom = f1.denominator * f2.denominator;
            return new Fraction(num, denom);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            int num = f1.numerator * f2.denominator;
            int denom = f1.denominator * f2.numerator;
            return new Fraction(num, denom);
        }

        // Метод для вычисления наибольшего общего делителя
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}