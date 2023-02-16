using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Simvol sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            int asayi = 0;
            int alternativ = 0;
            for (int i = 1; i <= n; i++)
            {
                char c = (char)Console.Read();
                if (c ==firstelement)
                {
                    asayi++;
                }
                else
                {
                    if (asayi > alternativ)
                    {
                        alternativ = asayi;
                    }
                    asayi = 0;

                }
            }
            if (asayi > alternativ)
            {
                alternativ = asayi;
            }
            Console.Write($"Ardicil gelen a-larin en coxu={alternativ}");
            Console.ReadKey();
        }
    }
}
