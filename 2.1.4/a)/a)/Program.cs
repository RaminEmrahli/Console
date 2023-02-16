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
            reverseOrder();
            Console.ReadKey();
        }
        #region method
        static void reverseOrder()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            double sum = 0;
            double c = 0;
            double d = n - 1;
            double a = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.Write("New array:");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }
    }
}
#endregion