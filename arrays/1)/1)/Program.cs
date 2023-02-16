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
            Massiv0();
            Console.ReadKey();
        }
        #region methods
        static void Massiv0()
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ededleri daxil edin:");
            int[] a = new int[n];
            int k = 0;
            int c = 0;
            int muxtelifededsayi = 0;
            int tekrarededsayi = 0;
            int i, j;
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
            Console.Write("Muxtelif ededler:");
            
            for (i = 0; i < n; i++)
            {
                k = 0;
                for (j = i+1; j < n; j++)
                {
                    if (a[j] == a[j - 1])
                    {
                        tekrarededsayi++;
                    }
                    if(a[i] == a[j])
                    {
                        k++;
                    }
                }
                if (k == 0)
                {
                    muxtelifededsayi++;
                    Console.Write(a[i]);
                    Console.Write(" ");
                }
        }
            Console.WriteLine();
            Console.Write($"muxtelifededsayi={muxtelifededsayi}");
            Console.WriteLine();
            if (tekrarededsayi > 0)
            {
                Console.Write("Tekrarlanan eded var");
            }
            else 
            {
                Console.Write("Tekrarlanan eded yoxdur");
            }
        }
        #endregion
    }
}
