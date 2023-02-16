using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elementleri daxil edin:");
            int isaresayi= 0;
            int k = 0;
            int d = 0;
            int herfsayi=0;
            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch >= '0' && ch <= '9')
                {
                    k++;
                }
                else if (ch == '-' && k == 0 || ch == '+' && k == 0)
                {
                    isaresayi++;
                }
                else 
                {
                    d++;
                }
            }
            if (k !=0 && d==0 || k != 0 && d == 0 && isaresayi ==1)
            {
                Console.Write("Duzgun yazilis");
            }
            else
            {
                Console.Write("Sehv yazilis");
            }
            Console.ReadKey();
        }
    }
}
