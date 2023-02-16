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
            int lineA = 0;
            int columnA = 0;
            double[,] matrixA = null;

            int lineB = 0;
            int columnB = 0;
            double[,] matrixB=null;

            int lineC = 0;
            int columnC = 0;
            double[,] matrixC=null;

            Input(lineA, columnA, out matrixA);//???????
            AlgorithmOfChangingOfNegativesWithZero(ref matrixA);
            Output(matrixA);

            Input(lineB, columnB, out matrixB);
            AlgorithmOfChangingOfNegativesWithZero(ref matrixB);
            Output(matrixB);

            Input(lineC, columnC, out matrixC);
            AlgorithmOfChangingOfNegativesWithZero(ref matrixC);
            Output(matrixC);

            Console.ReadKey();
        }
        #region methods
        static void Input(int lineA, int columnA, out double[,] matrixA)
        {
            Console.Write("Enter line of matrix :");
            lineA = int.Parse(Console.ReadLine());
            Console.Write("Enter column of matrix :");
            columnA = int.Parse(Console.ReadLine());
            matrixA = new double[lineA, columnA];
            Console.WriteLine("Enter elements of matrix  -->");
            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    matrixA[i, j] = double.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine();
        }

        static void AlgorithmOfChangingOfNegativesWithZero(ref double[,] matrixA)
        {
            int linesCount = matrixA.GetLength(0);
            int columnsCount=matrixA.GetLength(1);
            for (int i = 0; i < linesCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)//???????????????
                {
                    if(matrixA[i, j] < 0)
                    {
                        matrixA[i, j] = 0;
                    }
                }
            }
        }
        static void Output(double[,] matrixA)
        {
            int linesCount = matrixA.GetLength(0);
            int columnsCount = matrixA.GetLength(1);
            Console.WriteLine("New Matrix  -->");
            for (int i = 0; i < linesCount; i++)//??????????????????
            {
                for (int j = 0; j < columnsCount; j++)
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