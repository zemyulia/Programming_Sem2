using System;

namespace Task045
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 45: Напишите программу, которая будет создавать копию заданного массива 
        // с помощью поэлементного копирования.

        int[] Array1 = {1,2,3,4,5,6};

        int[] CopyArrayMethod(int[] Numbers) 
        {   int[] NewArray = new int[Numbers.Length];
            for (int i = 0; i < Numbers.Length; i++) 
            { 
                NewArray[i] = Numbers[i];
            }
            return NewArray; 
        }
        Console.WriteLine('[' + String.Join(", ",CopyArrayMethod(Array1)) + ']');

        }
    }
}
