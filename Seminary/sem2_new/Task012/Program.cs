using System;

namespace Task012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double Num2 = Convert.ToInt32(Console.ReadLine()); 

            double Div = Num1/Num2;
            double remains = Num1%Num2;
           // Console.WriteLine(Div);
           // Console.WriteLine(remains);


            if(remains == 0)
            {
                Console.WriteLine($"Число {Num2} кратно {Num1}");
            }
            else
            {
                Console.WriteLine($"Остаток {remains}");
            }
        }
    }
}
