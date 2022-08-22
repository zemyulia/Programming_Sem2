using System;

namespace Task055
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 55: Задайте двумерный массив. Напишите программу, 
            // которая заменяет строки на столбцы. В случае, если это невозможно, 
            // программа должна вывести сообщение для пользователя.

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Array = FillArrayRandomNumbers(M,N);
            PrintArray(Array);
            PrintArray(ColumnsInsteadOfRowsArray(Array));

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

            int[,] ColumnsInsteadOfRowsArray(int[,] array)
            {
                int[,] arr = new int[array.GetLength(1), array.GetLength(0)];
                for(int i = 0; i<array.GetLength(0); i++)
                    {
                        for(int j = 0; j<array.GetLength(1); j++)
                        {
                            arr[j,i] = array[i,j];
                        }
                    }
                return arr;
            }
        }
    }
}
