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
            bool flag;
            int lengthA;
            int lengthB;
            double numberOfZerosB;
            double numberOfZerosA;
            double[] arrayA;
            double[] arrayB;
            inputA(out lengthA, out arrayA, out numberOfZerosA);
            inputB(out lengthB, out arrayB, out numberOfZerosB, out flag);
            Algorithm(lengthA, lengthB, ref numberOfZerosB, ref numberOfZerosA, arrayA, arrayB);
            Output(numberOfZerosA, numberOfZerosB, ref flag);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] arrayA, out double numberOfZerosA)
        {
            Console.Write("Enter length of array A:");
            lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array A:");
            arrayA = new double[lengthA];
            numberOfZerosA = 0;
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
        static void inputB(out int lengthB, out double[] arrayB, out double numberOfZerosB, out bool flag)
        {
            flag = true;
            Console.Write("Enter length of array B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array B:");
            arrayB = new double[lengthB];
            numberOfZerosB = 0;
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
        static void Algorithm(int lengthA, int lengthB, ref double numberOfZerosB, ref double numberOfZerosA, double[] arrayA, double[] arrayB)
        {

            for (int i = 0; i < lengthA; i++)
            {
                if (arrayA[i] == 0)
                {
                    numberOfZerosA++;
                }
            }

            for (int i = 0; i < lengthB; i++)
            {
                if (arrayB[i] == 0)
                {
                    numberOfZerosB++;
                }
            }
        }
        static void Output(double numberOfZerosA, double numberOfZerosB, ref bool flag)
        {
            if (numberOfZerosA > numberOfZerosB)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            Console.WriteLine(flag);
        }
    }
}
#endregion