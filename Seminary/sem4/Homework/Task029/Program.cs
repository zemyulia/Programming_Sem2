using System;

namespace Task029
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
            // и выводит их на экран. (вводим массив с клавиатуры (т. е. через консоль :) ))
            void ArrayToPrint()
            {
                Console.WriteLine("Введите 8 целых чисел, элементов массива: ");
                int[] array = new int[8];
                array[0] = Convert.ToInt32(Console.ReadLine());
                array[1] = Convert.ToInt32(Console.ReadLine());
                array[2] = Convert.ToInt32(Console.ReadLine());
                array[3] = Convert.ToInt32(Console.ReadLine());
                array[4] = Convert.ToInt32(Console.ReadLine());
                array[5] = Convert.ToInt32(Console.ReadLine());
                array[6] = Convert.ToInt32(Console.ReadLine());
                array[7] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Массив из 8ми чисел: [{string.Join(", ", array)}]");
            }

            ArrayToPrint();

        }
    }
}
