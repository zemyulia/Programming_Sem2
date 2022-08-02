using System;

namespace Task026
{
    class Program
    {
        static void Main(string[] args)
        {
        //  Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
        // 456 -> 3
        // 78 -> 2
        // 89126 -> 5
           
           
            void Digits()
            {
                Console.WriteLine("Введите число: ");
                int A = Convert.ToInt32(Console.ReadLine());
                
                int i = 0;
                while (A>0)
                {
                    A = A/10; //A/=10;
                    i++;
                }

                
                Console.WriteLine($"Количество цифр в числе = {i}");



                // Console.WriteLine("Введите число: ");     //Альтернативное решение
                // string A = Console.ReadLine();

                // Console.WriteLine(A.Length);
            }

            Digits();

        }
    }
}
