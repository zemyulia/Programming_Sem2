using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 7.");
            int Num = Convert.ToInt32(Console.ReadLine());

            if(Num<8 && Num>0)
            {
                if(Num<6) 
                {
                    Console.WriteLine("Этот день недели не является выходным.");
                }
                else
                {
                    Console.WriteLine("Этот день недели является выходным.");
                }
            }
            else Console.WriteLine("Введенное число не соответствует условиям задачи.");
        }
    }
}
