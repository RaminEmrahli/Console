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
            double[] arrayA = InputArray();
            SortArray(arrayA);
            double[] arrayB = InsertElement(arrayA);
            double[] newArray = CreateSortedArray(arrayA, arrayB);
            OutputArray(newArray);

            Console.ReadKey();
        }
        #region methods
        static double[] InputArray()
        {
            Console.Write("Enter length of array:");
            int lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array -->");
            double[] arrayA = new double[lengthA];
            for (int i = 0; i < lengthA; i++)
            {
                arrayA[i] = double.Parse(Console.ReadLine());
            }
            return arrayA;
        }

        static double[] SortArray(double[] arrayA)
        {
            int lengthA = arrayA.Length;
            double temp = 0;
            for (int i = 0; i < lengthA; i++)
            {
                for (int j = 0; j < lengthA - 1; j++)
                {
                    if (arrayA[j] > arrayA[j + 1])
                    {
                        temp = arrayA[j];
                        arrayA[j] = arrayA[j + 1];
                        arrayA[j + 1] = temp;
                    }
                }
            }
            return arrayA;
        }

        static double[] InsertElement(double[] arrayA)
        {
            double[] arrayB = InputArray();
            SortArray(arrayB);
            int lengthA = arrayA.Length;
            int lengthB = arrayB.Length;
            double[] newArray = new double[lengthA + lengthB];
            double temp = 0;
            for (int k = 0; k < lengthB; k++)
            {
                for (int i = 0; i < lengthA; i++)
                {
                    if (arrayA[i] > arrayB[k])
                    {
                        temp = arrayA[i];
                        arrayA[i] = arrayB[k];
                        arrayB[k] = temp;
                    }
                }
            }
                return arrayB;
        }

        static double[] CreateSortedArray(double[] arrayA, double[] arrayB)
        {
            SortArray(arrayB);
            int lengthA = arrayA.Length;
            int lengthB = arrayB.Length;
            double[] newArray = new double[lengthA + lengthB];
            for (int i = 0; i < lengthA; i++)
            {
                newArray[i] = arrayA[i];
            }

            for(int i = 0; i < lengthB; i++)
            {
                newArray[lengthA + i] = arrayB[i];
            }
                return newArray;
        }

        static void OutputArray(double[] newArray)
        {
            int length = newArray.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(newArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion
