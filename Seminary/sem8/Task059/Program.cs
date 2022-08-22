using System;

namespace Task059
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
            // которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 5 2 6 7
            // Наименьший элемент - 1, на выходе получим 
            // следующий массив:
            // 9 4 2
            // 2 2 6
            // 3 4 7
            
            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Array = FillArrayRandomNumbers(M, N);
            PrintArray(Array);
            PrintArray(ModifiedArray(Array));

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


            int[,] ModifiedArray(int[,] arr)
            {
                int min = arr[0,0];
                int minI = 0;
                int minJ = 0;
                for(int i = 0; i<arr.GetLength(0); i++)
                    {
                        for(int j = 0; j<arr.GetLength(1); j++)
                        {
                            if(arr[i,j]<min)
                            {
                                min = arr[i,j];
                                minI = i;
                                minJ = j;
                            }
                        }
                    }

                int[,] newArr = new int[arr.GetLength(0)-1,arr.GetLength(1)-1];
                for(int i = 0; i<newArr.GetLength(0); i++)
                    {
                        for(int j = 0; j<newArr.GetLength(1); j++)
                        {
                            if(i == minI & j == minJ) 
                            {
                                newArr[i,j] = arr[i+1,j+1];
                            }
                            else if(i == minI) 
                            {
                                newArr[i,j] = arr[i+1,j];
                            }
                            else if(j == minJ) 
                            {
                                newArr[i,j] = arr[i,j+1];
                            }
                            else 
                            {
                                newArr[i,j] = arr[i,j];
                            }
                        }
                    }
                return newArr;
            }

        }
    }
}
