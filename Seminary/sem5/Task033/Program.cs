using System;

namespace Task037_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 33: Задайте массив. Напишите программу, которая определяет, 
            // присутствует ли заданное число в массиве.
            // 4; массив [6, 7, 19, 345, 3] -> нет
            // 3; массив [6, 7, 19, 345, 3] -> да
            // ВЫВОДИТЬ СООБЩЕНИЕ О НАЛИЧИИ ЭЛЕМЕНТА В МАССИВЕ ТОЛЬКО ОДИН РАЗ!

            Console.WriteLine("Введите величину массива: "); 
            int Quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задайте нижнюю и верхнюю границы вариации случайных чисел для поиска в массиве: ");
            int Left = Convert.ToInt32(Console.ReadLine());
            int Right = Convert.ToInt32(Console.ReadLine());

            


            Console.WriteLine("Введите число для поиска в массиве: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] Array1 = FillArrayWithRandomNumbers(Quantity, Left, Right);
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');

            SearchNumber(Array1, Number);



            void SearchNumber(int[] arr, int number)
            {
                for(int i = 0; i<arr.Length; i++)
                {
                    if(arr[i]==number)
                    { 
                        Console.WriteLine("да");
                        break;
                    }
                }
            }

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
