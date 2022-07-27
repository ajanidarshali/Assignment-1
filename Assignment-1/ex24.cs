using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of First 500 Prime Number : ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr>500)
            {
                sum +=n;
                ctr++;
            }
            n++;
        }
        Console.WriteLine(sum.Tostring());
    }
    public static bool isPrime(int n)
    {
        int a=(int)Math.Floor(Math.sqrt(n));
        if(n==1) return false;
        if(n==2) return true;
        for (int i = 2; i < =a; ++i)
			{
			    if(n%i==0) return false;
			}
            return true;
    }
}
