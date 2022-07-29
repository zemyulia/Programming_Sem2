using System;

namespace Task011
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = new Random().Next(100,1000);
            Console.WriteLine($"Случайное число {Num}");

            
            int N = (Num/100)*10 + (Num%10); 
           
            Console.WriteLine($"Преобразованное число: {N}");

        }
    }
}


