using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pifaqor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;
            int rowsCount = 0;
            int columnsCount = 0;
            double[,] matrix = null;

            input(row,column,out matrix);
            AlgorithmForPifaqorElements(ref matrix, out rowsCount, out columnsCount);
            OutputMatrix(matrix, rowsCount, columnsCount);

            Console.ReadKey();
        }
        #region
        static void input(int row, int column, out double[,] matrix)
        {
            Console.Write("Enter line of matrix :");
            row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            column = int.Parse(Console.ReadLine());
            matrix = new double[row, column];
            Console.WriteLine();
        }
        static void AlgorithmForPifaqorElements(ref double[,] matrix,out int rowsCount, out int columnsCount)
        {
            rowsCount=matrix.GetLength(0);
            columnsCount=matrix.GetLength(1);
            for(int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    matrix[i, j] = i * j;
                }
            }
        }
        static void OutputMatrix(double[,] matrix, int rowsCount, int columnsCount)
        {
            
            Console.WriteLine("The given matrix  -->");
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
    }
}
#endregion