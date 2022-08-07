using System;

namespace Task031_withMethod
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных
        // и положительных элементов массива.
        // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20


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

        void sumPositiveAndNegativeElements(int[] arr, out int sumPositive, out int sumNegative)
        {
            sumPositive = 0; //сумма положительных чисел
            sumNegative = 0; //сумма отрицательных чисел

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) //если элемент массива положительный
                {
                    sumPositive += arr[i]; //накопить положительную сумму
                }
                else   //если элемент массива отрицательный
                {
                    sumNegative += arr[i]; //накопить отрицательную сумму
                }
            }
        }

        int[] array = FillArrayWithRandomNumbers(12, -9, 9);
        sumPositiveAndNegativeElements(array, out int sumP, out int sumN);

        Console.WriteLine('[' + string.Join(", ", array) + ']');
        Console.Write($"Сумма положительных чисел = {sumP}, отрицательных = {sumN}");

        }
    }
}
