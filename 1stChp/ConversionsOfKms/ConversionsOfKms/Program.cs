using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionsOfKms
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,ct, mt, ft, inch;
            Console.WriteLine("Enter the Distance between two Cities in Kilometers:");
            a = Convert.ToDouble(Console.ReadLine());

           ct = 10000 * a;
           Console.WriteLine("The distance between two cities in Centimeters is:{0}", ct+"cms");

            mt = 1000 * a;
            Console.WriteLine("The distance between two cities in meters is:{0}",mt+"mts");

            ft = (3280.84) * a;
            Console.WriteLine("The distance between two cities in feet is:{0}", ft+"ft");

            inch = (39370.1) * a;
            Console.WriteLine("The distance between two cities in inches is:{0}", inch+"inch");
        }
    }
}
