using System;

namespace Task023
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 23
            // Напишите программу, которая принимает на вход число (N)
            //  и выдаёт таблицу кубов чисел от 1 до N.
            // 3 -> 1, 8, 27
            // 5 -> 1, 8, 27, 64, 125

            Console.WriteLine("Введите число: ");
            int MyNum = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            Console.Write("Таблица кубов данного числа: |");

            for(int i = 0; i<=MyNum; i++)
            {
                res = i*i*i;
                Console.Write($"{res} |");
            }

        }
    }
}
