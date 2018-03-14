using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _04.Beverage_Labelss
{
    class Program
    {
        static void Main(string[] args)
        {
            // On the first line we read the name of the Beverage from the Console
            string name = Console.ReadLine();
            // On the next three lines we read volume, energy and sugar of teh Beverage per 100 ml
            int volume = int.Parse(Console.ReadLine()); // per 100ml
            int energy = int.Parse(Console.ReadLine());  // per 100ml
            int sugar = int.Parse(Console.ReadLine()); //  per 100ml
            // We calculate the energy
            double conEnergy = (energy * volume) / 100.00;
            // We calculate the sugar
            double conSugar = (sugar * volume) / 100.00;
            // Next line prints the result
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars", volume, name, conEnergy, conSugar);
        }
    }
}