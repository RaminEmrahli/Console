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
            maximum();
            Console.ReadKey();
        }
        #region method
        static void maximum()
        {
            Console.Write("Enter length:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers:");
            double []array=new double[n];
            int i;
            double max=double.MinValue;
            int index = 0;

            for (i = 0; i < n; i++)
            {
                array[i]=double.Parse(Console.ReadLine());
            }

            Console.Write("Old array: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max=array[i];
                    index = i;
                }
            }
            array[index] = array[0];
            array[0]=max;
            Console.Write("New array: ");

            for (i = 0; i < n; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
#endregion