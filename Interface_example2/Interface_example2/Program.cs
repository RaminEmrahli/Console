using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_example2
{
    interface ITriangle
    {
        double Area();
        double Perimeter();
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }
    }
    class EqualTriangle : ITriangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Area()
        {
            double P = (A + B + C) / 2;
            double S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return S;
        }
        public double Perimeter()
        {
            double P = A + B + C;
            return P;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITriangle trig = new EqualTriangle();
            Console.Write("Ucbucagin 1 ci terefi : ");
            trig.A = Double.Parse(Console.ReadLine());
            Console.Write("Ucbucagin 2 ci terefi : ");
            trig.B = Double.Parse(Console.ReadLine());
            Console.Write("Ucbucagin 3 ci terefi : ");
            trig.C = Double.Parse(Console.ReadLine());
            double area = trig.Area();
            double perimeter = trig.Perimeter();
            Console.WriteLine("Ucbucagin sahesi : " + area);
            Console.WriteLine("Ucbucagin perimetri : " + perimeter);
            Console.ReadLine();
        }
    }
}