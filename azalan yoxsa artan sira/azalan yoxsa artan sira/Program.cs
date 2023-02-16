using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azalan_yoxsa_artan_sira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            double c = -100;
            double b = 100;
            int k = 0;
            int d = 0;
            for (int i = 1; i <= n; i++)
            {

                double a = double.Parse(Console.ReadLine());
                if (a > c)
                {
                    c = a;
                    k++;

                    if (k == n)
                        Console.Write("Artan sira");
                }
                else if (a < b)
                {
                    b = a;
                    d++;
                    if (d == n)
                    Console.Write("Azalan sira");
                }
            }
                Console.ReadKey();  
        }
    }
}