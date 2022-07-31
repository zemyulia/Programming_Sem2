using System;

namespace Task021
{
    class Program
    {
        static void Main(string[] args)
        {
            
        //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
        //между ними в 3D пространстве.
        // A (3,6,8); B (2,1,-7), -> 15.84
        // A (7,-5, 0); B (1,-1,9) -> 11.53
            
            
            
            Console.WriteLine("Введите координаты точки А в трехмерном пространстве: ");
            double[] arA = new double[3];
            arA[0] = Convert.ToDouble(Console.ReadLine());
            arA[1] = Convert.ToDouble(Console.ReadLine());
            arA[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Точка А с координатами: ({arA[0]}, {arA[1]}, {arA[2]}).");

            Console.WriteLine("Введите координаты точки В в трехмерном пространстве: ");
            double[] arB = new double[3];
            arB[0] = Convert.ToDouble(Console.ReadLine());
            arB[1] = Convert.ToDouble(Console.ReadLine());
            arB[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Точка В с координатами: ({arB[0]}, {arB[1]}, {arB[2]}).");


            double rasst = Math.Sqrt(Math.Pow((arB[0]-arA[0]),2)+Math.Pow((arB[1]-arA[1]),2)+Math.Pow((arB[2]-arA[2]),2));
            Console.WriteLine($"Расстояние между точками составляет: {rasst}");

        }
    }
}
