using System;

namespace Task016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Square1 = Num1*Num1;
            int Square2 = Num2*Num2;

            if(Num1==Square2 || Num2==Square1) Console.WriteLine("Одно из введенных чисел является квадратом второго.");
            else Console.WriteLine("Ни одно из введенных чисел не является квадратом второго.");
        }
    }
}
