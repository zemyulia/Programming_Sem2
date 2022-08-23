using System;

namespace Task068
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
            // Даны два неотрицательных числа m и n.
            // m = 2, n = 3 -> A(m,n) = 9

            int AkkermanaMethod (int m, int n)
            {
                if(m>0 && n>0) return AkkermanaMethod(m-1,AkkermanaMethod(m, n-1));
                else if(m>0 && n == 0) return AkkermanaMethod(m-1,1);
                else return n+1;
            }

            Console.WriteLine(AkkermanaMethod(2,3));
        }
    }
}
