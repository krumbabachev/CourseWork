using System;

namespace Task4a
{
    class Program
    {
        static void Main(string[] args)
        {

            double x;
            Console.Write("enter x = ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine();
            double a, b, c, y;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine();

            y = ((b - a) / ((2 * b) + c)) * ((a - c) * Math.Cos(x));
            Console.WriteLine("Results = " + y);

            //Console.WriteLine(Math.Cos(x));
        }
    }
}