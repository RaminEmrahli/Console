using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_natural_ededinin_reqemleri_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded sayini daxil edin:");
            int n=int.Parse(Console.ReadLine());
            int k = 0, c = 0, a;
            while (n != 0)
            {
                a = n % 10;
                if (a >= 0)
                {
                    k++;
                }
                n = n / 10;
            }
            Console.Write($"k={k}");
            Console.ReadLine(); 
        }
    }
}
