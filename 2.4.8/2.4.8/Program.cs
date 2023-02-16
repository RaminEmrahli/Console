using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matrix = InputMatrix();
            Output(matrix);
            double[] vector = CreatingVector(matrix);
            SortRowsOfMatrix(matrix, vector);
            Output(matrix);

            Console.ReadKey();
        }
        #region methods
        static double[,] InputMatrix()
        {
            Console.Write("Enter line of Matrix -->");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of Matrix -->");
            int col = int.Parse(Console.ReadLine());
            double[,] matrix = new double[row, col];
            Console.WriteLine("Enter elements of Matrix -->");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The Given Matrix -->");
            return matrix;
        }

        static double[] CreatingVector(double[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            double[] vector = new double[rowsCount];
            double sum = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for(int j = 0; j < colsCount; j++)
                {
                    sum += matrix[i, j];
                }
                vector[i]=sum;
                sum = 0;
            }
            return vector;
        }

        static double[,] SortRowsOfMatrix(double[,] matrix,double[] vector)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            double min = double.MaxValue;
            int minIndex = 0;
            double temp = 0;
            for (int i = 0; i < rowsCount-1; i++)
            {
                for (int k = 0; k < rowsCount; k++)
                {
                    if (vector[k] < min)
                    {
                        min = vector[k];
                        minIndex = k;
                    }
                }

                for (int j = 0; j < colsCount; j++)
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[minIndex, j];
                    matrix[minIndex, j] = temp;
                }

                vector[minIndex] = double.MaxValue;
                min = double.MaxValue;
            }
            Console.WriteLine("The Sorted Matrix -->");
            return matrix;
        }

        static void Output(double[,] matrix)
        {
            int rowsCount = matrix.GetLength(0);
            int colsCount = matrix.GetLength(1);
            for(int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    Console.Write(matrix[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
#endregion