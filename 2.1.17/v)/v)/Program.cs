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
            int indexMaxA;
            int indexMaxB;
            double maxA;
            double maxB;
            int lengthA;
            int lengthB;
            double[] vectorA;
            double[] vectorB;
            input(out lengthA, out vectorA, out indexMaxA,out maxA);
            input(out lengthB, out vectorB, out indexMaxB,out maxB);
            Algorithm1(lengthA, ref indexMaxA, vectorA, ref maxA);
            Algorithm1(lengthB, ref indexMaxB, vectorB, ref maxB);
            Algorithm2(indexMaxA, lengthA, vectorA, maxA);
            Algorithm2(indexMaxB, lengthB, vectorB, maxB);
            Output(lengthA, vectorA);
            Output(lengthB, vectorB);
            Console.ReadKey();
        }
        #region methods
        static void input(out int lengthA, out double[] vectorA, out int indexMaxA,out double maxA)
        {
            maxA = double.MinValue;
            indexMaxA = 0;
            Console.Write("Enter length of vector A:");
            lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of vector A:");
            vectorA = new double[lengthA];
            for (int i = 0; i < lengthA; i++)
            {
                vectorA[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("vector A: ");

            for (int i = 0; i < lengthA; i++)
            {
                Console.Write(vectorA[i] + " ");
            }
            Console.Write("\n\n");
        }
        static void Algorithm1(int lengthA, ref int indexMaxA, double[] vectorA,ref double maxA)
        {
            for (int i = 0; i < lengthA; i++)
            {
                if (vectorA[i] > maxA)
                {
                    maxA = vectorA[i];
                    indexMaxA = i;
                }
            }
        }
        static void Algorithm2(int indexMaxA, int lengthA, double[] vectorA,double maxA)
        {
            for (int i = indexMaxA; i < lengthA; i++)
            {
                vectorA[i] = maxA;
            }
        }
        static void Output(int lengthA, double[] vectorA)
        {
            Console.Write("New vector A: ");

            for (int i = 0; i < lengthA; i++)
            {
                Console.Write(vectorA[i] + " ");
            }
            Console.WriteLine();
        }
       
    }
}
#endregion