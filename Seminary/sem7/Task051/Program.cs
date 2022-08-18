using System;

namespace Task051
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
            // находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // Сумма элементов главной диагонали: 1+9+2 = 12
            // Попробуйте найти сумму элементов главной диагонали в одном цикле
            

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            
            int[,] Array1 = FillArrayRandomNumbers(M, N);
            PrintArray(Array1);

            Console.WriteLine(SummaElementsOfMainDiagonal(Array1));
            
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

            int SummaElementsOfMainDiagonal(int[,] array)
            {    
                int summa = 0;
                for(int i = 0; i<array.GetLength(0) && i<array.GetLength(1); i++)
                {
                    summa = summa + array[i,i];
                }
                return summa;
            }
        }
    }
}
