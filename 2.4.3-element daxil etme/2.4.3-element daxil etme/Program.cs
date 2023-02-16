using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._3_element_daxil_etme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = InputArray();
            SortArray(array);
            double[]newArray = InsertElement(array);
            OutputArray(newArray);

            Console.ReadKey();
        }
        #region methods
        static double[] InputArray()
        {
            int length = int.Parse(Console.ReadLine());
            double[] array = new double[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            return array;
        }

        static double[] SortArray(double[] array)
        {
            int length = array.Length;
            double temp = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        static double[] InsertElement(double[] array)
        {
            int position = 0;
            int length = array.Length;
            double[] newArray = new double[length+1];
            Console.Write("Enter element to be inserted -->");
            double element = double.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                if (array[i] < element)
                {
                    position++;
                }
                else
                {
                    break;
                }
            }

            for (int i = length-1; i >=position; i--)
            {
                newArray[i+1] = array[i];
            }
            for (int i = 0; i < position; i++)
            {
                newArray[i]=array[i];
            }
            newArray[position] = element;
            return newArray;
        }

        static void OutputArray(double[] newArray)
        {
            int length = newArray.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(newArray[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
#endregion