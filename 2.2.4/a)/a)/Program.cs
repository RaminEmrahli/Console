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
            int rowA = 0;
            int columnA = 0;
            double[,] matrixA = null;

            int rowB = 0;
            int columnB = 0;
            double[,] matrixB = null;

            int rowC = 0;
            int columnC = 0;
            double[,] matrixC = null;

            Input(rowA, columnA, out matrixA);
            AlgorithmForTheLastElementOfRow(ref matrixA);
            Output(matrixA);

            Input(rowB, columnB, out matrixB);
            AlgorithmForTheLastElementOfRow(ref matrixB);
            Output(matrixB);

            Input(rowC, columnC, out matrixC);
            AlgorithmForTheLastElementOfRow(ref matrixC);
            Output(matrixC);

            Console.ReadKey();
        }
        #region methods
        static void Input(int rowA, int columnA, out double[,] matrixA)
        {
            Console.Write("Enter line of matrix :");
            rowA = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            columnA = int.Parse(Console.ReadLine());
            matrixA = new double[rowA, columnA];
            Console.WriteLine("Enter elements of matrix  -->");
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    matrixA[i, j] = double.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
        }

        static void AlgorithmForTheLastElementOfRow(ref double[,] matrixA)
        {
            int rowsCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (matrixA[i, columnsCount-1] != 0)
                    {
                        matrixA[i, j] = Math.Round(matrixA[i, j] / matrixA[i, columnsCount - 1],2);
                    }
                }
            }
        }
        static void Output(double[,] matrixA)
        {
            int rowsCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            Console.WriteLine("New Matrix  -->");
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    Console.Write(matrixA[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
#endregion