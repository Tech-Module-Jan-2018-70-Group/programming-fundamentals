using System;
class Program
{ //comment here
    static void Main()
    {
        // Receive two variables width and heifht from the Console
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        // Next line is for printing the result after doing the calculations
        Console.WriteLine("{0:f2}",width*height);
    }
}