using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass__Density_and_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            string find;
            double mass;
            double density;
            double volume;
            start:
            Console.WriteLine("Computation of Mass, Density and Volume");
            Console.WriteLine("\n");
            Console.WriteLine("FIND");
            Console.WriteLine("A. Mass");
            Console.WriteLine("B. Density");
            Console.WriteLine("C. Volume");
            Console.WriteLine("\n");
            find = Console.ReadLine();

            if (find == "A" || find == "a")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Find Mass");
                Console.WriteLine("Density: ");
                density = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Volume: ");
                volume = Convert.ToDouble(Console.ReadLine());
                double result1 = density * volume;
                Console.WriteLine("The two numbers are " + density + " and " + volume +
                                  ", The missing value is mass" +
                                  ", The answer is " + result1);
            }
            else if (find == "B" || find == "b")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Find Density");
                Console.WriteLine("\n");
                Console.WriteLine("Mass: ");
                mass = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Volume: ");
                volume = Convert.ToDouble(Console.ReadLine());
                double result2 = mass / volume;
                Console.WriteLine("The two numbers are " + mass + " and " + volume +
                                  ", The missing value is density" +
                                  ", The answer is " + result2);
            }
            else if (find == "C" || find == "c")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Find Volume");
                Console.WriteLine("\n");
                Console.WriteLine("Mass: ");
                mass = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Density: ");
                density = Convert.ToDouble(Console.ReadLine());
                double result3 = mass / density;
                Console.WriteLine("The two numbers are " + mass + " and " + density +
                                  ", The missing value is volume" +
                                  ", The answer is " + result3);
            }
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
