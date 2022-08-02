using System;

namespace Task030
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
            // заполненный нулями и единицами в случайном порядке.
            // [1,0,1,1,0,1,0,0]


            void MethodArRandom()
            {

                int[] Array = new int[8];

                for(int i = 0; i<Array.Length; i++)
                {
                    Array[i] = new Random().Next(0,2);
                }

                Console.WriteLine(string.Join(", ", Array));
            }

            MethodArRandom();
           
        }
    }
}
