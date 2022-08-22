using System;

namespace Task053
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 53: Задайте двумерный массив. Напишите программу, 
            // которая поменяет местами первую и последнюю строку массива.

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Arr = FillArrayRandomNumbers(M, N);
            PrintArray(Arr);
            PrintArray(ModifiedArray(Arr));


            int[,] FillArrayRandomNumbers(int m, int n, int LeftRange = 0, int RightRange = 100)
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

            int[,] ModifiedArray (int[,] arr)
            {
                int temp = 0;
                for(int i=0; i<arr.GetLength(0); i++)
                {
                    temp = arr[0, i];
                    arr[0, i] = arr[arr.GetLength(0)-1, i];
                    arr[arr.GetLength(0)-1, i] = temp;
                }
                return arr;
            }
        }
    }
}
