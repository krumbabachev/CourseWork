using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2091 to binary : {0}", Convert.ToString(2091,2));
            int deci = 2091;
            Console.WriteLine("{0} to hexadecimal is : {1}",deci, deci.ToString("X"));
        }
    }
}