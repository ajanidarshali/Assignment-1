using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Amount :");
            int cel=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelvin ={0}",cel+273);
            Console.WriteLine("Fahrenheit={0}", cel * 18 / 10 + 32);
        }
    }
}
