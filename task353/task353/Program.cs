using System;

namespace task353
{
    class Program
    {
        private static Random rnd = new Random();

        private static int Read(int x, int y)
        {
            return rnd.Next(x, y + 1);
        }

        public static void Main(string[] args)
        {
            int x, y;

            do
                Console.Write("x= ");
            while (!int.TryParse(Console.ReadLine(), out x));

            do
                Console.Write("y= ");
            while (!int.TryParse(Console.ReadLine(), out y));

            Console.WriteLine("\nRandom between {0} and {1}: {2}", x, y, Read(x, y));

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}