using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int simvolsayi = 0;
            Console.WriteLine("Elementleri daxil edin:");

            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch >=0 && ch <= 127)
                {
                    simvolsayi++;
                }
            }
            Console.WriteLine($"simvolsayi ={ simvolsayi}");
            Console.ReadKey();
        }
    }
}
