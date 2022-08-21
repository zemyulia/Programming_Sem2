using System;

namespace Task050
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 50. Напишите программу, которая на вход принимает позиции элемента 
            // в двумерном массиве, и возвращает значение этого элемента или же указание, 
            // что такого элемента нет.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 1 7 -> такого числа в массиве нет


            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты элемента, кторый нужно найти в данном массиве: ");
            int Row = Convert.ToInt32(Console.ReadLine());
            int Column = Convert.ToInt32(Console.ReadLine());


            int[,] Arr = FillArrayRandomNumbers(M, N);
            PrintArray(Arr);
            SearchElementOfMatrix(Arr, Row, Column);

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


            void SearchElementOfMatrix(int[,] array1, int row, int column)
            {
                if(row<array1.GetLength(0) && column<array1.GetLength(1) && row>=0 && column>=0)
                {
                    Console.WriteLine(array1[row, column]);
                }
                else Console.WriteLine("Элемента с такими координатами в массиве нет.");
            }

            
        }
    }
}
