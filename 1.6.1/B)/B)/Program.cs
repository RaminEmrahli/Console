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
            Console.Write("Simvol sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            int k = 0;
            int d = 0;
            for (int i = 1; i <= n; i++)
            {
                char c = (char)Console.Read();
                if (c == '.')
                {
                    k++;
                }
                else
                {
                    if (k > d) { 
                    d = k;
                    k = 0;
                    }
                    
                }
            }
            if (d >= 3 || k>=3)
            {
                Console.Write("Ardicil 3 noqte tapildi");
            }
            else
            {
                Console.Write("Ardicil 3 noqte tapilmadi");
            }
            Console.ReadKey();
        }
    }
}
