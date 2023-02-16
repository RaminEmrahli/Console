using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ж_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Simvol sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            int herfsayi = 0;
            for (int i = 1; i <= n; i++)
            {
                char c = (char)Console.Read();
                if (c>='a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    herfsayi++;
                }
            }
            Console.WriteLine($"herfsayi={herfsayi}");
            Console.ReadKey();
        }
    }
}
