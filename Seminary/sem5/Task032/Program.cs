using System;

namespace Task032
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 32: Напишите программу замены элементов массива: 
            // положительные элементы замените на соответствующие отрицательные, и наоборот.
            // [-4, -8, 8, 2] -> [4, 8, -8, -2]


            // Console.WriteLine("Введите величину массива: "); // решение без методов.
            // int quantity = Convert.ToInt32(Console.ReadLine());
            // int[] array = new int[quantity];
            // int[] arrayNegative = new int[quantity];

            // for(int i = 0; i<quantity; i++)
            // {
            //     array[i] = new Random().Next(-9,9);
            //     arrayNegative[i] = array[i]*-1;
            // }
            // Console.WriteLine('[' + string.Join(", ", array) + ']');
            // Console.WriteLine('[' + string.Join(", ", arrayNegative) + ']');



            Console.WriteLine("Введите величину массива: "); 
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задайте нижнюю и верхнюю границы вариации случайных чисел: ");
            int Left = Convert.ToInt32(Console.ReadLine());
            int Right = Convert.ToInt32(Console.ReadLine());
            
            int[] array = new int[quantity];
            Random rand = new Random();


            int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
            {
                for(int i = 0; i<quantity; i++)
                {
                    array[i] = rand.Next(leftRange,rightRange);
                }
                return array;
            }

            FillArrayWithRandomNumbers(quantity, Left, Right);
            Console.WriteLine('[' + string.Join(", ", FillArrayWithRandomNumbers(quantity, Left, Right)) + ']');


           int[] NegativeArray(int[] arr)
           {
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = arr[i]*(-1);
            }
            return arr;
           }

           int[] Array1 = NegativeArray(FillArrayWithRandomNumbers(quantity, Left, Right));
           Console.WriteLine('[' + string.Join(", ", Array1) + ']');
            
        }
    }
}
