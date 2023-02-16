using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decreasingAndIncreasing();
            Console.ReadKey();
        }
        #region methods
        static void decreasingAndIncreasing()
        {
            int n, numberOfIncreasing, numberOfDecreasing;
            double[] array;
            double firstelement;
            Input(out n, out array, out numberOfIncreasing, out numberOfDecreasing, out firstelement);

            Algorithm(n, ref numberOfIncreasing, ref numberOfDecreasing, array, ref firstelement);

            Output(n, numberOfIncreasing, numberOfDecreasing);
        }

        private static void Output(int n, int numberOfIncreasing, int numberOfDecreasing)
        {
            if (numberOfIncreasing == n - 1)
            {
                Console.WriteLine("Increasing range");
            }
            else if (numberOfDecreasing == n - 1)
            {
                Console.WriteLine("Decreasing range");
            }
            else
            {
                Console.WriteLine("Neither decreasing nor increasing range");
            }
        }

        private static void Algorithm(int n, ref int numberOfIncreasing, ref int numberOfDecreasing, double[] array, ref double firstelement)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] > firstelement)
                {
                    firstelement = array[i];
                    numberOfIncreasing++;
                }
                else if (array[i] < firstelement)
                {
                    firstelement = array[i];
                    numberOfDecreasing++;
                }
            }
        }

        private static void Input(out int n, out double[] array, out int numberOfIncreasing, out int numberOfDecreasing, out double firstelement)
        {
            Console.Write("Enter number of elements:");
            n = int.Parse(Console.ReadLine());
            array = new double[n];
            numberOfIncreasing = 0;
            numberOfDecreasing = 0;
            Console.WriteLine("Enter elements of array:");

            for (int i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            firstelement = array[0];
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