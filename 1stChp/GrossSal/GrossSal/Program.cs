using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossSal
{
    class Program
    {
        static void Main(string[] args)
        {
            double da = 0.4, rt = 0.2, c, gs = 0 ;
            Console.WriteLine("Enter Salary:");
            c=Convert.ToDouble(Console.ReadLine());
            gs = c - (da + rt);
            Console.WriteLine("The Monthly Gross Salary is={0}",gs);
            
        }
    }
}
