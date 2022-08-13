using System;

namespace Task045
{
    class Program
    {
        static void Main(string[] args)
        {

        // Задача 45: Напишите программу, которая будет создавать копию заданного массива 
        // с помощью поэлементного копирования.

        int[] CopyArrayMethod(int[] Numbers) 
        {
        for (int i = 0; i < Numbers.Length; i++) 
            {
                int[] NewArray = new int[Numbers.Length]; 
                NewArray[i] = Numbers[i];
            }
        return NewArray; 
        }
        Console.WriteLine(‘[‘ + {String.Join(“, CopyArrayMethod(Array1))} + ‘]’);

        }
    }
}
