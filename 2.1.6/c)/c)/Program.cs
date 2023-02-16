using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            deletionIterval();
            Console.ReadKey();
        }
        #region Method
        static void deletionIterval()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Interval from: ");
            double a=double.Parse(Console.ReadLine());
            Console.Write("to :");
            double b=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array:");
            double[] array = new double[n];
            int i;
            int numbersOfDeletions=0;
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
                if (array[i] >= a && array[i]<=b || array[i] <= a && array[i] >= b)
                {
                    array[i] = double.MaxValue;
                    numbersOfDeletions++;
                }
            }

            Console.Write("New Array: ");
            if (numbersOfDeletions == n)
            {
                Console.Write("There is no element in the array");
            }

            else
            {
                for (i = 0; i < n; i++)
                   {
                    if (array[i] != double.MaxValue)
                    {

                        Console.Write(array[i] + " ");
                    }
                }
            }
        }
    }
}
#endregion