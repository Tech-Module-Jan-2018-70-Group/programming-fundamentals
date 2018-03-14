using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometters
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double kilometters = miles * 1.60934;
            Console.WriteLine("{0:f2}", kilometters);
        }
    }
}
