using System;

namespace Task058
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 58: Задайте две матрицы. Напишите программу, 
            // которая будет находить произведение двух матриц.
            // Например, заданы 2 массива:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            // 5 2 6 7
            // и
            // 1 5 8 5
            // 4 9 4 2
            // 7 2 2 6
            // 2 3 4 7
            // Их произведение будет равно следующему массиву:
            // 1 20 56 10
            // 20 81 8 6
            // 56 8 4 24
            // 10 6 24 49
            Console.Clear();
            Console.WriteLine("Сформируем 2 мтарицы. Введите количество строк: ");
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("И количество столбцов: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] Matrix1 = FillMatrixByRandomNumbers(M, N);
            PrintMatrix(Matrix1);

            int[,] Matrix2 = FillMatrixByRandomNumbers(M, N);
            PrintMatrix(Matrix2);

            Console.WriteLine(
                "Новая матрица, элементы которой представляют собой \n" +
                "произведения соответствующих элементов начальных матриц: ");
            PrintMatrix(MultyMatrix(Matrix1, Matrix2));


            int[,] FillMatrixByRandomNumbers(int m, int n)
            {
                int[,] matrix = new int[m,n];
                Random rand = new Random();
                for(int i = 0; i<m; i++)
                {
                    for(int j = 0; j<n; j++)
                    {
                        matrix[i,j] = (int)(rand.NextDouble()*10);//*10 - случайные числа от 0 до 10
                    }
                    
                }
                return matrix;
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

            int[,] MultyMatrix(int[,] matrix1, int[,] matrix2)
            {   
                int[,] newMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
                for(int i = 0; i<matrix1.GetLength(0); i++)
                {
                    for(int j = 0; j<matrix1.GetLength(1); j++)
                    {
                        newMatrix[i,j] = matrix1[i,j]*matrix2[i,j];
                    }
                }
                return newMatrix;
            }
        }
    }
}
