using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input c: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine();
            

            Console.WriteLine("Is there a triangle that exists: {0}", RectangleExists(a, b, c));

            if (RectangleExists(a, b, c) == true)
            {

                Console.WriteLine("The Surface of the triange is : {0}", SurfaceTriangle(a, b, c));
            }


        }

        //private static void RectangleExists(object v)
        //{
        //    throw new NotImplementedException("No triange exists");
        //}

        public static bool RectangleExists(double a, double b, double c)
        {
         

            if (a < b + c && b < a + c && c < b + a) 
            {
                return true;
            }
            else
            {
                return false;
            }


        }

      static double SurfaceTriangle(double a, double b, double c)

        {
            double p = a + b + c;
            double SurfaceTriangle = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return SurfaceTriangle;
        }
    }
}
        
    
