using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simvollari daxil edin:");
            int countbrackets = 0;
            int k = 0;
            int d = 0;
            while (true)
            {
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch == '(')
                {
                    k++;
                }
                if (ch == ')')
                {
                    d++;
                    if (d>k)
                    {
                       
                        Console.Write("Moterize duzgun qoyulmuyub");
                        break;
                    }
                }
            }
            if (k == d)
            {
                Console.Write("Moterize duzgun qoyulub");
            }
            Console.ReadKey();  
        }
    }
}
