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
            double[,] matrixA = InputMatrix();
            OutputMatrix(matrixA);
            double[,] matrixB  =  AlgrorithmForCreatingNewMatrix(matrixA);
            OutputMatrix(matrixB);
            Console.ReadKey();
        }
        #region Metods
        static double[,] InputMatrix()
        {
            Console.Write("Enter line of matrix :");
            int  row = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            int column = int.Parse(Console.ReadLine());
            double[,] matrixA = new double[row, column];
            Console.WriteLine("Enter elements of matrix  -->");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrixA[i, j] = double.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
            return matrixA; 
        }

        static double[,] AlgrorithmForCreatingNewMatrix(double[,] matrixA)
        {
            int rowsCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            double[,] matrixB = new double[rowsCount, columnsCount];
            double sum = 0;
            int count = 0;
            int j = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for(j = 0; j < columnsCount; j++)
                {
                    if(i - 1 >= 0)
                    {
                        sum += matrixA[i-1, j];
                        count++;
                        if(j - 1 >= 0)
                        {
                            sum += matrixA[i - 1, j - 1];
                            count++;
                        }

                        if (j + 1 < columnsCount)
                        {
                            sum += matrixA[i - 1, j + 1];
                            count++;
                        }
                    }

                    if (j - 1 >= 0)
                    {
                        sum += matrixA[i, j - 1];
                        count++;
                    }

                    if (j + 1 < columnsCount)
                    {
                        sum += matrixA[i, j + 1];
                        count++;
                    }

                    if (i + 1 < rowsCount)
                    {
                        sum += matrixA[i + 1, j];
                        count++;
                        if (j - 1 >= 0)
                        {
                            sum += matrixA[i + 1, j - 1];
                            count++;
                        }

                        if (j + 1 < columnsCount)
                        {
                            sum += matrixA[i + 1, j + 1];
                            count++;
                        }
                    }

                    matrixB[i, j] = Math.Round((sum / count),2);
                    sum = 0;
                    count = 0;
                }
            }
            return matrixB;
        }

        static void OutputMatrix(double[,] matrixB)
        {
            int rowsCount = matrixB.GetLength(0);
            int columnsCount = matrixB.GetLength(1);
            Console.WriteLine("New Matrix -->");
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    Console.Write(matrixB[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion
    }
}