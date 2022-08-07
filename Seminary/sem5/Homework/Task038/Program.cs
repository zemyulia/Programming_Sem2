using System;

namespace Task038
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
            // Найдите разницу между максимальным и минимальным элементов массива.
            // Задать размер (int) массива с клавиатуры
            // [3 7 22 2 78] -> 76
            
            Console.WriteLine("Введите величину массива: "); 
            int Quantity = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("Задайте нижнюю и верхнюю границы вариации случайных чисел для поиска в массиве: ");
            // int Left = Convert.ToInt32(Console.ReadLine());
            // int Right = Convert.ToInt32(Console.ReadLine());

            double[] Array1 = FillArrayWithRandomNumbers(Quantity); //, Left, Right);
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');
            
            // double res = MaxNumber(Array1) - MinNumber(Array1);
            // Console.WriteLine(MaxNumber(Array1));
            // Console.WriteLine(MinNumber(Array1));
            // Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве равна: {res}."); 

            double[] FillArrayWithRandomNumbers(int size) //, int leftRange, int rightRange)
            {
            
                double[] array = new double[size];
                Random rand = new Random();
                for(int i = 0; i<size; i++)
                {
                    array[i] = rand.NextDouble()*100;
                    //Console.Write("{0,99:N3}", rand.NextDouble());
                }
                return array;
            }

            double MaxNumber(double[] arr)
            {
                double MaxNum = arr[0];
                for(int i = 0; i<arr.Length; i++)
                {
                    if(arr[i]>MaxNum) MaxNum = arr[i];
                }
                return MaxNum;
            }
            Console.WriteLine($"Максимальный элемент массива: {MaxNumber(Array1)}.");
           

           double MinNumber(double[] arr)
            {
                double MinNum = arr[0];
                for(int i = 0; i<arr.Length; i++)
                {
                    if(arr[i]<MinNum) MinNum = arr[i];
                }
                return MinNum;
            }
            Console.WriteLine($"Минимальный элемент массива: {MinNumber(Array1)}.");

            Console.WriteLine($"Разница между ними равна: {MaxNumber(Array1)-MinNumber(Array1)}.");            

        }
        
    }
}
