using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._5_selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = InputArray();
            SortArray(array);
            OutputArray(array);

            Console.ReadKey();
        }
        #region methods
        static double[] InputArray()
        {
            Console.Write("Enter length of array -->");
            int length = int.Parse(Console.ReadLine());
            double[] array = new double[length];
            Console.WriteLine("Enter elements of array -->");
            for (int i = 0; i < length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return array;
        }

        static double[] SortArray(double[] array)
        {
            int length = array.Length;
            int minIndex = 0;
            double min = double.MaxValue;
            double temp = 0;
            for (int i = 0; i < length-1; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        minIndex = j;
                    }
                }
                temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
                min = double.MaxValue;
            }
            return array;
        }

        static void OutputArray(double[] array)
        {
            int length = array.Length;
            Console.WriteLine("The Sorted Array -->");
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
#endregion
