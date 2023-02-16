using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            maxAndCentralElement();
            Console.ReadKey();
        }
        #region
        static void maxAndCentralElement()
        {
            double sum;
            int maxindex, indexOfCentralElement;
            Main(out sum, out maxindex, out indexOfCentralElement);

            Exit(sum, maxindex, indexOfCentralElement);
        }

        private static void Main(out double sum, out int maxindex, out int indexOfCentralElement)
        {
            double max;
            int n;
            double[] array;
            Entrance(out max, out n, out array, out maxindex, out sum, out indexOfCentralElement);

            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxindex = i;
                }
            }

            if (maxindex > indexOfCentralElement)
            {
                for (int i = indexOfCentralElement + 1; i < maxindex; i++)
                {
                    sum = sum + array[i];
                }
            }

            else if (maxindex < n / 2)
            {
                for (int i = maxindex + 1; i < indexOfCentralElement; i++)
                {
                    sum = sum + array[i];
                }
            }
        }

        private static void Exit(double sum, int maxindex, int indexOfCentralElement)
        {
            Console.WriteLine();
            if (maxindex == indexOfCentralElement + 1 || maxindex == indexOfCentralElement - 1 || maxindex == indexOfCentralElement)
            {
                Console.Write("There is no element between max and central element");
            }
            else
            {
                double average = sum / (maxindex - indexOfCentralElement - 1);
                Console.Write($"average={average}");
            }
        }

        private static void Entrance(out double max, out int n, out double[] array, out int maxindex, out double sum, out int indexOfCentralElement)
        {
            max = double.MinValue;
            Console.Write("Enter the length:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter symbols of array");
            array = new double[n];
            maxindex = 0;
            sum = 0;
            indexOfCentralElement = n / 2;
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