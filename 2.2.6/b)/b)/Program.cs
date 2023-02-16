using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;
            int row1 = 0;
            int row2 = 0;
            int rowsCount = 0;
            int columnsCount = 0;
            double[,] matrix = null;

            Input(row, column, out matrix, out row1, out row2);
            OutputGivenMatrix(matrix);
            AlgorithmForChangingRows(ref matrix, out rowsCount, out columnsCount, row1, row2);
            OutputNewMatrix(matrix, rowsCount, columnsCount);
            
            Console.ReadKey();
        }
        #region
        static void Input(int row, int column, out double[,] matrix, out int row1, out int row2)
        {
            Console.Write("Enter line of matrix :");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            column = int.Parse(Console.ReadLine());
            matrix = new double[row, column];
            Console.Write("Enter the rows you want to change-->");
            row1 = int.Parse(Console.ReadLine());
            row2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elements of matrix  -->");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
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

        static void AlgorithmForChangingRows(ref double[,] matrix,out int rowsCount, out int columnsCount, int row1, int row2)
        {
            double temp = 0;
            rowsCount = matrix.GetLength(0);
            columnsCount = matrix.GetLength(1);
            for (int j = 0; j < columnsCount; j++)
            {
                temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }
        }

        static void OutputNewMatrix(double[,] matrix,int rowsCount, int columnsCount)
        {
            Console.WriteLine("The changed matrix  -->");
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
    }
}