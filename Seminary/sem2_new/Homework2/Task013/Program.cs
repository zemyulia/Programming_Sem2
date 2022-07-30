using System;

namespace Task013
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            Number = Math.Abs(Number);

            if(Number<100) Console.WriteLine("Третьей цифры нет.");
            else
            {
                while(Number>999)
                {
                    Number = Number/10;
                }
                Console.WriteLine(Number%10);
            }


          
// второе решение
//            Console.WriteLine("Введите число: ");
//            int Number = Convert.ToInt32(Console.ReadLine());
//            Number = Math.Abs(Number);

//            if(Number<100) Console.WriteLine("Третьей цифры нет.");
//            else
//            {
//             string A = Number.ToString();
//             Console.WriteLine(A[2]);
//            }

           
        //     void ArrayOfDigits(int Num)
        //     {
        //         int Num;
        //         int N = Num.Length;
        //         int i = 0;
        //         int Num;

        //         while(i<N)
        //         {
        //             array[i] = Num / (10^(N-1-i));
        //             i++;
        //             Num = Num-array[i]*10^(N-1-i);
        //         }
        //     }


        //    ArrayOfDigits(Number);
        //    Console.WriteLine(array[2]);

        }
    }
}
