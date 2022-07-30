using System;

namespace Task017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа - координаты точки (X и Y), отличные от нуля: ");
            int X = Convert.ToInt32(Console.ReadLine());
            int Y = Convert.ToInt32(Console.ReadLine());

            if(X>0)
            {
                if(Y>0) Console.WriteLine($"Точка с координатами ({X},{Y}) находится в первой четверти декартовой плоскости");
                else Console.WriteLine($"Точка с координатами ({X},{Y}) находится в четвертой четверти декартовой плоскости");
            }
            else
            {
                if(Y>0)Console.WriteLine($"Точка с координатами ({X},{Y}) находится во второй четверти декартовой плоскости");
                else Console.WriteLine($"Точка с координатами ({X},{Y}) находится в третьей четверти декартовой плоскости");
            }
        }
    }
}
