using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maximumAndMinimum();
            Console.ReadKey();
        }
        #region method
        static void maximumAndMinimum()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            int i;
            double max = double.MinValue;
            double min = double.MaxValue;

            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            double firstelement=array[0];

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
                if (min > array[i])
                {
                    min = array[i];
                }
            }

            for(i = 0; i < n; i++)
            {
                if (firstelement >= 0)
                {
                    array[i] =array[i]*min*min;
                }
                else
                {
                    array[i] = array[i] * max * max;
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
#endregion