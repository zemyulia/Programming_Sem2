using System;

namespace Task064
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 64: Задайте значение N. Напишите программу, 
            // которая выведет все натуральные числа в промежутке от N до 1.
            // N = 5 -> "5, 4, 3, 2, 1"
            // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

            string NaturalNumbers (int n)
            {
                if(n>0) return $"{n} " + $"{NaturalNumbers(n-1)}";
                else return String.Empty;
            }

            Console.WriteLine(NaturalNumbers(8));
        }
    }
}
