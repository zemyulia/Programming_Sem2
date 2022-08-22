using System;

namespace Task056
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 56: Задайте прямоугольный двумерный массив. 
            // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 5 2 6 7
            // Программа считает сумму элементов в каждой строке и 
            // выдаёт номер строки с наименьшей суммой элементов: 1 строка

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Matrix = FillMatrixByRandomNumbers(M, N);
            PrintMatrix(Matrix);


            int[,] FillMatrixByRandomNumbers(int m, int n)
            {
                int[,] array = new int[m,n];
                Random rand = new Random();
                for(int i = 0; i<m; i++)
                {
                    for(int j = 0; j<n; j++)
                    {
                        array[i,j] = (int)(rand.NextDouble()*10);//*10 - случайные числа от 0 до 10
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

            void SmallestSumOfElements(int[,] matrix)
            {   
                int[] SumByRows = new int[matrix.GetLength(0)];
                for(int i = 0; i<matrix.GetLength(0); i++)
                    {
                        for(int j = 0; j<matrix.GetLength(1); j++)
                        {
                            SumByRows[i] += matrix[i,j];
                        }
                    }
                Console.WriteLine("Суммы элементов матрицы по строкам: ");
                Console.WriteLine(String.Join(", ", SumByRows));
                int minIndex = 0;
                for(int i = 0; i<SumByRows.Length; i++)
                {
                    if(SumByRows[minIndex]>SumByRows[i])
                    {
                        minIndex = i;
                    }
                }
                Console.WriteLine("Строка с наименьшей суммой элементов - " + (minIndex+1) + ".");
            }

            SmallestSumOfElements(Matrix);

        }
    }
}
