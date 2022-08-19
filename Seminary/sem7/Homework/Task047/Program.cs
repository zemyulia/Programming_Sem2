using System;

namespace Task047
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 47. Задайте двумерный массив размером m×n, 
            // заполненный случайными вещественными числами.
            // m = 3, n = 4.
            // 0,5 7 -2 -0,2
            // 1 -3,3 8 -9,9
            // 8 7,8 -7,1 9

             Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());


            PrintArray(FillArrayDoubleRandomNumbers(M, N));

            double[,] FillArrayDoubleRandomNumbers(int m, int n)
            {
                double[,] array = new double[m,n];
                Random rand = new Random();
                for(int i = 0; i<m; i++)
                {
                    for(int j = 0; j<n; j++)
                    {
                        array[i,j] = rand.NextDouble()*100; // совершенно не разобралась с NextDouble. 
                    }                                       //Например, как выводить числа с округлением до десятых?
                    
                }
                return array;
            }

            void PrintArray(double[,] array1)
           {
            for(int i = 0; i<array1.GetLength(0); i++)
                {
                    for(int j = 0; j<array1.GetLength(1); j++)
                    {
                        Console.Write($"{array1[i,j]} ");
                    }
                    Console.WriteLine( );
                }
            Console.WriteLine();
           }

        }
    }
}
