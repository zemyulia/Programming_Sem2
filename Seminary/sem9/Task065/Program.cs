using System;

namespace Task065
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 65: Задайте значения M и N. 
            // Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
            // M = 1; N = 5 -> "1, 2, 3, 4, 5"
            // M = 4; N = 8 -> "4, 5, 6, 7, 8"

            string NaturalNumbers(int m, int n)
            {
                if(m<=n) return $"{m} " + NaturalNumbers(m+1,n);
                else return String.Empty;
            }

            Console.WriteLine(NaturalNumbers(4,8));
        }
    }
}
