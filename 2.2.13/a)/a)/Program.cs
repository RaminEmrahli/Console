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
            double[,] matrixA = Input();
            AlgorithmForSumOfElementsOfMatrices(matrixA);
            Output(matrixA);
           
            Console.ReadKey();
        }
        #region Methods
        static double[,] Input()
        {
            Console.Write("Enter line of Matrix -->");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of Matrix -->");
            int col = int.Parse(Console.ReadLine());
            double[,] matrixA = new double[row,col];
            Console.WriteLine("Enter elements of matrix -->");
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    matrixA[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("The Given Matrix -->");
            Output(matrixA);
            return matrixA;
        }

        static double[,] AlgorithmForSumOfElementsOfMatrices(double[,] matrixA)
        {
            int rowsCount=matrixA.GetLength(0);
            int colsCount=matrixA.GetLength(1);
            double[,] matrixB = Input();
            for (int i = 0; i < rowsCount; i++)
            {
                for(int j = 0; j < colsCount; j++)
                {
                    matrixA[i, j] = matrixA[i, j]+matrixB[i,j];
                }
            }
            Console.WriteLine("The sum of the given matrices");
            return matrixA;
        }

        static void Output(double[,] matrixA)
        {
            int rowsCount = matrixA.GetLength(0);
            int colsCount = matrixA.GetLength(1);
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
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