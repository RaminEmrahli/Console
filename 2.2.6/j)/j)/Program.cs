using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace j_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int rowsCount = 0;
            double[,] matrix = null;

            Input(row, out matrix);
            OutputGivenMatrix(matrix);
            AlgorithmForFindingMinumumInRow(matrix, out rowsCount);
            
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
        static void AlgorithmForFindingMinumumInRow(double[,] matrix, out int rowsCount)
        {
            rowsCount = matrix.GetLength(0);
            double minimumInRow = double.MaxValue;
            double maximumInColumn = double.MinValue;
            int maxindex = 0;
            int minindex = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    if (matrix[i, j] < minimumInRow)
                    {
                        minimumInRow = matrix[i, j];
                        minindex = j;
                    }
                    if (j == rowsCount-1) {
                        for(int k = 0; k < rowsCount; k++)
                    
                            if (matrix[k, minindex] > maximumInColumn)
                            {
                                maximumInColumn = matrix[k, minindex];
                            }
                    }
                }
                if(maximumInColumn == matrix[i,minindex])
                {
                    Console.Write("İndex of saddle element-->");
                    Console.Write(i + "," + minindex);
                }
                maximumInColumn = double.MinValue;
                minimumInRow = double.MaxValue;
            }
        }
        #endregion
    }
}