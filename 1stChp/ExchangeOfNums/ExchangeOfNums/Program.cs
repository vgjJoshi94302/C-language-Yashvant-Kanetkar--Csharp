using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int  c, d, temp;
            Console.WriteLine("Enter input for C");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter input for D");
            d = Convert.ToInt32(Console.ReadLine());

            temp = c;
            c = d;
            d = temp;

            Console.WriteLine("Value of C is:{0}:",c);
            Console.WriteLine("Value of D is:{0}:",d);

        }
    }
}
