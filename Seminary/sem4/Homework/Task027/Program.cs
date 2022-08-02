using System;

namespace Task027
{
    class Program
    {
        static void Main(string[] args)
        {
           //  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
           
           
            void Summa()
            {
                Console.WriteLine("Введите число: ");
                int A = Convert.ToInt32(Console.ReadLine());
                
                int remains = 0;
                int i = 0;
                

                while (A>0)
                {
                    remains = A%10+remains;
                    A/=10;
                    i++;
                }

                
                Console.WriteLine($"Количество цифр в числе = {remains}");
            }

            Summa();
        }
    }
}
