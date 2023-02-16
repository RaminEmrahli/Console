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
            int index1 = 0;
            int index2 = 0;
            double max=double.MinValue;
            double[,] matrix = Input();
            Output(matrix);
            AlgorithmForFindingMaximum(matrix, ref index1, ref index2,ref max);
            AlgorithmForSlideTheMaximum(index1, index2, matrix,max);
            Output(matrix);

            Console.ReadKey();
        }
        #region Methods
        static double[,] Input()
        {
            Console.Write("Enter line of matrix -->");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix -->");
            int col = int.Parse(Console.ReadLine());
            double[,] matrix = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The given matrix -->");
            return matrix;
        }

        static void AlgorithmForFindingMaximum(double[,] matrix, ref int index1, ref int index2,ref double max)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            max = double.MinValue;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        index1 = i;
                        index2 = j;
                    }
                }
            }
        }

        static void AlgorithmForSlideTheMaximum(int index1, int index2, double[,] matrix,double max)
        {
            double temp = 0;
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            if (matrix[rowsCount - 1, colsCount - 1] != max)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    temp = matrix[index1, j];
                    matrix[index1, j] = matrix[rowsCount - 1, j];
                    matrix[rowsCount - 1, j] = temp;
                }
                for (int i = 0; i < rowsCount; i++)
                {
                    temp = matrix[i, index2];
                    matrix[i, index2] = matrix[i, colsCount - 1];
                    matrix[i, colsCount - 1] = temp;
                }
            }
            Console.WriteLine("New matrix -->");
        }

        static void Output(double[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
#endregion