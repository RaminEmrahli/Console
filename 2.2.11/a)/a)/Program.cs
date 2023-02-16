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
            int row = 0;
            bool flag = true;
            double[,] matrix = null;

            Input(row, out matrix);
            OutputGivenMatrix(matrix);
            AlgorithmForSymmetricMatrix(matrix, ref flag);
            Output(flag);

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
            int rowsCount = matrix.GetLength(0);
            Console.WriteLine("The given matrix  -->");
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < rowsCount; j++)
                {
                    Console.Write(matrix[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
       
        static void AlgorithmForSymmetricMatrix(double[,]matrix,ref bool flag)
        {
            flag = true;
            int rowsCount = matrix.GetLength(0);
            for(int i = 0; i < rowsCount-1; i++)
            {
                for(int j = 0; j < rowsCount; j++)
                {
                    if(i != j)
                    {
                        if(matrix[i, j] == matrix[j, i])
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                    }
                }
            }
        }

        static void Output(bool flag)
        {
            if(flag == true)
            {
                Console.WriteLine("The Given Matrix is symmetric");
            }
            else
            {
                Console.WriteLine("The Given Matrix isn't symmetric");
            }
        }
        #endregion
    }
}
