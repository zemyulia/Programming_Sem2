using System;

namespace Task043
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
            // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
            // значения b1, k1, b2 и k2 задаются пользователем.
            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


            
            Console.WriteLine("Введите параметры первой прямой");
            double B1 = Convert.ToDouble(Console.ReadLine());
            double K1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите параметры второй прямой");
            double B2 = Convert.ToDouble(Console.ReadLine());
            double K2 = Convert.ToDouble(Console.ReadLine());

            double X = (B2-B1)/(K1-K2);
            double Y = K1*X + B1;
            Console.WriteLine($"Координата точки пересечения двух прямых: ({X}, {Y}).");
        }
    }
}
