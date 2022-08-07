using System;

namespace Task034
{
    class Program
    {
        static void Main(string[] args)
        {

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

            Console.WriteLine("Введите величину массива: "); 
            int Quantity = Convert.ToInt32(Console.ReadLine());
            
            int[] Array = new int[Quantity];
            Random rand = new Random();

            int[] array = FillArrayWithRandomNumbers(Quantity,100,1000);
            Console.WriteLine('[' + string.Join(", ", array) + ']');


            int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
            {
                for(int i = 0; i<size; i++)
                {
                    Array[i] = rand.Next(leftRange,rightRange);
                }
                return Array;
            }

            int EvenNumbers (int[] arr)
            {
                int count = 0;
                for(int i = 0; i<arr.Length; i++)
                {
                    if((arr[i]%2)==0) count++;
                }
                return count;

            }
           
            Console.WriteLine("Четных чисел в массиве " + string.Join(", ", EvenNumbers(array)));



            
        }
    }
}
