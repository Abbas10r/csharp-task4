using System;
using static System.Convert;
using static System.Console;

namespace app4
{
    class task1
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, g, h, i, j = 1, N, p, q, r=0;          
            while (true)
            {
                N = ToInt32(ReadLine());
                if (N == 0)
                    break;
                else
                {
                    j = 1;p = 0;q = 0;
                    int[,] arr = new int[N, N];
                    i = N;
                    if (N % 2 == 0)
                        r = N / 2;
                    else if (N % 2 == 1)
                        r = (N / 2) + 1;
                    for (c = 1; c <=r; c++)
                    {
                        for (a = p; a < i; a++)
                        {
                            for (b = q; b < i; b++)
                                arr[a,b] = j;
                        }
                        j++;
                        p++; 
                        q++; 
                        i--;
                    }
                    for (g = 0; g < N; g++)
                    {
                        for (h = 0; h < N; h++)
                        {
                            if (h == 0)
                                Write($"   {arr[g, h]}");
                            else
                                Write($"    {arr[g, h]}");                              
                        }
                        WriteLine();
                    }
                    WriteLine();
                }
                
            }      
        }
    }
}
