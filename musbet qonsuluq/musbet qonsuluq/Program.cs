using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musbet_qonsuluq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int k = 0, c = 0;
            for(int i = 1; i <= n; i++)
            {
                double a=double.Parse(Console.ReadLine());
                if (a < 0)
                {
                    k = 0;
                    continue;
                }
                if (a > 0)
                {
                    k++;
                    if (k >= 2)
                        c++;
                }
            }
            Console.Write($"Musbet qonsuluq sayi:c={c}");
            Console.ReadKey();
        }
    }
}
