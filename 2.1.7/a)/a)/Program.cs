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
            mathematicalChange();
            Console.ReadKey();
        }
        #region method
        static void mathematicalChange()
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

            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                if(array[i] > 0)
                {
                    array[i] = Math.Pow(array[i],2);
                }
                else if(array[i] < 0)
                {
                    array[i]=Math.Abs(array[i]);
                }
            }

            Console.Write("New Array: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
#endregion