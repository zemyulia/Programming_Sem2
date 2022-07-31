using System;

namespace Task022
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите число:");
                int MyNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Таблица квадратов числа {MyNumber}: |");
                int[] result = new int[MyNumber];

                for(int i=0; i<MyNumber; i++)
                {
                    result[i] = (i+1)*(i+1);
                    Console.Write($" {result[i]}|");

                }
            
        }
    }
}

