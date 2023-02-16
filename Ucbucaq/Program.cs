using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucbucaq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The triangle given the vertices points:");
            Console.WriteLine("enter the cordinates of A:");
            Console.Write("Enter x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cordinates of B:");
            Console.Write("Enter x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2:");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the cordinates of C:");
            Console.Write("Enter x3:");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter y3:");
            double y3 = double.Parse(Console.ReadLine());
            double AB=Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)* (y2 - y1));
            double AC=Math.Sqrt((x3 - x1)*(x3 - x1) + (y3 - y1)*(y3 - y1));
            double BC = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double p = (AB + AC + BC) / 2;
            double S = Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            Console.Write("The sides of the triangle:");
            Console.WriteLine($" AB={AB} ;AC={AC} ;BC={BC} ");
            Console.Write("Perimeter of the triangle:");
            Console.WriteLine(AB + AC + BC);
            Console.Write("Area of the triangle:");
            Console.Write(S);
            Console.ReadKey();


        }
    }
}
