using System;

namespace Task067
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 67: Напишите программу, которая будет принимать на вход число 
            // и возвращать сумму его цифр.
            // 453 -> 12
            // 45 -> 9

            int SummaOfDigits(int n)
            {
                if(n>9) return n%10 + SummaOfDigits(n/10);
                else return n;
            }

            Console.WriteLine(SummaOfDigits(45));

        }
    }
}
