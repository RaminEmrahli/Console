using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowA = 0;
            int columnA = 0;
            double[,] matrixA = null;
            double minimumValueOfRowA = double.MaxValue;

            int rowB = 0;
            int columnB = 0;
            double[,] matrixB = null;
            double minimumValueOfRowB = double.MaxValue;

            int rowC = 0;
            int columnC = 0;
            double[,] matrixC = null;
            double minimumValueOfRowC = double.MaxValue;

            Input(rowA, columnA, out matrixA);
            AlgorithmForFindingTheMinimumValueInRowAndToDivideAllElementsToMinimum(ref matrixA, ref minimumValueOfRowA);
            Output(matrixA);

            Input(rowB, columnB, out matrixB);
            AlgorithmForFindingTheMinimumValueInRowAndToDivideAllElementsToMinimum(ref matrixB, ref minimumValueOfRowB);
            Output(matrixB);

            Input(rowC, columnC, out matrixC);
            AlgorithmForFindingTheMinimumValueInRowAndToDivideAllElementsToMinimum(ref matrixC, ref minimumValueOfRowC);
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
        static void AlgorithmForFindingTheMinimumValueInRowAndToDivideAllElementsToMinimum(ref double[,] matrixA, ref double minimumValueOfRowA)
        {
            minimumValueOfRowA = double.MaxValue;
            int rowsCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (matrixA[i, j] < minimumValueOfRowA)
                    {
                       minimumValueOfRowA = matrixA[i, j];
                    }
                    if (j == columnsCount - 1)
                    {
                        for (int k = 0; k < columnsCount; k++)
                        {
                            matrixA[i, k] = Math.Round(matrixA[i, k] / minimumValueOfRowA,2);
                        }
                    }
                }
                minimumValueOfRowA = double.MaxValue;
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

