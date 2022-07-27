using System;
using System.Collections.Generic;
using System.IO;

namespace _1e27
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileInfo f= new FileInfo("C:/abc.txt");
            Console.WriteLine("Size of File : " +f.Length.ToString());
        }
    }
}
