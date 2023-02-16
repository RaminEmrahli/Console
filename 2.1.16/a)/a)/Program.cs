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
            double[] arrayA;
            double[] arrayB;
            inputA(out lengthA, out arrayA);
            inputB(out lengthB, out arrayB,out flag);
            Output(lengthA, lengthB,ref flag);
            Console.ReadKey();
        }
        #region methods
        static void inputA(out int lengthA, out double[] arrayA)
        {
            Console.Write("Enter length of array A:");
            lengthA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array A:");
            arrayA = new double[lengthA];
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
        static void inputB(out int lengthB, out double[] arrayB,out bool flag)
        {
            flag = true;
            Console.Write("Enter length of array B:");
            lengthB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of array B:");
            arrayB = new double[lengthB];
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
        static void Output(int lengthA, int lengthB,ref bool flag)
        {
            
            if(lengthA > lengthB)
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