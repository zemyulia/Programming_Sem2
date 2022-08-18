using System;

namespace Task049
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 49: Задайте двумерный массив. Найдите элементы, 
            // у которых оба индекса чётные, и замените эти элементы на их квадраты.
            // Например, изначально массив
            // выглядел вот так:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            
            int[,] Array1 = FillArrayRandomNumbers(M, N);
            PrintArray(Array1);

            ModifiedArray(Array1);
            PrintArray(ModifiedArray(Array1));

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

           int[,] ModifiedArray(int[,] array)
           {
            for(int i = 0; i<array.GetLength(0); i+=2)
                {
                    for(int j = 0; j<array.GetLength(1); j+=2)
                    {
                        array[i, j] = array[i, j]*array[i, j];
                    }
                }
            return array;
            
           }
        }
    }
}
