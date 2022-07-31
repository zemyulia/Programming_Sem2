using System;

namespace Task019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5-значное число: ");
            int MyNumber = Convert.ToInt32(Console.ReadLine());


            int[] Digits = new int[5];

            if (MyNumber<100000 && MyNumber>9999)
            {
                for(int i = 4; i>=0; i = i-1)
                {
                    Digits[i] = MyNumber%10;
                    MyNumber = MyNumber/10;
                }

                if(Digits[0]==Digits[4] && Digits[1]==Digits[3])
                {
                    Console.WriteLine("Число является полиндромом.");
                }
                else Console.WriteLine("Число не является полиндромом.");
                
            }
            else Console.WriteLine("Введенное число не соответствует условию задачи.");

            
        }
    }
}
