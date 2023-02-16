using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int countw = 0;
            Console.WriteLine("Elementleri daxil edin:");

            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch == ',' && k == 1)
                {
                    countw++;
                }
                if (ch == 'w')
                {
                    k = 1;
                }
                else
                {
                    k = 0;
                }
            }
            if (countw >=0 && k == 1)
            {
                Console.Write($"w ile biten sozlerin sayi ={countw + k}");
            }
            else if (countw >=0 && k == 0)
            {
                Console.Write($"w ile biten sozlerin sayi ={countw}");
            }
                Console.ReadKey();
        }
    }
}
