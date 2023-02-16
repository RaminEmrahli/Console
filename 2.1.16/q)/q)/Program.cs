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
            double productOfA;
            double productOfB;
            double[] arrayA;
            double[] arrayB;
            inputA(out lengthA, out arrayA, out productOfA);
            inputB(out lengthB, out arrayB, out productOfB, out flag);
            Algorithm(lengthA, lengthB, ref productOfB, ref productOfA, arrayA, arrayB);
            Output(productOfB, productOfA, ref flag);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] arrayA, out double productOfA)
        {
            Console.Write("Enter length of array A:");
            lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array A:");
            arrayA = new double[lengthA];
            productOfA = 1;
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
        static void inputB(out int lengthB, out double[] arrayB, out double productOfB, out bool flag)
        {
            flag = true;
            Console.Write("Enter length of array B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array B:");
            arrayB = new double[lengthB];
            productOfB = 1;
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
        static void Algorithm(int lengthA, int lengthB, ref double productOfB, ref double productOfA, double[] arrayA, double[] arrayB)
        {

            for (int i = 0; i < lengthA; i++)
            {
                if (arrayA[i] != 0)
                {
                    productOfA = productOfA * arrayA[i];
                }
            }

            for (int i = 0; i < lengthB; i++)
            {
                if (arrayB[i] != 0)
                {
                    productOfB = productOfB * arrayB[i];
                }
            }
        }
        static void Output(double productOfB, double productOfA, ref bool flag)
        {
            if (productOfA > productOfB)
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