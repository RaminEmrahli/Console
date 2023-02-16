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
            minimum();
            Console.ReadKey();
        }
        #region method
        static void minimum()
        {
            Console.Write("Enter length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            int i;
            double min = double.MaxValue;
            double sum = 0;
            int index = 0;

            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
                sum=sum+array[i];
            }

            Console.Write("Old array:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                    break;
                }
            }
            double average= sum/n;
            array[index] =Math.Floor(average);
            Console.Write("New array: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
#endregion