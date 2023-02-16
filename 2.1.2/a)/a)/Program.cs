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
            math();
            Console.ReadKey();
        }
        #region method
        static void math()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            double sum = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                sum = sum + (Math.Pow(-1, i + 1) * array[i]);
            }
            Console.WriteLine($"result={sum}");
        }
    }
}
#endregion