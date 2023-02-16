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
            double sumOfDioganalElementsA = 0;
            int lineA = 0;
            int columnA = 0;
            double[,] matrixA;

            double sumOfDioganalElementsB = 0;
            int lineB = 0;
            int columnB = 0;
            double[,] matrixB;

            double sumOfDioganalElementsC = 0;
            int lineC = 0;
            int columnC = 0;
            double[,] matrixC;

            input(out lineA, out columnA, out matrixA);
            algorithmForTheSumOfDiagonalElements(lineA, columnA, matrixA, ref sumOfDioganalElementsA);
            output(sumOfDioganalElementsA);

            input(out lineB, out columnB, out matrixB);
            algorithmForTheSumOfDiagonalElements(lineB, columnB, matrixB, ref sumOfDioganalElementsB);
            output(sumOfDioganalElementsB);

            input(out lineC, out columnC, out matrixC);
            algorithmForTheSumOfDiagonalElements(lineC, columnC, matrixC, ref sumOfDioganalElementsC);
            output(sumOfDioganalElementsC);

            Console.ReadKey();
        }
        #region methods
        static void input(out int lineA,out int columnA,out double[,] matrixA)
        {
            Console.Write("Enter line of the matrix:");
            lineA=int.Parse(Console.ReadLine());
            Console.Write("Enter column of the matrix:");
            columnA =int.Parse(Console.ReadLine());  
            matrixA = new double[lineA,columnA];
            Console.WriteLine("Enter elements of matrix-->");

            for(int i = 0; i < lineA; i++)
            {
                for(int j = 0; j < columnA; j++)
                {
                    matrixA[i,j] = double.Parse(Console.ReadLine());
                }
            }
        }
        static void algorithmForTheSumOfDiagonalElements(int lineA,int columnA,double[,] matrixA,ref double sumOfDioganalElementsA)
        {
            for(int i = 0; i < lineA; i++)
            {
                sumOfDioganalElementsA = sumOfDioganalElementsA+matrixA[i,i];
            }
        }
        static void output(double sumOfDioganalElementsA)
        {
            Console.WriteLine($"Sum of the dioganal elements={sumOfDioganalElementsA}");
            Console.WriteLine();
        }
    }
}
#endregion