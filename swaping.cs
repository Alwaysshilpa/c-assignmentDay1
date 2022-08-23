using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class swaping
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }
        public static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine($"Before swap a= {a} b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Before swap a= {a} b={b}");
        }
    }
}
