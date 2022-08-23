using System;

namespace Task069
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
            // и возводит число А в целую степень B с помощью рекурсии.
            //     A = 3; B = 5 -> 243 (3⁵)
            //     A = 2; B = 3 -> 8

            int PowerRec(int a, int b)
            {
                if(b == 0) return 1;
                else return a * PowerRec(a, b-1);
            }

            Console.WriteLine(PowerRec(2,3));

        }
    }
}
