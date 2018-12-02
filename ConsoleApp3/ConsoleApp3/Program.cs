using System;
using System.Text;

namespace task397
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Encoding utf8 = Encoding.UTF8;

            Console.Write("Въведете брой дни: ");
            int n = int.Parse(Console.ReadLine());
            double[] a = new double[n]; InT(a);
            double s = 0; for (int i = 0; i < n; i++)
                s += a[i]; s = s / n;
            Console.WriteLine("Среднодневна температура по Целзий: " + s);
            Console.WriteLine("Среднодневна температура по Келвин: " + Kelvin(s));

            
            Console.WriteLine("Дневни температури по Келвин: ");

            for (int i = 0; i < n; i++)

                Console.WriteLine((i+1) + "-и ден: " +Kelvin(s));



        }
        //a---------------------------------------------------------
        static double Kelvin(double t)
        {
            return t + 273.15;
        }

        //b---------------------------------------------------------
        static void InT (double[] a) 
            {
            for (int i = 0; i <a.Length; i++)
            {
                bool f;
                do
                {
                    Console.Write("Въведете t* за " + (i + 1) + " -ия ден:");
                    f = double.TryParse(Console.ReadLine(), out a[i]);

                }
                while (!f || a[i] < -50 || a[i] > 50);
            }

            Encoding utf8 = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
}





    }

    
    




}