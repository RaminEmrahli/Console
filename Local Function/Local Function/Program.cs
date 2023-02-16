using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number 1 :");
            double elementA = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2 :");
            double elementB = double.Parse(Console.ReadLine());
            Console.WriteLine(Sum(elementA, elementB));

            Console.ReadKey();
        }

        static double Sum(double elementA, double elementB)
        {
            double Product(double elementC, double elementD)
            {
                return elementA * elementB;
            }
            return Product(elementA,elementB)+Product(elementA,elementB);
        }

    }
}
