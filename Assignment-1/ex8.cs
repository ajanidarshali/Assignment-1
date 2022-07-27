using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number  :");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<=10; i++)
            {
                    Console.WriteLine("{0} * {1} = {2}",a,i,i*a);    
            }

      
        }
    }
}
