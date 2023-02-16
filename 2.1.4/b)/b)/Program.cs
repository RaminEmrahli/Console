using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide_the_elements_to_right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            slideToleft();
            Console.ReadKey();
        }
        #region method
        static void slideToleft()
        {
            Console.Write("Enter the length:");
            int n = int.Parse(Console.ReadLine());
            double[] array = new double[n];
            Console.WriteLine("Enter the numbers");
            int i = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            double firstelement = array[0];
            for (i = 0; i < n-1; i++)
            {
                array[i] = array[i+1];
            }
            array[n-1] = firstelement;
            Console.Write("New array:");
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
#endregion