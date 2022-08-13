using System;

namespace Task041
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию (не используем Enter). 
            // Числа разделены пробелами. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            //     0 7 8 -2 -2 -> 2
            //     1, -7, 567, 89, 223-> 3

            Console.WriteLine("Введите несколько чисел в строку через пробел: ");
            int[] numbers = Console.ReadLine().Split().Select(x => Convert.ToInt32(x)).ToArray();// это не работает, не смогла разобраться с командой.

            for(int i = 0; i>numbers.Length; i++)
            {   int Sum = 0;
                if(numbers[i]>0)
                {
                    Sum +=1;
                }
            }


            
        }
    }
}
