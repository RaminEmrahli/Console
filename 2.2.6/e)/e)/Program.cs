using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int rowsCount = 0;
            int countOfSumsOfRows = 0;
            int countOfSumsOfColumns = 0;
            double sumOfFirstRow = 0;
            double[,] matrix = null;

            Input(row, out matrix);
            OutputGivenMatrix(matrix);
            AlgorithmForSumOfFirstRow(matrix, out rowsCount, ref sumOfFirstRow);
            AlgorithmForSumOfAllRows(rowsCount, matrix, sumOfFirstRow, ref countOfSumsOfRows);
            AlgorithmForSumOfAllColumns(rowsCount, matrix, sumOfFirstRow, ref countOfSumsOfColumns);
            OutputMagic(countOfSumsOfColumns, countOfSumsOfRows, rowsCount);

            Console.ReadKey();
        }
        #region
        static void Input(int row, out double[,] matrix)
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
        static void AlgorithmForSumOfFirstRow(double[,] matrix, out int rowsCount, ref double sumOfFirstRow)
        {
            rowsCount = matrix.GetLength(0);
            sumOfFirstRow = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                sumOfFirstRow = sumOfFirstRow + matrix[0, i];
            }
        }
        static void AlgorithmForSumOfAllRows(int rowsCount, double[,] matrix, double sumOfFirstRow,ref int countOfSumsOfRows)
        {
            countOfSumsOfRows=0;
            double sumOfRows=0;
            for(int i = 1; i < rowsCount; i++)
            {
                for(int j = 0; j < rowsCount; j++)
                {
                    sumOfRows = sumOfRows + matrix[i, j];
                }
                if(sumOfRows == sumOfFirstRow)
                {
                    countOfSumsOfRows++;
                }
                sumOfRows = 0;
            }
        }
        static void AlgorithmForSumOfAllColumns(int rowsCount, double[,] matrix, double sumOfFirstRow,ref int countOfSumsOfColumns)
        {
            countOfSumsOfColumns = 0;
            double sumOfColumns = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    sumOfColumns = sumOfColumns + matrix[j, i];
                }
                if (sumOfColumns == sumOfFirstRow)
                {
                    countOfSumsOfColumns++;
                }
                sumOfColumns = 0;
            }
        }
        static void OutputMagic(int countOfSumsOfColumns, int countOfSumsOfRows, int rowsCount)
        {
            if(countOfSumsOfColumns == rowsCount && countOfSumsOfRows == rowsCount - 1)
            {
                Console.WriteLine("The given matrix is magic.");
            }
            else
            {
                Console.WriteLine("The given matrix is ordinary.");
            }
        }
        #endregion
    }
}