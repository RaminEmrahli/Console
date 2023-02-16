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
            Min();
            Console.ReadKey();
        }
        #region methods
        static void Min()
        {
            int n, minIndex;
            double previousPlural, nextPlural, max;
            double[] array;
            input(out n, out previousPlural, out max, out minIndex, out array);
            Algorithm(n, ref minIndex, ref previousPlural, ref max, array);
        }

        private static void Algorithm(int n, ref int minIndex, ref double previousPlural, ref double min, double[] array)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            for (int i = 0; i < minIndex; i++)
            {
                previousPlural = previousPlural + array[i];
            }

            Console.WriteLine($"previousPlural={previousPlural}");
        }

        private static void input(out int n, out double previousPlural, out double min, out int minIndex, out double[] array)
        {
            Console.Write("Enter the length:");
            n = int.Parse(Console.ReadLine());
            previousPlural = 0;
            
            min = double.MaxValue;
            minIndex = 0;
            array = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

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