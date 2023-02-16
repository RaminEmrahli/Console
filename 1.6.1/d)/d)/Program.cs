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
            Console.Write("Simvol sayini daxil edin:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            char ilksimvol = 'a';
            int say = 0;
            int i= 1;
            for ( i = 1; i <= n; i++)
            {
                char c = (char)Console.Read();
                if (c == ilksimvol)
                {
                    say++;
                    if (say >= 2)
                    {

                        Console.Write(c);
                        Console.Write(" ");
                    }
                }
                else if (c != ilksimvol)
                {
                    ilksimvol = c;
                    say = 1;
                }
        }
            Console.ReadKey();
            
        }
    }
}