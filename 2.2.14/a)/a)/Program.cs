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
            double[,] matrix = InputMatrix();
            OutputGivenMatrixAndVector(matrix);
            double[,] vector = InputVector(matrix);
            OutputGivenMatrixAndVector(vector);
            double[,] newMatrix = AlgorithmForMultiplicationOfVectorAndMatrix(vector, matrix);
            OutputGivenMatrixAndVector(newMatrix);

            Console.ReadKey();
        }
        #region Methods
        static double[,] InputMatrix()
        {
            Console.Write("Enter line of matrix -->");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix -->");
            int col = int.Parse(Console.ReadLine());
            double[,] matrix = new double[row, col];
            Console.WriteLine("Enter elements of matrix  -->");
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

        static double[,] InputVector(double[,] matrix)
        {
            int length = matrix.GetLength(1);
            double[,] vector = new double[length,1];
            Console.WriteLine("Enter elements of vector -->");
            for (int i = 0; i < length; i++)
            {
                for(int j = 0; j < 1; j++)
                vector[i, j] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The Given Vector -->");
            return vector;
        }

        static void OutputGivenMatrixAndVector(double[,] matrix)
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

        static double[,] AlgorithmForMultiplicationOfVectorAndMatrix(double[,] vector, double[,] matrix)
        {
            double sum = 0;
            int i;
            int colsCount = matrix.GetLength(1);
            int rowsCount = matrix.GetLength(0);
            int colCountsOfNewMatrix = vector.GetLength(1);
            double[,] newMatrix=new double[rowsCount, colCountsOfNewMatrix];
            for (int k = 0; k < colCountsOfNewMatrix; k++)
            {
                for (i = 0; i < rowsCount; i++)
                {
                    for(int j = 0; j < colsCount; j++)
                    {
                        sum=sum+matrix[i,j]*vector[j,k];
                    }
                    newMatrix[i, k] = sum;
                    sum = 0;
                }
            }
            Console.WriteLine("New Matrix --> ");
            return newMatrix;
        }
    }
    }
    #endregion