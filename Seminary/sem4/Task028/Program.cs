using System;

namespace Task028
{
    class Program
    {
        static void Main(string[] args)


        // Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
        // 4 -> 24 
        // 5 -> 120


        {   
            void Factorial()
            {

                Console.WriteLine("Введите число:");
                int Num = Convert.ToInt32(Console.ReadLine());
                int factorial = 1;
                

                while(Num!=0)
                {
                    factorial = factorial * Num;
                    Num = Num-1;
                    
                }

                Console.WriteLine($" Факториал данного числа = {factorial}");
            }

            Factorial();
        }
    }
}
