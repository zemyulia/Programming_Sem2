using System;

namespace Task035
{
    class Program
    {
        static void Main(string[] args)
        {
// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

            Console.WriteLine("Введите величину массива: "); 
            int Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте нижнюю и верхнюю границы чисел для поиска в массиве: ");
            int Left = Convert.ToInt32(Console.ReadLine());
            int Right = Convert.ToInt32(Console.ReadLine());

            int[] FillArrayWithRandomNumbers(int size)
            {
            
                int[] array = new int[size];
                Random rand = new Random();
                for(int i = 0; i<size; i++)
                {
                    array[i] = rand.Next(1,1000);
                }
                return array;
            }
            int[] OurArray = FillArrayWithRandomNumbers(Quantity);
            Console.WriteLine('[' + string.Join(", ", OurArray) + ']');

            int Counter(int[] arr, int leftRange, int rightRange)
            {
                int count = 0;
                for(int i=0;i<arr.Length; i++)
                {
                    
                    if(arr[i]>=leftRange && arr[i]<=rightRange) count++;
                }
                return count;
            }
            Console.WriteLine("Количество совпадений: " + string.Join(", ", Counter(OurArray, Left, Right)));

        }
    }
}
