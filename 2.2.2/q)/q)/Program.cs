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
            int indexOfLineA = 0;
            int indexOfColumnA = 0;
            double maxA = double.MinValue;
            int lineA = 0;
            int columnA = 0;
            double[,] matrixA;

            int indexOfLineB = 0;
            int indexOfColumnB = 0;
            double maxB = double.MinValue;
            int lineB = 0;
            int columnB = 0;
            double[,] matrixB;

            int indexOfLineC = 0;
            int indexOfColumnC = 0;
            double maxC = double.MinValue;
            int lineC = 0;
            int columnC = 0;
            double[,] matrixC;

            input(out lineA, out columnA, out matrixA);
            algorithmOfFindingMaximumAndIndex(lineA, columnA, ref matrixA, ref maxA,ref indexOfLineA, ref indexOfColumnA);
            output(maxA, indexOfLineA, indexOfColumnA);

            input(out lineB, out columnB, out matrixB);
            algorithmOfFindingMaximumAndIndex(lineB, columnB, ref matrixB, ref maxB,ref indexOfLineB,ref indexOfColumnB);
            output(maxB,indexOfLineB,indexOfColumnB);

            input(out lineC, out columnC, out matrixC);
            algorithmOfFindingMaximumAndIndex(lineC, columnC, ref matrixC, ref maxC,ref indexOfLineC,ref indexOfColumnC);
            output(maxC,indexOfLineC,indexOfColumnC);

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

        static void algorithmOfFindingMaximumAndIndex(int lineA, int columnA, ref double[,] matrixA, ref double maxA,ref int indexOfLineA, ref int indexOfColumnA)
        {
            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    if (matrixA[i, j] > maxA)
                    {
                        maxA = matrixA[i, j];
                        indexOfLineA = i;
                        indexOfColumnA = j;
                    }
                }
            }
        }
        static void output(double maxA, int indexOfLineA, int indexOfColumnA)
        {
            Console.WriteLine($"The maximum element of the matrix={maxA}");
            Console.Write("Index of the maximum --> "+ $"line={indexOfLineA} "+ $"column={indexOfColumnA}");
            Console.WriteLine("\n");
        }
    }
}
#endregion