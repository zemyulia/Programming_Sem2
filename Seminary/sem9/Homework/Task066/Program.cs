using System;

namespace Task066
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 66: Задайте значения M и N. Напишите программу, 
            // которая найдёт сумму натуральных элементов в промежутке от M до N.
            // M = 1; N = 15 -> 120
            // M = 4; N = 8. -> 30

            int SummaOfNaturalNumbers(int m, int n)
            {
                int summa = 0;
                if(m<n) return summa = summa + m + SummaOfNaturalNumbers(m+1, n);
                else return n;
            }

            Console.WriteLine(SummaOfNaturalNumbers(4,8));
        }
    }
}
