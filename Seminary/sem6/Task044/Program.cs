using System;

namespace Task044
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
            // Первые два числа Фибоначчи: 0 и 1.
            // Если N = 5 -> 0 1 1 2 3
            // Если N = 3 -> 0 1 1
            // Если N = 7 -> 0 1 1 2 3 5 8
            
            Console.WriteLine("Введите число N: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            int[] Fibonacci(int N)
            {
                int[] Fib = new int[N];
                for(int i = 2; i<N; i++)
                {
                    Fib[0] = 0;
                    Fib[1] = 1;
                    Fib[i] = Fib[i-1] + Fib[i-2];
                }
                return Fib;
            }

            int[] Array1 = Fibonacci(Num);
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');

        }
    }
}
