using System;

namespace Task037_
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
            
              Console.WriteLine("Введите величину массива: "); 
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задайте нижнюю и верхнюю границы вариации случайных чисел для поиска в массиве: ");
            int Left = Convert.ToInt32(Console.ReadLine());
            int Right = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите число для поиска в массиве: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] Array1 = FillArrayWithRandomNumbers(Quantity, Left, Right);
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');

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
            
            
        }
    }
}
