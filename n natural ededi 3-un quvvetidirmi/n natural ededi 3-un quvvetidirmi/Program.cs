using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace n_natural_ededi_3_un_quvvetidirmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            while (Math.Pow(3, a)<=n)
            {
              
                if (n==Math.Pow(3,a))
                {
                    Console.Write("Bu eded 3-un quvvetidir");
                    break;
                }
                a++;
            }
            if(Math.Pow(3, a) != n)
            {
                Console.Write("Bu eded 3-un quvveti deyil");
            }
            Console.ReadLine();
        }
    }
}
