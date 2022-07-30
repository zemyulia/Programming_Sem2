using System;

namespace Task021
{
    class Program
    {
        static void Main(string[] args)
        {


            // Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
            // и находит расстояние между ними в 2D пространстве.
            // A (3,6); B (2,1) -> 5,09
            // A (7,-5); B (1,-1) -> 7,21


            Console.WriteLine("Введите координаты точки А");
            double Ax = Convert.ToDouble(Console.ReadLine());
            double Ay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки B");
            double Bx = Convert.ToDouble(Console.ReadLine());
            double By = Convert.ToDouble(Console.ReadLine());


            double rasst = Math.Sqrt(Math.Pow((Bx-Ax),2)+Math.Pow((By-Ay),2));
            Console.WriteLine(rasst);
            
        }
    }
}
