using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,a, b, c,d,e, temp;
            Console.WriteLine("Enter 5 digit Number:");
            n = Convert.ToInt16(Console.ReadLine());
            a = n / 10000;
            Console.WriteLine("Number is:{0}",a);
            b = n / 1000;
            Console.WriteLine("Number is:{0}", b);
            c = n / 100;
            Console.WriteLine("Number is:{0}", c);
            d = n / 10;
            Console.WriteLine("Number is:{0}", d);
        }
    }
}
