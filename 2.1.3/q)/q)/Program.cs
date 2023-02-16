using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Positive();
            Console.ReadKey();
        }
        #region method
        static void Positive()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            int k = 0;
            double sum = 0;
            double numberOfpositive = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    k++;
                }

                if (array[i] > 0 && k >= 0)
                {
                    numberOfpositive++;
                    sum = sum + array[i];
                    k = 0;
                }

                if (k == 1 && i > 0)
                {
                    double avarage = sum / numberOfpositive;
                    Console.WriteLine($"Avarage={avarage:F}");
                    numberOfpositive = 0;
                    break;
                }
            }
             
            if (k >= 0 && numberOfpositive != 0)
            {
                Console.WriteLine($"sum={sum / numberOfpositive:F}");
            }
        }
    }
}
#endregion