using System;
using static System.Convert;
using static System.Console;
using static System.String;

namespace app4
{
    class task3
    {
        static void Main(string[] args)
        {
            string x;
            int i, j, n, sum = 0;
            n = ToInt32(ReadLine());          
            for (i = 0; i < n; i++)
            {
                x = ReadLine();             
                for (j = 0; j < x.Length; j++)
                {
                    if (x[j] == '1')
                    {
                        sum += 2;
                    }
                    else if (x[j] == '2')
                    {
                        sum += 5;
                    }
                    else if (x[j] == '3')
                    {
                        sum += 5;
                    }
                    else if (x[j] == '4')
                    {
                        sum += 4;
                    }
                    else if (x[j] == '5')
                    {
                        sum += 5;
                    }
                    else if (x[j] == '6')
                    {
                        sum += 6;
                    }
                    else if (x[j] == '7')
                    {
                        sum += 3;
                    }
                    else if (x[j] == '8')
                    {
                        sum += 7;
                    }
                    else if (x[j] == '9')
                    {
                        sum += 6;
                    }
                    else if (x[j] == '0')
                    {
                        sum += 6;
                    }
                }
                Write($"{sum} leds\n");
                sum = 0;
            }
        }
    }
}
