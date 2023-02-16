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
            int simvolsayi = 0;
            int w = 0;
            int countword = 0;
            int a1 = 0;
            int a2 = 0;
            Console.WriteLine("Elementleri daxil edin:");

            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if(ch != ',')
                {
                    simvolsayi++;
                }
                if (ch == ',')
                {
                    simvolsayi=0;
                }
                if (ch == 'a' && simvolsayi==1)
                {
                    a1++;
                }
                if(ch == 'a' && simvolsayi>1)
                {
                    a2++;
                }
                else if(ch != 'a')
                {
                    a2 = 0;
                }
            }
            Console.WriteLine($"a ile baslayib a ile biten soz sayi={(a1+a2)/2}");
            Console.ReadKey();
        }
    }
}