using System;

namespace Task039
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 39: Напишите программу, которая перевернёт одномерный массив 
            // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
            // [1 2 3 4 5] -> [5 4 3 2 1]
            // [6 7 3 6] -> [6 3 7 6]

            int[] FillArrayWithRandomNumbers()
            {
                Console.WriteLine("Введите размер массива: ");
                int Size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[Size];
                Random rand = new Random();
                for(int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(0,100);
                }
                return arr;
            }
           

            int[] UTurn(int[] arr)
            {
                int temp = 0;
                for(int i = 0; i < arr.Length/2; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[arr.Length-1-i];
                    arr[arr.Length-1-i] = temp;
                }
                return arr;
            }

            int[] Array1 = FillArrayWithRandomNumbers();
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');
            Console.WriteLine('[' + string.Join(", ", UTurn(Array1)) + ']');
            
        }
    }
}
