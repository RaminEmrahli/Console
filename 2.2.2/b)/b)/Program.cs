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
            double productOfPositivesA = 1;
            int lineA = 0;
            int columnA = 0;
            double[,] matrixA;

            double productOfPositivesB = 1;
            int lineB = 0;
            int columnB = 0;
            double[,] matrixB;

            double productOfPositivesC = 1;
            int lineC = 0;
            int columnC = 0;
            double[,] matrixC;

            input(out lineA, out columnA, out matrixA);
            algorithm(lineA, columnA, ref matrixA, ref productOfPositivesA);
            output(productOfPositivesA);

            input(out lineB, out columnB, out matrixB);
            algorithm(lineB, columnB, ref matrixB, ref productOfPositivesB);
            output(productOfPositivesB);

            input(out lineC, out columnC, out matrixC);
            algorithm(lineC, columnC, ref matrixC, ref productOfPositivesC);
            output(productOfPositivesC);

            Console.ReadKey();
        }
        #region methods
        static void input(out int lineA, out int columnA, out double[,] matrixA)
        {
            Console.Write("Enter line of matrix :");
            lineA = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            columnA = int.Parse(Console.ReadLine());
            matrixA = new double[lineA, columnA];
            Console.WriteLine("Enter elements of matrix  -->");

            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    matrixA[i, j] = double.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
        }

        static void algorithm(int lineA, int columnA, ref double[,] matrixA, ref double productOfPositivesA)
        {
            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    if (matrixA[i, j] > 0)
                    {
                        productOfPositivesA = productOfPositivesA * matrixA[i, j];
                    }
                }
            }
        }
        static void output(double productOfPositivesA)
        {
            Console.Write($"The product of the positive elements={productOfPositivesA}");
            Console.WriteLine("\n");
        }
    }
}
#endregion