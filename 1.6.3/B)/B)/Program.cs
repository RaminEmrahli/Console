using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            int asayi = 0;
            Console.WriteLine("Elementleri daxil edin:");

            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch != ',')
                {
                 k++;
                }
                if (ch == ',')
                {
                    k=0;
                }
                if (ch == 'a' && k == 1)
                {
                    asayi++;
                }
            }
            Console.Write($"a ile baslayan sozlerin sayi ={asayi}");
            Console.ReadKey();
        }
    }
}
