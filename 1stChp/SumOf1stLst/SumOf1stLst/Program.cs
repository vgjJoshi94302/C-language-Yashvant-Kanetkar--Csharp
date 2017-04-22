using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf1stLst
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp,c;

            Console.WriteLine("Enter 4 digit No:");
            a = Convert.ToInt16(Console.ReadLine());

            b = a / 1000;
            Console.WriteLine("The number is :{0}", b);

            c = a % 10;
            Console.WriteLine("The Last Number is:{0}",c);

            temp = b + c;
            Console.WriteLine("The Last Number is:{0}", temp);




        }
    }
}
