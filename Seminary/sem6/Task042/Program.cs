using System;

namespace Task042
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            int[] ConvertToTwo(int N)
            {
                int[] NumToTwo = new int[32];
                int temp = 0;
                int i=0;
                
                while(N>0)
                {
                    
                    temp = N%2;
                    N = N/2;

                    NumToTwo[i] = temp;
                    i++;

                }
                return NumToTwo;
            }

            int[] UTurn(int[] arr)
            {
                int temp = 0;
                for(int i = 0; i < arr.Length/2; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[arr.Length-1-i];
                    arr[arr.Length-1-i] = temp;
                }
                return arr;
            }

            int[] Array1 = ConvertToTwo(Num);
            Console.WriteLine('[' + string.Join(", ", Array1) + ']');
            Console.WriteLine('[' + string.Join(", ", UTurn(Array1)) + ']');

        }
    }
}
