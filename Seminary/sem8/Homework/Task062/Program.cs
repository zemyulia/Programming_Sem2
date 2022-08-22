using System;

namespace Task062
{
    class Program
    {
        static void Main()
        {
            const int n = 11;
            var a = GetSpire(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i,j]);
                }
                Console.WriteLine();
            }
        }
 
        private static int[,] GetSpire(int n)
        {
            var result = new int[n, n];
            for (int currentChar = 1, padding = 0; padding < n/2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                    result[padding, j] = currentChar;
                for (int j = padding; j < n - padding; j++)
                    result[n - padding - 1, j] = currentChar;
                for (int i = padding + 2; i < n - padding - 1; i++)
                    result[i, padding] = currentChar;
                for (int i = padding + 1; i < n - padding - 1; i++)
                    result[i, n - padding - 1] = currentChar;
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            return result;
        }
    }
}
