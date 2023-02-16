using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowA = 0;
            int columnA = 0;
            double[,] matrixA = null;
            double[] vectorA = null;

            Input(rowA, columnA, out matrixA);
            AlgorithmForCreatingNewVector(matrixA, ref vectorA);
            OutputMatrix(matrixA);
            OutputVector(vectorA);

            Input(rowA, columnA, out matrixA);
            AlgorithmForCreatingNewVector(matrixA, ref vectorA);
            OutputMatrix(matrixA);
            OutputVector(vectorA);

            Input(rowA, columnA, out matrixA);
            AlgorithmForCreatingNewVector(matrixA, ref vectorA);
            OutputMatrix(matrixA);
            OutputVector(vectorA);

            Console.ReadKey();
        }
        #region methods
        static void Input(int rowA, int columnA, out double[,] matrixA)
        {
            Console.Write("Enter line of matrix :");
            rowA = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            columnA = int.Parse(Console.ReadLine());
            matrixA = new double[rowA, columnA];
            Console.WriteLine("Enter elements of matrix  -->");
            for (int i = 0; i < rowA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    matrixA[i, j] = double.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
        }

        static void AlgorithmForCreatingNewVector(double[,] matrixA, ref double[] vectorA)
        {
            double vectorElement = 0;
            int linesCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            vectorA = new double[columnsCount];
            for (int i = 0; i < columnsCount; i++)
            {
                for (int j = 0; j < linesCount; j++)
                {
                    if (matrixA[j, i] < 0)
                    {
                        vectorElement = vectorElement + matrixA[j, i];
                    }
                }
                vectorA[i] = vectorElement;
                vectorElement = 0;
            }
        }
        static void OutputMatrix(double[,] matrixA)
        {
            int linesCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            Console.WriteLine("The given matrix  -->");
            for (int i = 0; i < linesCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    Console.Write(matrixA[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void OutputVector(double[] vectorA)
        {
            int lengthOfVector=vectorA.Length;
            Console.Write("New vector -->");
            for (int i = 0; i < lengthOfVector; i++)
            {
                Console.Write(vectorA[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
#endregion

