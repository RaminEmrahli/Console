using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q_
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
                if (c== ',')
                {
                    Console.Write($"index={i}");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
