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
            int isaredeyismesi = 0;
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
            for (i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    k++;
                    if (array[i] > 0 && d > 0)
                    {
                        d = 0;
                        isaredeyismesi++;
                    }
                }
                if (array[i]<0) 
                {
                    d++;
                    if (array[i] < 0 && k > 0)
                    {
                        k = 0;
                        isaredeyismesi++;
                    }
                }
            }
            Console.Write($"isare deyismelerinin sayi={isaredeyismesi}");
        }
        #endregion
    }
}
