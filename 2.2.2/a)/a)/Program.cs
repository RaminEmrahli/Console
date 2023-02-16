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
            double sumA = 0;
            int lineA = 0;
            int columnA = 0;
            double[,] matrixA;

            double sumB = 0;
            int lineB = 0;
            int columnB = 0;
            double[,] matrixB;

            double sumC = 0;
            int lineC = 0;
            int columnC = 0;
            double[,] matrixC;

            input(out lineA, out columnA, out matrixA);
            algorithm(lineA, columnA, ref matrixA, ref sumA);
            output(sumA);

            input(out lineB, out columnB, out matrixB);
            algorithm(lineB, columnB, ref matrixB, ref sumB);
            output(sumB);

            input(out lineC, out columnC, out matrixC);
            algorithm(lineC, columnC, ref matrixC, ref sumC);
            output(sumC);

            Console.ReadKey();
        }
        #region methods
        static void input(out int lineA, out int columnA, out double[,] matrixA)
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

        static void algorithm(int lineA, int columnA, ref double[,] matrixA,ref double sumA)
        {
            for (int i = 0; i < lineA; i++)
            {
                for (int j = 0; j < columnA; j++)
                {
                    sumA = sumA + Math.Pow(matrixA[i, j], 2);

                }
            }
        }
        static void output(double sumA)
        {
            Console.Write($"The sum of the squares of the elements={sumA}");
            Console.WriteLine("\n");
        }
    }
}
#endregion