using System;

namespace Task052
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 52. Задайте двумерный массив из целых чисел. 
            // Найдите среднее арифметическое элементов в каждом столбце.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Array = FillArrayRandomNumbers(M, N);
            PrintArray(Array);
            AverageByColumns(Array);

            int[,] FillArrayRandomNumbers(int m, int n, int LeftRange = 0, int RightRange = 10)
            {
                int[,] array = new int[m,n];
                Random rand = new Random();
                for(int i = 0; i<m; i++)
                {
                    for(int j = 0; j<n; j++)
                    {
                        array[i,j] = rand.Next(LeftRange, RightRange);
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
            Console.WriteLine();
           }

            void AverageByColumns(int[,] arr)
            {   
                decimal[] Averages = new decimal[arr.GetLength(1)];
                for(int i = 0; i<arr.GetLength(1); i++)
                {
                    decimal sum = 0;
                    for(int j = 0; j<arr.GetLength(0); j++)
                    {
                        sum = (sum + arr[j,i]);
                        Averages[i] = sum/(arr.GetLength(0));
                    }  
                }
                Console.WriteLine($"Среднее арифметическое каждого столбца:" + String.Join("; ", Averages));
            }
        }
    }
}
