using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace deleted
    class Program
    {
        static void Main(string[] args)
        {	//Here we read some properties of a character
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int fullHealth = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Health: |" + new string('|', health) + new string('.',fullHealth - health) + "|");
            Console.WriteLine("Energy: |" + new string('|', energy) + new string('.', maxEnergy - energy) + "|");
        }
    }
