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
        {	//We parse to double here cause we have real number
            double v = double.Parse(Console.ReadLine());
			//Multiplay miles by miles per kilometters to find total kilometers
            double kilometters = miles * 1.60934;
            Console.WriteLine("{0:f2}", kilometters);
        }
    }
}
