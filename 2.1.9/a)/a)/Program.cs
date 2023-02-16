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
            scalarProduct();
            Console.ReadKey();
        }
        #region methods
        static void scalarProduct()
        {
            Algorithm();
        }

        private static void Algorithm()
        {
            int n;
            double[] vectorA, vectorB;
            double scalarProduct;
            Entrance(out n, out vectorA, out vectorB, out scalarProduct);

            for (int i = 0; i < n; i++)
            {
                scalarProduct = scalarProduct + vectorA[i] * vectorB[i];
            }

            Console.Write($"ScalarProduct={scalarProduct}");
        }

        private static void Entrance(out int n, out double[] vectorA, out double[] vectorB, out double scalarProduct)
        {
            Console.Write("Enter the length:");
            n = int.Parse(Console.ReadLine());
            vectorA = new double[n];
            vectorB = new double[n];
            scalarProduct = 0;
            Console.WriteLine("Enter symbols of vector A:");

            for (int i = 0; i < n; i++)
            {
                vectorA[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Vector A:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(vectorA[i] + " ");
                if (i == n - 1)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            Console.WriteLine("Enter symbols of vector B:");

            for (int i = 0; i < n; i++)
            {
                vectorB[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Vector B:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(vectorB[i] + " ");
                if (i == n - 1)
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
#endregion