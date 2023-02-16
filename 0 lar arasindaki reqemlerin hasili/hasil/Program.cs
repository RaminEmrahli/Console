using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            double p = 1;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    k++;
                    if (k == 2)
                        break;
                }
                    if ((a != 0) && (k > 0))
                    {
                        p = p * a;
                    }
            }
            if (p == 1)
            {
                Console.Write("axtarilan sifirlar tapilmadi");
            }
            else
            {
                Console.Write("0-lar arasindaki ededlerin hasili:");
                Console.Write(p);
            }
            Console.ReadKey();
        }
    }
}

