using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            theLengthOfVector();
            Console.ReadKey();
        }
        static void theLengthOfVector()
        {
            Console.Write("Enter number of vector's elements:");
            int n = int.Parse(Console.ReadLine());
            double[] vector=new double[n];
            Console.WriteLine("Enter vector's elements:");
            double sum=0;

            for(int i = 0; i < n; i++)
            {
                vector[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Vector's elements:");
            for (int i = 0; i < n; i++)
            {
               Console.Write(vector[i]+" ");
            }

            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                sum=sum+vector[i]*vector[i];
            }

            double length=Math.Sqrt(sum);
            Console.Write($"Length of Vector={length}");
        }
    }
}
