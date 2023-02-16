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
            string[,] matrixA = InputMatrix();
            OutputGivenMatrix(matrixA);
            string[] newMatrix1;
            double[] newMatrix2;
            CreateNewArrayForPoints(matrixA, out newMatrix2);
            SortingArray(ref newMatrix2);
            CreateNewArrayForNames(out newMatrix1);
            OutputNewArray(newMatrix1,newMatrix2);

            Console.ReadKey();
        }
        #region Methods
        static string[,] InputMatrix()
        {
            string[,] matrixA = new string[10, 10];
            Console.WriteLine("Enter elements of matrix -->");
            for(int i = 0; i < 10; i++)
            {
                matrixA[i, i] = "X";
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i != j)
                    {
                        matrixA[i, j] = (Console.ReadLine());
                    }
                    if (matrixA[i, j] == "h")
                    {
                        matrixA[j, i] = "h";
                    }
                    if (matrixA[i, j] == "v")
                    {
                        matrixA[j, i] ="u";
                    }
                    else if(matrixA[i, j] == "u")
                    {
                        matrixA[j, i] = "v";
                    }
                }
            }
            Console.WriteLine();
            return matrixA;
        }

        static void CreateNewArrayForPoints(string[,] matrixA, out double[] newMatrix2)
        {
            newMatrix2 = null;
            newMatrix2 = new double[10];
            double sum = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (matrixA[i, j] == "v")
                    {
                        sum += 1;
                    }
                    if (matrixA[i, j] == "h")
                    {
                        sum += 0.5;
                    }
                }
                newMatrix2[i] = sum;
                sum=0;
            }
        }

        static void CreateNewArrayForNames(out string[] newMatrix1)
        {
            newMatrix1 = null;
            newMatrix1 = new string[10];
            newMatrix1[0] = "Ramin";
            newMatrix1[1] = "Eli";
            newMatrix1[2] = "Ruslan";
            newMatrix1[3] = "Ehmed";
            newMatrix1[4] = "Memmed";
            newMatrix1[5] = "Saleh";
            newMatrix1[6] = "Cavansir";
            newMatrix1[7] = "Amil";
            newMatrix1[8] = "Ramil";
            newMatrix1[9] = "Kamil";
        }

        static void SortingArray(ref double[] newMatrix2)
        {
            double temp = 0;
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    if(newMatrix2[j] < newMatrix2[j + 1])
                    {
                        temp = newMatrix2[j];
                        newMatrix2[j] = newMatrix2[j+1];
                        newMatrix2[j + 1] = temp;
                    }
                }
            }
        }

        static void OutputGivenMatrix(string[,] matrixA)
        {
            Console.WriteLine("The Given Matrix -->");
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

        static void OutputNewArray(string[] newMatrix1,double[]newMatrix2)
        {
            Console.WriteLine("New Matrix -->");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(newMatrix1[i]+" "+newMatrix2[i]);
            }
            Console.WriteLine();
        }
    }
}
#endregion