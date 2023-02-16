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
            Max();
            Console.ReadKey();
        }
        #region methods
        static void Max()
        {
            int n, maxindex;
            double previousPlural, nextPlural, max;
            double[] array;
            input(out n, out previousPlural, out nextPlural, out max, out maxindex, out array);
            Algorithm(n, ref maxindex, ref previousPlural, ref nextPlural, ref max, array);
        }

        private static void Algorithm(int n, ref int maxindex, ref double previousPlural, ref double nextPlural, ref double max, double[] array)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxindex = i;
                }
            }

            for (int i = 0; i < maxindex; i++)
            {
                previousPlural = previousPlural + array[i];
            }

            for (int i = maxindex + 1; i < n; i++)
            {
                nextPlural = nextPlural + array[i];
            }

            Console.WriteLine($"previousPlural={previousPlural}");
            Console.Write($"nextPlural={nextPlural}");
        }

        private static void input(out int n, out double previousPlural, out double nextPlural, out double max, out int maxindex, out double[] array)
        {
            Console.Write("Enter the length:");
            n = int.Parse(Console.ReadLine());
            previousPlural = 0;
            nextPlural = 0;
            max = double.MinValue;
            maxindex = 0;
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