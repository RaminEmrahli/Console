using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tekrar();
            Console.ReadKey();
        }
        #region methods
        static void tekrar()
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ededleri daxil edin:");
            int[] a = new int[n];
            int c = 0;
            int k = 0;
            int d = 0;
            int alternativ = 0;
            int i;
            for (i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();
            Console.Write("Ededler:");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                if (a[i] == c)
                {
                    k++;
                    if (k >= 2)
                    {
                        alternativ = a[i];
                    }
                }
                else
                {
                    if (k >= 2)
                    {
                        Console.Write($"{k}dene ");
                        Console.WriteLine(alternativ);

                    }
                    c = a[i];
                    k = 1;
                }
            }
            if (k>=2) { 
            Console.Write($"{k}dene ");
            Console.WriteLine(alternativ);
        }
        }
        #endregion
    }
}
