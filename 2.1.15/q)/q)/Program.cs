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
            double maxOfA;
            double maxOfB;
            double[] arrayA;
            double[] arrayB;
            inputA(out lengthA, out arrayA, out maxOfA);
            inputB(out lengthB, out arrayB, out maxOfB);
            Algorithm(lengthA, lengthB, ref maxOfB, ref maxOfA, arrayA, arrayB);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] arrayA, out double maxOfA)
        {
            Console.Write("Enter length of array A:");
            lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array A:");
            arrayA = new double[lengthA];
            maxOfA = double.MinValue;
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
        static void inputB(out int lengthB, out double[] arrayB, out double maxOfB)
        {
            Console.Write("Enter length of array B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array B:");
            arrayB = new double[lengthB];
            maxOfB = double.MinValue;
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
        static void Algorithm(int lengthA, int lengthB, ref double maxOfB, ref double maxOfA, double[] arrayA, double[] arrayB)
        {

            for (int i = 0; i < lengthA; i++)
            {
                if (arrayA[i] > maxOfA)
                {
                    maxOfA = arrayA[i];
                }
            }

            for (int i = 0; i < lengthB; i++)
            {
                if (arrayB[i] > maxOfB)
                {
                    maxOfB = arrayB[i];
                }
            }
            Console.Write("The maximum element of array A: "+maxOfA+"\n");
            Console.Write("The maximum element of array B: " + maxOfB);
        }
    }
}
#endregion