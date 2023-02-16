using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max, min, product;
            int n, maxIndex, minIndex;
            double[] array;
            input(out max, out min, out n, out array, out maxIndex, out minIndex, out product);
            Algorithm(ref max, ref min, ref product, n, ref maxIndex, ref minIndex, array);
            Console.Write("The product of numbers between minimum and maximum:");
            Console.Write(product);
            Console.ReadKey();
        }
        #region methods
      

        private static void Algorithm(ref double max, ref double min, ref double product, int n, ref int maxIndex, ref int minIndex, double[] array)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            if (minIndex < maxIndex)
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    product = product * array[i];
                }
            }
            else if (minIndex > maxIndex)
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    product = product * array[i];
                }
            }
        }

        private static void input(out double max, out double min, out int n, out double[] array, out int maxIndex, out int minIndex, out double product)
        {
            max = double.MinValue;
            min = double.MaxValue;
            Console.Write("Enter the length:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbols of array");
            array = new double[n];
            maxIndex = 0;
            minIndex = 0;
            product = 1;
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("The given array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion