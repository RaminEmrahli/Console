using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            slide();
            Console.ReadKey();
        }
        #region method
        static void slide()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Number of slides:");
            int k = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            int j = 0;
            double firstelement = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("Old array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (j = 1; j <= k; j++)
            {
                for (i = n - 1; i > 0; i--)
                {
                    if (i + 1 == n)
                    {
                        firstelement = array[i];
                    }
                    array[i] = array[i - 1];
                }
                array[0] = firstelement;
                Console.Write("New array ");
                Console.Write(j);
                Console.Write(": ");
                for (i = 0; i < n; i++)
                {
                    Console.Write(array[i]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
#endregion