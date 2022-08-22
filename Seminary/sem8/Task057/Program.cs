using System;

namespace Task057
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 57: Составить частотный словарь элементов двумерного массива. 
            // Частотный словарь содержит информацию о том, сколько раз встречается 
            // элемент входных данных.
            // 1, 2, 3 
            // 4, 6, 1 
            // 2, 1, 6
            // 1 встречается 3 раза 
            // 2 встречается 2 раз 
            // 3 встречается 1 раз 
            // 4 встречается 1 раз 
            // 6 встречается 2 раза
            // В нашей исходной матрице встречаются элементы от 0 до 9

            Console.WriteLine("Введите количество строк двумерного массива: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов двумерного массива: ");
            int N = Convert.ToInt32(Console.ReadLine());

            int[,] Matrix = FillMatrixByRandomNumbers(M, N);
            PrintMatrix(Matrix);
            int[] Array = FrequencyDictionary(Matrix);

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

            int[] FrequencyDictionary(int[,] arr)
            {
                int[] countigArray = new int[10];
                for(int i = 0; i<arr.GetLength(0); i++)
                    {
                        for(int j = 0; j<arr.GetLength(1); j++)
                        {
                            countigArray[arr[i,j]]++;
                        }
                    }
                return countigArray;
            }

            for(int k = 0; k<Array.Length; k++)
            {
            if(Array[k] != 0) Console.WriteLine($"{k} встречается {Array[k]} раз.");
            }
        }
    }
}
