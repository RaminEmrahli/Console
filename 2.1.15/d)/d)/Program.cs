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
            int lengthA;
            int lengthB;
            double minOfA;
            double minOfB;
            double[] arrayA;
            double[] arrayB;
            inputA(out lengthA, out arrayA, out minOfA);
            inputB(out lengthB, out arrayB, out minOfB);
            Algorithm(lengthA, lengthB, ref minOfB, ref minOfA, arrayA, arrayB);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] arrayA, out double minOfA)
        {
            Console.Write("Enter length of array A:");
            lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array A:");
            arrayA = new double[lengthA];
            minOfA = double.MaxValue;
            for (int i = 0; i < lengthA; i++)
            {
                arrayA[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("array A: ");

            for (int i = 0; i < lengthA; i++)
            {
                Console.Write(arrayA[i] + " ");
            }
            Console.WriteLine();
        }
        static void inputB(out int lengthB, out double[] arrayB, out double minOfB)
        {
            Console.Write("Enter length of array B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array B:");
            arrayB = new double[lengthB];
            minOfB = double.MaxValue;
            for (int i = 0; i < lengthB; i++)
            {
                arrayB[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("array B: ");

            for (int i = 0; i < lengthB; i++)
            {
                Console.Write(arrayB[i] + " ");
            }
            Console.WriteLine();
        }
        static void Algorithm(int lengthA, int lengthB, ref double minOfB, ref double minOfA, double[] arrayA, double[] arrayB)
        {

            for (int i = 0; i < lengthA; i++)
            {
                if (arrayA[i] > 0 && arrayA[i] < minOfA)
                {
                    minOfA = arrayA[i];
                }
            }

            for (int i = 0; i < lengthB; i++)
            {
                if (arrayB[i] > 0 && arrayB[i] < minOfB)
                {
                    minOfB = arrayB[i];
                }
            }
            Console.Write($"The difference of minimums={Math.Abs(minOfA-minOfB)}");
        }
    }
}
#endregion