using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e39
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 ={ 1, 2, 3, 4, 1, 2, 3, 4, 5, 4 };
            Console.Write("Enter First Number  :");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((arr1[0]==a) || (arr1[arr1.Length-1]==a));
        }
    }
}
