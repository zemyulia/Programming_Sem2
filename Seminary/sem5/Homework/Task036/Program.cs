using System;

namespace Task036
{
    class Program
    {
        static void Main(string[] args)
        {


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

            Console.WriteLine("Введите величину массива: "); 
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задайте нижнюю и верхнюю границы вариации случайных чисел для поиска в массиве: ");
            int Left = Convert.ToInt32(Console.ReadLine());
            int Right = Convert.ToInt32(Console.ReadLine());

            int[] Array1 = FillArrayWithRandomNumbers(Quantity, Left, Right);
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');

            Console.WriteLine('[' + string.Join(", ", SumOddNumbers(Array1)) + ']');

            int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
            {
            
                int[] array = new int[size];
                Random rand = new Random();
                for(int i = 0; i<size; i++)
                {
                    array[i] = rand.Next(leftRange, rightRange);
                }
                return array;
            }

            int SumOddNumbers(int[] arr)
            {
                int sum = 0;
                for(int i=1; i<arr.Length; i = i+2)
                {
                    sum = sum + arr[i];
                }
                return sum;
            }

           
        }
    }
}
