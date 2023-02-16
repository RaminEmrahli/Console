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
            newArray();
            Console.ReadKey();
        }
        #region method
        static void newArray()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            double sum = 0;
            double d = n - 1;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum = sum + array[i];
            }
            Console.Write("New array:");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{ ((sum - array[i]) / d):F}");
                Console.Write(" ");
            }
        }
    }
}
#endregion