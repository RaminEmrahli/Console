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
            int numberInA = 0;//--------
            int numberInB = 0 ;
            int lengthA;
            int lengthB;
            double[] vectorA = null;
            double[] vectorB = null;
            inputA(out lengthA, out vectorA);
            inputB(out lengthB, out vectorB);
            Algorithm1OfVectorA(lengthA, ref numberInA, vectorA);//--------------------
            Algorithm1OfVectorB(lengthB, ref numberInB, vectorB);
            Algorithm2OfVectorA(lengthA, vectorA, numberInA);
            Algorithm2OfVectorB(lengthB, vectorB, numberInB);
            OutputOfVectorA(lengthA, vectorA);
            OutputOfVectorB(lengthB, vectorB);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] vectorA)
        {
           
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
        static void inputB(out int lengthB, out double[] vectorB)
        {
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
        static void Algorithm1OfVectorA(int lengthA, ref int numberInA, double[] vectorA)
        {
            numberInA = 0;
            for (int i = 0; i < lengthA; i++)
            {
                if (vectorA[i] >= 0 && vectorA[i] <= 1)
                {
                    numberInA++;//bool
                }
            }
        }
        static void Algorithm1OfVectorB(int lengthB, ref int numberInB, double[] vectorB)
        {
            numberInB = 0;
            for (int i = 0; i < lengthB; i++)
            {
                if (vectorB[i] >= 0 && vectorB[i] <= 1)
                {
                    numberInB++;
                }
            }
        }
        static void Algorithm2OfVectorA(int lengthA, double[] vectorA, int numberInA)
        {

            for (int i = 0; i < lengthA; i++)
            {
                if (vectorA[i] < 0)
                {
                    if (numberInA != 0)
                    {
                        vectorA[i] = 0;
                    }
                }
                else if (numberInA == 0)
                {
                    vectorA[i] = 1;
                }
            }
        }
        static void Algorithm2OfVectorB(int lengthB, double[] vectorB, int numberInB)
        {
            for (int i = 0; i < lengthB; i++)
            {
                if (vectorB[i] < 0)
                {
                    if (numberInB != 0)
                    {
                        vectorB[i] = 0;
                    }
                }
                else if (numberInB == 0)
                {
                    vectorB[i] = 1;
                }
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