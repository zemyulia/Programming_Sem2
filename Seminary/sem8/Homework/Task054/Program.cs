using System;

namespace Task054
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
            // элементы каждой строки двумерного массива.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // В итоге получается вот такой массив:
            // 1 2 4 7
            // 2 3 5 9
            // 2 4 4 8

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Matrix = FillMatrixByRandomNumbers(M, N);
            PrintMatrix(Matrix);

            PrintMatrix(SortByRowsOfMatrix(Matrix));

            int[,] FillMatrixByRandomNumbers(int m, int n, int LeftRange = 0, int RightRange = 10)
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

            void PrintMatrix(int[,] array1)
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

            int[,] SortByRowsOfMatrix(int[,] matrix)
            {   
                
                for(int i = 0; i<matrix.GetLength(0); i++)
                {
                    for(int j = 0; j<matrix.GetLength(1); j++)
                    {
                        for(int k = j+1; k<matrix.GetLength(1); k++)
                        {
                            if(matrix[i,j]>matrix[i,k])
                            {
                                int temp = matrix[i,j];
                                matrix[i,j] = matrix[i,k];
                                matrix[i,k] = temp;
                            }
                        }
                    }
                }
                return matrix;
            }


        }
    }
}
