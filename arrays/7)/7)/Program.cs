using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            array();
            Console.ReadKey();
        }
        #region methods
        static void array()
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Ededleri daxil edin:");
            int i;
            int inversiyasayi = 0;
            int d = 0;
            int k = 0;
            for (i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Ededler:");
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            i = 0;
            while (true)
            {
                if (i >= n-1)
                {
                    break;
                }
                if (array[i] > array[i+1])
                {
                    inversiyasayi++;
                }
               
                i = i + 2;
            }

            Console.Write($"inversiyalarin sayi={inversiyasayi}");
        }
        #endregion
    }
}
