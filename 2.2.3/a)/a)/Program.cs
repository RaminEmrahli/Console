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
            double [,] matrixA;

            int lineB = 0;
            int columnB = 0;
            double[,] matrixB;

            int lineC = 0;
            int columnC = 0;
            double[,] matrixC;

            input(out lineA, out columnA, out matrixA);
            algorithm(lineA, columnA, ref matrixA);
            output(lineA, columnA, matrixA);

            input(out lineB, out columnB, out matrixB);
            algorithm(lineB, columnB, ref matrixB);
            output(lineB, columnB, matrixB);

            input(out lineC, out columnC, out matrixC);
            algorithm(lineC, columnC, ref matrixC);
            output(lineC, columnC, matrixC);
          
            Console.ReadKey();
        }
        #region methods
        static void input(out int lineA,out int columnA,out double[,]matrixA)
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

        static void algorithm(int lineA,int columnA, ref double[,] matrixA)
        {
            for(int i = 0; i < lineA; i++)
            {
                for(int j = 0; j < columnA; j++)
                {
                    matrixA[i, j] = Math.Round((matrixA[i, j] / Math.Pow(matrixA[lineA - 1, columnA - 1],2)),2);
                }
            }
        }
        static void output(int lineA,int columnA, double[,] matrixA)
        {
            Console.WriteLine("New Matrix  -->");
            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
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