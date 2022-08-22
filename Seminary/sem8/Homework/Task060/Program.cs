using System;

namespace Task060
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
            // Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            // массив размером 2 x 2 x 2
            // 12(0,0,0) 22(0,0,1)
            // 45(1,0,0) 53(1,0,1)

            int[,,] array3D = new int[,,] { { { 1, 2 }, { 3, 4} },
                                 { { 5, 6 }, { 7, 8 } } };
            PrintMatrix(array3D);

            void PrintMatrix(int[,,] array1)
            {
                for(int i = 0; i<array1.GetLength(0); i++)
                    {
                        for(int j = 0; j<array1.GetLength(1); j++)
                        {
                            for(int k = 0; k<array1.GetLength(2); k++)
                            {
                                int[] CoordinateOfElement = new int[3];
                                CoordinateOfElement[0] = i;
                                CoordinateOfElement[1] = j;
                                CoordinateOfElement[2] = k;
                                Console.Write($"{array1[i,j,k]} ");
                                Console.Write('(' + String.Join(", ", CoordinateOfElement) + ") ");
                            }
                            Console.WriteLine( );
                        }
                        Console.WriteLine( );
                    }
                Console.WriteLine();
            }


        }
    }
}
