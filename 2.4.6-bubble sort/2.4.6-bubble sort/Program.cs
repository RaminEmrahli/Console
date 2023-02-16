using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._6_bubble_sort
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
            for(int i = 0; i < length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return array;
        }

        static double[] SortArray(double[] array)
        {
            int length=array.Length;
            double temp = 0;
            for(int i = 0; i < length; i++)
            {
                for(int j = 0; j < length-1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        static void OutputArray(double[] array)
        {
            int length = array.Length;
            Console.WriteLine("The Sorted Array -->");
            for( int i = 0; i < length; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
#endregion