using System;

namespace Task047
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 48: Задайте двумерный массив размера m на n, 
            // каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
            // Выведите полученный массив на экран.
            // m = 3, n = 4.
            // 0 1 2 3
            // 1 2 3 4
            // 2 3 4 5

            Console.WriteLine("Введите размер двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            PrintArray(FillArray(M, N));


            int[,] FillArray(int m, int n)
            {
                int[,] array = new int[m,n];
                for(int i = 0; i<m; i++)
                {
                    for(int j = 0; j<n; j++)
                    {
                        array[i,j] = i+j;
                    }
                    
                }
                return array;
            }
           
           void PrintArray(int[,] array1)
           {
            for(int i = 0; i<array1.GetLength(0); i++)
                {
                    for(int j = 0; j<array1.GetLength(1); j++)
                    {
                        Console.Write($"{array1[i,j]} ");
                    }
                    Console.WriteLine( );
                }
           }
        }
    }
}
