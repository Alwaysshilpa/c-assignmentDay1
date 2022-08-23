using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class exerciseday2
    {
        public static int Mul(int num1, int num2, int num3)
        {
            int res;
            res = num1 * num2 * num3;
            return res;
        }
        public static void Main()
        {
            int num1, num2, num3;
            int res;
            Console.WriteLine("enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            num3= Convert.ToInt32(Console.ReadLine());
            res = Mul(num1, num2, num3);
            Console.WriteLine($"The result of the multiplicatipon is {res} ");
        }
    }
}
