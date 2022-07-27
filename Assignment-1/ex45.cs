using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e45
{
    class Program
    {
        public static void Main()
        {
            int[] arr = { 2, 4,7, 8, 6 };
            Console.WriteLine("Orignal Array : [{0}]",String.Join(", ",arr));
            Console.WriteLine("Check if an array contains an odd number  : "+even_odd(arr));
        }
        public static bool even_odd(int[] arr)
        {
            foreach (var item in arr)
	        {
		        if(item % 2 != 0)
                 return true;
	        }
            return false;
        }
    }
}
