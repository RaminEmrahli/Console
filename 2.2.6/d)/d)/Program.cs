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
            int row = 0;
            int column = 0;
            int rowsCount = 0;
            int countOfProducts = 0;
            int countOfAnotherProducts = 0;
            double[,] matrix = null;

            Input(row, out matrix);
            OutputGivenMatrix(matrix);
            AlgorithmForOwnScalarProductOfRows(ref matrix, out rowsCount, ref countOfProducts);
            AlgorithmForScalarProductOfRowToAnotheRow(matrix, ref countOfAnotherProducts, rowsCount);
            Output(countOfAnotherProducts, countOfProducts);

            Console.ReadKey();
        }
        #region
        static void Input(int row,out double[,] matrix)
        {
            Console.Write("Enter row and column of square matrix :");
            row = int.Parse(Console.ReadLine());
            matrix = new double[row, row];
            Console.WriteLine("Enter elements of matrix  -->");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
        }
        static void OutputGivenMatrix(double[,] matrix)
        {
            Console.WriteLine("The given matrix  -->");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void AlgorithmForOwnScalarProductOfRows(ref double[,] matrix, out int rowsCount, ref int countOfProducts)
        {
            double ownScalarProductOfRow = 0;
            countOfProducts = 0;
            rowsCount = matrix.GetLength(0);
            for (int i = 0; i < rowsCount; i++)
            {
                for(int j = 0; j < rowsCount; j++)
                {
                    ownScalarProductOfRow = ownScalarProductOfRow + matrix[i, j] * matrix[i, j];
                }
                if (ownScalarProductOfRow == 1)
                {
                    countOfProducts++;
                }
                ownScalarProductOfRow = 0;
            }
        }
        static void AlgorithmForScalarProductOfRowToAnotheRow(double[,] matrix, ref int countOfAnotherProducts,int rowsCount)
        {
            double scalarProductOfRowToAnotherRow = 0;
            for (int i = 0; i < rowsCount-1; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    scalarProductOfRowToAnotherRow = scalarProductOfRowToAnotherRow + matrix[i, j] * matrix[i+1, j];
                }
                if(scalarProductOfRowToAnotherRow == 0)
                {
                    countOfAnotherProducts++;
                }
            }
        }
        static void Output(int countOfAnotherProducts,int countOfProducts)
        {
            if(countOfAnotherProducts == 2 && countOfProducts == 3)
            {
                Console.WriteLine("Matrix is orthonormal.");
            }
            else
            {
                Console.WriteLine("Matrix isn't orthonormal.");

            }
        }
        #endregion
    }
}