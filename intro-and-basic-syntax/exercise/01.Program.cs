﻿//CONFIRMED from rebown
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {	
            // On the next four lines, we are reading integer numbers from the console
            int s = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
			//Second we use placeholders and print
            Console.WriteLine("{0, 0:D4} {1, 0:D4} {2, 0:D4} {3, 0:D4}", n1, n2, n3, n4 );
        }
    }
}
