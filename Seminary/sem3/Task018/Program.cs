using System;

namespace Task018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число - номер четверти в декартовой плоскости, в диапазоне от 1 до 4: ");
            int coordinate = Convert.ToInt32(Console.ReadLine());


            if(coordinate == 1) Console.WriteLine("Для первой четверти координаты X>0, Y>0.");
            if(coordinate == 2) Console.WriteLine("Для второй четверти координаты X<0, Y>0.");
            if(coordinate == 3) Console.WriteLine("Для третьей четверти координаты X<0, Y<0.");
            if(coordinate == 4) Console.WriteLine("Для четвертой четверти координаты X>0, Y<0.");

        }
    }
}
