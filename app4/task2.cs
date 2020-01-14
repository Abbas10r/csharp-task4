using System;
using System.Collections.Generic;
using System.Text;

namespace app4
{
    class task2
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32((Console.ReadLine()));
            int n1,n2,n3; int min=0; 
            for(int i=0;i<n;i++)
            {
                String oper = Console.ReadLine();
                if(oper=="min")
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    if (n1 < n2 && n1 < n3 || n1==n2)
                        min = n1;
                    else if (n2 < n1 && n2 < n3 || n2==n3)
                        min = n2;
                    else if (n3 < n1 && n3 < n2 || n3==n1)
                        min = n3;
                    Console.WriteLine(min);
                }
                else if(oper=="mean")
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    int mean = (n1 + n2 + n3) / 3;
                    Console.WriteLine(mean);
                }
                else if(oper=="eye")
                {
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    double p = 0.30*n1+n2*0.59+n3*0.11;
                    int eye = Convert.ToInt32(p);
                    Console.WriteLine(eye);
                }
            }          
        }
    }
}
