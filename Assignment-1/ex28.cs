using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1e28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter HexaDecimal value :");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str,16);
            Console.WriteLine("HexaDecimal value : {0}", str);
            Console.WriteLine("Integer Value :{0}", a);

        }
    }
}
