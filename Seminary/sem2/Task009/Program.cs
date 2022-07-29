using System;

namespace Task009
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = new Random().Next(10,100);
            Console.Write("Случайное число: ");
            Console.WriteLine(Number);
            
            int x = Number%10;
            int y = Number/10;

            if (x>y) 
            {
                Console.WriteLine($"Цифра {x} - наибольшая.");
            }
            else
            {
                Console.WriteLine($"Цифра {y} - наибольшая.");
            }
        }
    }
}
