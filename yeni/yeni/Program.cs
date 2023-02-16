using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            int j = 0;
            int index = 0;
            int index1 = 0;
            int k = 0;
            double sum = 0;
            double numberOfpositive = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            for(i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    numberOfpositive++;
                }

                if(array[i] < 0 && numberOfpositive != 0)
                {
                    index = i;
                    break;
                }
                if (index == 0)
                {
                    index = i;
                }
            }
            for (j = 0; j < index; j++)
            {
                sum=sum+array[j];
            }
            Console.WriteLine(sum / i);
            Console.ReadKey();
        }
    }
}
