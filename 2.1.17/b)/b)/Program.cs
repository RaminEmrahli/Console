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
            int indexA;
            int indexB;
            int lengthA;
            int lengthB;
            double[] vectorA;
            double[] vectorB;
            inputA(out lengthA, out vectorA, out indexA);
            inputB(out lengthB, out vectorB, out indexB);
            Algorithm1OfVectorA(lengthA, ref indexA, vectorA);
            Algorithm1OfVectorB(lengthB, ref indexB, vectorB);
            Algorithm2(indexA, vectorA, vectorB, indexB);
            OutputOfVectorA(lengthA, vectorA);
            OutputOfVectorB(lengthB, vectorB);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] vectorA, out int indexA)
        {
            indexA = 0;
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
        static void inputB(out int lengthB, out double[] vectorB, out int indexB)
        {
            indexB = 0;
            Console.Write("Enter length of vector B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of vector B:");
            vectorB = new double[lengthB];

            for (int i = 0; i < lengthB; i++)
            {
                vectorB[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("vector B: ");

            for (int i = 0; i < lengthB; i++)
            {
                Console.Write(vectorB[i] + " ");
            }
            Console.Write("\n\n");
        }
        static void Algorithm1OfVectorA(int lengthA, ref int indexA, double[] vectorA)
        {
            for (int i = 0; i < lengthA; i++)
            {
                if (vectorA[i] < 0)
                {
                    indexA=i;
                    break;
                }
            }
        }
        static void Algorithm1OfVectorB(int lengthB, ref int indexB, double[] vectorB)
        {

            for (int i = 0; i < lengthB; i++)
            {
                if (vectorB[i] < 0)
                {
                    indexB = i; 
                }
            }
        }
        static void Algorithm2(int indexA, double[] vectorA, double[] vectorB, int indexB)
        {
                for (int i = 0; i < indexA; i++)
                {
                     vectorA[i] = 0;
                }

                for (int i = 0; i < indexB; i++)
                {
                        vectorB[i] = 0;
                }
            }
        static void OutputOfVectorA(int lengthA, double[] vectorA)
        {
            Console.Write("New vector A: ");

            for (int i = 0; i < lengthA; i++)
            {
                Console.Write(vectorA[i] + " ");
            }
            Console.WriteLine();
        }
        static void OutputOfVectorB(int lengthB, double[] vectorB)
        {
            Console.Write("New vector B: ");

            for (int i = 0; i < lengthB; i++)
            {
                Console.Write(vectorB[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
#endregion