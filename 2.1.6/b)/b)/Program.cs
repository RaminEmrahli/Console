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
            Deletion();
            Console.ReadKey();
        }
        #region method
        static void Deletion()
        {
            int n, i;
            double[] array;
            double alternative;
            inputArray(out n, out array, out i);

            Console.Write("Old array:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (i = 0; i < n - 1; i++)
            {
                if (array[i] == 0)
                {
                    alternative = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = alternative;
                }
            }

            Console.Write("New Array: ");

            for (i = 0; i < n - 1; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        private static void inputArray(out int n, out double[] array, out int i)
        {
            Console.Write("Enter length:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            array = new double[n];
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
#endregion