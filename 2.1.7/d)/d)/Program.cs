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
            maximum();
            Console.ReadKey();
        }
        static void maximum()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            int i;
            double max = double.MinValue;
            double alternative = 0;
            int index = 0;

            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Old array:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }

            for (i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    array[i] = array[i] * max;
                }
            }

            Console.Write("New array: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
