using System;

namespace Task025
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
            //и возводит число A в натуральную степень B.
            // 3, 5 -> 243 (3⁵)
            // 2, 4 -> 16
            // Использование Math.Pow() и аналогов = Ban :)
            
            void Exponention()
            {
                Console.WriteLine("Введите число А: ");
                int NumA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B: ");
                int ExpB = Convert.ToInt32(Console.ReadLine());

                int AExpB = 1;

                for (int i = 0; i < ExpB; i++)
                {
                    AExpB = AExpB * NumA;
                }

                Console.WriteLine($"А в степени В = {AExpB}");
            }

            Exponention();
        }
    }
}
