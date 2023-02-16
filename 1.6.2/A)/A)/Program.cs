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
            Console.WriteLine("Simvollari daxil edin:");
            int countA = 0;
            int countB = 0;

            do
            {
                char a = '-';
                char ch = (char)Console.Read();
                if (ch == '.')
                {
                    break;
                }
                if (ch == 'a'|| ch=='A')
                {
                    countA++;
                }
                if (ch == 'b'|| ch=='B')
                {
                    countB++;
                }
            }
            while (true);
            if (countA > countB)
            {
                Console.WriteLine("True");
            }

            else if (countB > countA)
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();  
        }
    }
}
