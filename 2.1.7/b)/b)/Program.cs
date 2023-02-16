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
            negativeNumbers();
            Console.ReadKey();
        }
        #region method
        static void negativeNumbers()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            double[] array = new double[n];
            int i;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Console.Write("Old array:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            double alternative=array[0];
            Console.WriteLine();

            if (array[0] < 0)
            {
                for (i = 0; i < n; i++)
                {
                    if (array[i] < 0)
                    {
                        array[i] = array[i] * alternative;
                    }
                }

                Console.Write("New Array: ");

                for (i = 0; i < n; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
            else
            {
                Console.Write("The first number is not negative");
            }
        }
    }
}
#endregion