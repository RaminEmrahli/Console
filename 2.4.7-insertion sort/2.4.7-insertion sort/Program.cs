using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._7_insertion_sort
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
            double temp = 0;
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                temp=array[i];
                j = i - 1;
                while(j>= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
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

