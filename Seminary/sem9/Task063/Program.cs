using System;

namespace Task063
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 63: Задайте значение N. Напишите программу, 
            // которая выведет все натуральные числа в промежутке от 1 до N.
            // N = 5 -> "1, 2, 3, 4, 5"
            // N = 6 -> "1, 2, 3, 4, 5, 6"

            // int[] NaturalNumbersArr(int n)
            // {
            //     int[] NaturalNumbersArray = new int[n];
            //     for(int i=0; i<n; i++)
            //     {
            //         NaturalNumbersArray[i] = i + 1;
            //     }
            //     return NaturalNumbersArray;
            // }
            
            // Console.WriteLine("Введите целое число N больше 0: ");
            // int N = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Все натуральные числа в промежутке от 0 до {N}:");
            // Console.WriteLine('"' + String.Join(", ", NaturalNumbers(N)) + '"');

            
            string NaturalNumbers(int n)
            {   
                if(n > 0) return NaturalNumbers(n-1) + $"{n} ";
                else return String.Empty;
            }

            Console.WriteLine(NaturalNumbers(5));
        }
    }
}
