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
            int[] arr=new int[3]; int min=0; 
            for(int j=0;j<n;j++)
            {
                String oper = Console.ReadLine();
                if(oper=="min")
                {
                    for(int i=0;i<3;i++)
                    {
                        arr[i]= Convert.ToInt32(Console.ReadLine());
                    }                  
                    if (arr[0] < arr[1] && arr[0] < arr[2] || arr[0]==arr[1])
                        min = arr[0];
                    else if (arr[1] < arr[0] && arr[1] < arr[2] || arr[1]==arr[2])
                        min = arr[1];
                    else if (arr[2] < arr[0] && arr[2] < arr[1] || arr[2]==arr[0])
                        min = arr[2];
                    Console.WriteLine(min);
                }
                else if(oper=="mean")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int mean = (arr[0] + arr[1] + arr[2]) / 3;
                    Console.WriteLine(mean);
                }
                else if(oper=="eye")
                {
                    for (int i = 0; i < 3; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    double p = 0.30*arr[0]+arr[1]*0.59+arr[2]*0.11;
                    int eye = Convert.ToInt32(p);
                    Console.WriteLine(eye);
                }
            }          
        }
    }
}
