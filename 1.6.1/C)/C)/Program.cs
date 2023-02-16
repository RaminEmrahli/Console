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
            Console.Write("Simvol sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            int k = 0;
            for (int i = 1; i <= n; i++)
            {
                char c = (char)Console.Read();
                if (c == 'a')
                {
                    k++;
                }
                else if (c != 'a')
                {
                    k = 0;
                }
                 if (k == 2)
                {
                    Console.Write($"index={i - 1}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
