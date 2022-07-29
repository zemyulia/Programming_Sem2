using System;

namespace Task013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double Num = Convert.ToInt32(Console.ReadLine());
            double Div1 = Num % 7;
            double Div2 = Num % 23;

            if(Div1==0 && Div2==0)
            {
                Console.WriteLine("Введенное число кратно одновременно двум числам 7 и/или 23. ");
            }
            else
            {
                Console.WriteLine("Введенное число не кратно одновременно двум числам 7 и 23. ");
            }
        }
    }
}
