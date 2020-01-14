using System;

namespace app4
{
    class task1
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n != 0)
            {
                n = Convert.ToInt32(Console.ReadLine());
                int[,] arr = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (n > 2 && i != 0 && j != 0 && i != n - 1 && j != n - 1)
                        {
                            arr[i, j] = 2;
                        }
                        else
                        {
                            arr[i, j] = 1;
                        }
                        Console.Write("  " + arr[i, j]);
                    }
                    Console.Write("\n");
                }
            }          
        }
    }
}
