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
            int zerosOfA;
            int zerosOfB;
            double[] arrayA;
            double[] arrayB;
            inputA(out lengthA,out arrayA,out zerosOfA);
            inputB(out lengthB, out arrayB,out zerosOfB);
            Algorithm(lengthA, lengthB, ref zerosOfB, ref zerosOfA, arrayA, arrayB);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA,out double[]arrayA,out int zerosOfA)
        {
            Console.Write("Enter length of array A:");
            lengthA=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array A:");
            arrayA=new double[lengthA];
            zerosOfA = 0;
            for(int i = 0; i < lengthA; i++)
            {
                arrayA[i]=double.Parse(Console.ReadLine());
            }

            Console.Write("array A: ");

            for (int i = 0; i < lengthA; i++)
            {
                Console.Write(arrayA[i]+" ");
            }
            Console.WriteLine();
        }
        static void inputB(out int lengthB,out double[]arrayB, out int zerosOfB)
        {
            Console.Write("Enter length of array B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array B:");
            arrayB = new double[lengthB];
            zerosOfB = 0;
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
        static void Algorithm(int lengthA,int lengthB,ref int zerosOfB,ref int zerosOfA,double[] arrayA,double[] arrayB)
        {
          
            for (int i = 0; i < lengthA; i++)
            {
                if (arrayA[i] == 0)
                {
                    zerosOfA++;
                }
            }

            for (int i = 0; i < lengthB; i++)
            {
                if (arrayB[i] == 0)
                {
                    zerosOfB++;
                }
            }
            Console.Write($"The number of zeros={zerosOfA+zerosOfB}");
        }
    }
}
#endregion