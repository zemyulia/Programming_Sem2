using System;

namespace Task040
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
            // может ли существовать треугольник с сторонами такой длины.
            // Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

            Console.WriteLine("Введите 3 числа, длины сторон треугольника: ");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());

            void TrianglMethod (int a, int b, int c)
            {
                if(a<b+c && b<c+a && c<a+b) Console.WriteLine("Данный треугольник может существовать."); 
                else Console.WriteLine("Данный треугольник не может существовать."); 
            }

            TrianglMethod(A, B, C);
            
        }
    }
}
