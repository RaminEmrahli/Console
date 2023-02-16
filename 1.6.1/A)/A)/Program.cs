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
            Console.Write("Simvol sayini daxil edin:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Simvollari daxil edin:");
            int say = 0;
            for(int i = 1; i <= n; i++)
            {
                char c=(char)Console.Read();
                if(c=='-' || c == '/' || c == '*' || c == '+')
                {
                    say++;
                }
            }
            Console.Write($"say={say}");
            Console.ReadKey();
        }
    }
}
