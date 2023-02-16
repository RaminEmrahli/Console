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
            double minA = double.MaxValue;
            int lineA = 0;
            int columnA = 0;
            double[,] matrixA;

            double minB = double.MaxValue;
            int lineB = 0;
            int columnB = 0;
            double[,] matrixB;

            double minC = double.MaxValue;
            int lineC = 0;
            int columnC = 0;
            double[,] matrixC;

            input(out lineA, out columnA, out matrixA);
            algorithmOfFindingMinimum(lineA, columnA, ref matrixA, ref minA);
            output(minA);

            input(out lineB, out columnB, out matrixB);
            algorithmOfFindingMinimum(lineB, columnB, ref matrixB, ref minB);
            output(minB);

            input(out lineC, out columnC, out matrixC);
            algorithmOfFindingMinimum(lineC, columnC, ref matrixC, ref minC);
            output(minC);

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

        static void algorithmOfFindingMinimum(int lineA, int columnA, ref double[,] matrixA, ref double minA)
        {
            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    if (matrixA[i, j] < minA)
                    {
                        minA = matrixA[i, j];
                    }
                }
            }
        }
        static void output(double minA)
        {
            Console.Write($"The minimum element of the matrix={minA}");
            Console.WriteLine("\n");
        }
    }
}
#endregion