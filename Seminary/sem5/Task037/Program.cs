using System;

namespace Task037
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 37: Найдите произведение пар чисел в одномерном массиве. 
            // Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
            // Результат запишите в новом массиве.
            // [1 2 3 4 5] -> 5 8 3
            // [6 7 3 6] -> 36 21

            int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
            {
                Random rand = new Random();
                int[] arr = new int[size];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(leftRange, rightRange + 1);
                }
                return arr;
            }

            int array = FillArrayWithRandomNumbers(5, -5, 8);
            int newLength = array.Length/2 + array.Length%2;
            int[] newArray = new int[newLength];

            for(int i=0; i<newLength; i++)
            {
                newArray[] = array[i]*array[array.Length-1-i];
            }


            Console.WriteLine("Hello World!");
        }
    }
}
