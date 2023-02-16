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
             sifirlar();
             Console.ReadKey();
        }
        #region method
        static void sifirlar()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            int k = 0;
            double sum = 0;
            double product = 1;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (array[i] == 0)
                {
                    k++;
                }
                if (array[i] != 0 && k == 1)
                {
                    sum = sum + array[i];
                    product = product * array[i];
                }
            }
            if (k >= 2)
            {
                Console.WriteLine($"sum={sum}");
                Console.Write($"product={product}");
            }
            else
            {
                Console.WriteLine("Not Found two zeros");
            }
        }
    }
}
#endregion