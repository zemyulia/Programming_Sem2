using System;

namespace Task010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число в диапазоне [100,999].");
            int Number = Convert.ToInt32(Console.ReadLine());

            if(Number>99 && Number<1000) Console.WriteLine( (Number/10)%10);
            else Console.WriteLine("Введенное число не соответствует заданным условиям.");
        }
    }
}
